using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using NAudio.Wave;
using System.Net.Sockets;
using System.Text;

namespace kur_seti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registr_MouseMove(object sender, MouseEventArgs e)
        {
            registr.Font= new System.Drawing.Font(registr.Font.FontFamily, registr.Font.Size, System.Drawing.FontStyle.Underline);
        }

        private void registr_MouseLeave(object sender, EventArgs e)
        {
            registr.Font = new System.Drawing.Font(registr.Font.FontFamily, registr.Font.Size, System.Drawing.FontStyle.Italic);
        }

        private void registr_Click(object sender, EventArgs e)
        {
            if(registr.Text[0]=='З')
            {
                registr.Text = "Вернуться к входу";
                sign.Text = "Регистрация";
            }
            else
            {
                registr.Text = "Зарегистрироваться";
                sign.Text = "Войти";
            }
        }

        private void sign_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.ReceiveTimeout = 2000;
            try
            {
                socket.Connect(IPAddress.Parse("127.0.0.1"), 900);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
                return;
            }
            string message;
            string[] answer;
            byte[] byteMessage;
            if (sign.Text[0] == 'В')
            {
                message = "S|" + loginBox.Text + "|" + passBox.Text;
            }
            else
            {
                message = "R|" + loginBox.Text + "|" + passBox.Text;
            }
            byteMessage = Encoding.Unicode.GetBytes(message);
            socket.Send(byteMessage, byteMessage.Length, 0);
            answer = Response(ref socket).Split('|');
            if(answer[0]=="OK")
            {
                Socket handlerTCP = new Socket(SocketType.Stream, ProtocolType.Tcp);
                handlerTCP.Connect(IPAddress.Parse("127.0.0.1"),Int32.Parse(answer[2]));
                Socket handlerUDP = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); 
                IPEndPoint localUdpIp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 0);
                handlerUDP.Bind(localUdpIp);
               
                message = $"OK|{handlerUDP.LocalEndPoint.ToString().Split(':')[1]}";
                byteMessage = Encoding.Unicode.GetBytes(message);
                handlerTCP.Send(byteMessage, byteMessage.Length, 0);
                Menu form = new Menu(handlerTCP,handlerUDP,answer[1]);
                form.Show();
                this.Hide();
            }
            else
            {
                label1.Text=answer[0];
                label1.Visible = true;
            }
        }
        private string Response(ref Socket temp)
        {
            // буфер для ответа
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] data = new byte[1024];
            //temp.ReceiveTimeout = 1000;
            //while(true)
            //{
            //    try
            //    {
            //        bytes = temp.Receive(data, data.Length, 0);
            //        builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
            //        Console.WriteLine(builder.ToString());
            //    }
            //    catch(Exception ex)
            //    {
            //        //if (ex is SocketException)
            //            //Console.WriteLine(ex.Message);
            //        break;
            //    }
            //}
            do
            {
                try 
                { 
                    bytes = temp.Receive(data, data.Length, 0);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                    return "|";
                }
            }
            while (temp.Available > 0);
            return builder.ToString();
        }
    }
}
