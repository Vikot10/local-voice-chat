using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using NAudio.Wave;

namespace kur_seti
{
    public partial class Menu : Form
    {
        int IndexIn=0, IndexOut=0;
        WaveIn wave;
        WaveOut waveOut;
        BufferedWaveProvider provider;
        IPAddress address= IPAddress.Parse("127.0.0.1");
        Socket socketUDP;
        Socket socketTCP;
        string _name;
        EndPoint remotePoint = null;
        Thread t, t1;
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(Socket sockTcp,Socket sockUdp, string name)
        {
            InitializeComponent();
            listView2.AutoScrollOffset = new Point(listView2.Width, listView2.Height);
            _name = name;
            nameClient.Text = _name;
            socketTCP = sockTcp;
            socketUDP = sockUdp;
            string[] serv= Response(ref socketTCP).Split('|');
            listView1.Items.Clear();
            for (int i = 0;i < serv.Length-1;i ++)
            {
                string[] vs = serv[i].Split('&');
                ListViewItem listItem = new ListViewItem($"{vs[0]}");
                ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem(listItem, $"({ vs[1] })");
                listItem.SubItems.Add(listViewSubItem);
                listView1.Items.Add(listItem);
            }
            t = new Thread(delegate () { ResponseAllTcp(ref socketTCP); });
            t.IsBackground = true;
            t.Start();
            t1 = new Thread(delegate () { ResponceUdp(); });
            t1.IsBackground = true;
            t1.Start();
        }
        private string Response(ref Socket temp)
        {
            // буфер для ответа
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] data = new byte[1024];
            //temp.ReceiveTimeout = 500;
            //while (true)
            //{
            //    try
            //    {
            //        bytes = temp.Receive(data, data.Length, 0);
            //        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            //        Console.WriteLine(builder.ToString());
            //    }
            //    catch (Exception ex)
            //    {
            //        //if (ex is SocketException)
            //        //Console.WriteLine(ex.Message);
            //        break;
            //    }
            //}
            do
            {
                bytes = temp.Receive(data, data.Length, 0);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (temp.Available > 0);
            return builder.ToString();
        }
        private void ResponseAllTcp(ref Socket temp)
        {
            while (true)
            {
                StringBuilder builder = new StringBuilder();
                int bytes = 0;
                byte[] data = new byte[1024];
                Action action = null;
                try
                {
                    do
                    {
                        try
                        {
                            bytes = temp.Receive(data, data.Length, 0);
                            builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Сокет разорвал соединение");
                            Application.Exit();
                        }
                    }
                    while (temp.Available > 0);
                    string[] vs = builder.ToString().Split('|');


                    switch (vs[0])
                    {
                        case "Connect":
                            if (vs[1] != "Failed")
                                action = () => ConnectToRoom(vs);
                            else
                                action = () => WarningConnect();
                            break;
                        case "Create":
                            if (vs[1] != "Failed")
                                action = ()=> CreateRoom(vs);
                            else
                                action = () => WarningCreate();
                            break;
                        case "LeaveMe":
                            action = () => LeaveMe(vs);
                            break;
                        case "NewClient":
                            action = () => AddNewClient(vs[1]);
                            break;
                        case "Speak":
                            action = () =>Speak(vs[1]);
                            break;
                        case "StopSpeak":
                            action = () => StopSpeak(vs[1]);
                            break;
                        case "Mute":
                            action = () => Mute(vs[1]);
                            break;
                        case "DelClient":
                            action =() => DelClient(vs[1]);
                            break;
                        case "Change":
                            action = () => Change(vs[1],vs[2]);
                            break;
                        case "Message":
                            action = () => GetMessage(vs[1]);
                            break;
                    }
                    if (InvokeRequired)
                    {
                        Invoke(action);
                    }
                    else
                    {
                        action();
                    }
                }
                catch (Exception ex)
                {
                    break;
                }
            }
        }
        private void GetMessage(string message)
        {
            listView2.Text+="\r\n"+(message); 
        }
        private void DelClient(string name)
        {
            listView1.Items.Remove(listView1.FindItemWithText(name));
        }
        private void LeaveMe(string[] mes)
        {
            EnableBut(false);
            listView1.Items.Clear();
            for (int i = 1; i < mes.Length-1; i++)
            {
                string[] vs = mes[i].Split('&');
                ListViewItem listItem = new ListViewItem($"{vs[0]}");
                ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem(listItem, $"{ vs[1] }");
                listItem.SubItems.Add(listViewSubItem);
                listView1.Items.Add(listItem);
            }

        }
        private void WarningConnect()
        {
            warning.Visible=true;
            warning.Text = "Кол-во участников максимально";
        }
        private void WarningCreate()
        {
            warning.Visible = true;
            warning.Text = "Комната с таким названием уже существует";
        }
        private void Change(string name,string size)
        {
            listView1.FindItemWithText(name).SubItems[1].Text = size;
        }
        private void Speak(string name)
        {
            listView1.FindItemWithText(name).SubItems[1].Text = "Speak";
        }
        private void StopSpeak(string name)
        {
            listView1.FindItemWithText(name).SubItems[1].Text = "";
        }
        private void Mute(string name)
        {
            listView1.FindItemWithText(name).SubItems[1].Text = "Mute";
        }
        private void ConnectToRoom(string[] mes)
        {
            EnableBut(true);
            int UDPport = Int32.Parse(mes[1]);
            remotePoint = new IPEndPoint(address, UDPport);
            listView1.Items.Clear(); 
            for (int i = 2; i < mes.Length; i++)
            {
                string[] vs = mes[i].Split('&');
                ListViewItem listItem = new ListViewItem(vs[0]);
                ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem(listItem, vs[1]);
                listItem.SubItems.Add(listViewSubItem);
                listView1.Items.Add(listItem);
            }
            ListViewItem listItem1 = new ListViewItem(_name);
            ListViewItem.ListViewSubItem listViewSubItem1 = new ListViewItem.ListViewSubItem(listItem1, "");
            listItem1.SubItems.Add(listViewSubItem1);
            listView1.Items.Add(listItem1);
            waveOut = new WaveOut();
            waveOut.DeviceNumber = IndexOut;
            waveOut.DesiredLatency = 100;

            provider = new BufferedWaveProvider(new WaveFormat(8000, 1));
            waveOut.Init(provider);
            waveOut.Play();
        }
        private void AddNewClient(string mes)
        {
            string[] vs = mes.Split('&');
            ListViewItem listItem = new ListViewItem($"{vs[0]}");
            ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem(listItem, $"{ vs[1] }");
            listItem.SubItems.Add(listViewSubItem);
            listView1.Items.Add(listItem);
        }
        private void CreateRoom(string[] mes)
        {
            for (int i = 1; i < mes.Length; i++)
            {
                string[] vs = mes[i].Split('&');
                ListViewItem listItem = new ListViewItem($"{vs[0]}");
                ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem(listItem, $"({ vs[1] })");
                listItem.SubItems.Add(listViewSubItem);
                listView1.Items.Add(listItem);
            }
        }
        private void EnableBut(bool flag)
        {
            listView2.Enabled = flag;
            Send.Visible=flag;
            Stop.Visible = flag;
            Speake.Visible = flag;
            Off.Visible = flag;
            listView2.Visible = flag;

            if(flag==false)
            {
                listView2.Text="";
                NameNewRoom.Visible = true;
                listView1.Size = new Size(503, listView1.Height);
                listView1.Columns[0].Width = 300;
                listView1.Columns[1].Width = 185;
                listView1.Columns[0].Text = "Название комнаты";
                listView1.Columns[1].Text = "Кол-во участников";
                AddLeaveServ.Location = new Point(511, 362);
                textBox1.Location = new Point(664, 379);
                textBox1.Multiline = false;
                textBox1.Size = new Size(310, 29);
                AddLeaveServ.Text = "Добавить\nкомнату";
                textBox1.MaxLength = 16;
            }
            else
            {
                textBox1.Text = "";
                warning.Visible = false;
                NameNewRoom.Visible = false;
                listView1.Size = new Size(365, listView1.Height);
                listView1.Columns[0].Width = 230;
                listView1.Columns[1].Width = 80;
                listView1.Columns[0].Text = "Участники";
                listView1.Columns[1].Text = "Статус";
                AddLeaveServ.Location = new Point(385, 154);
                textBox1.Location = new Point(511, 617);
                textBox1.Multiline = true;
                textBox1.Size = new Size(671, 101);
                AddLeaveServ.Text = "Выйти из\nкомнаты";
                textBox1.MaxLength = 500;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listView1.SelectedItems.Count != 0)
            {
                SendMessage(ref socketTCP, $"Connect|{listView1.SelectedItems[0].Text}");
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void SendMessage(ref Socket handler,string message)
        {
            byte[] byteMessage;
            byteMessage = Encoding.Unicode.GetBytes(message);
            try
            {
                handler.Send(byteMessage, byteMessage.Length, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сокет разорвал соединение");
                Application.Exit();
            }
        }
        private void Speake_Click(object sender, EventArgs e)
        {
            SendMessage(ref socketTCP, "Speak|");
            wave = new WaveIn();
            wave.DeviceNumber = IndexIn;
            wave.BufferMilliseconds = 10;

            wave.DataAvailable += Wave_DataAvailable;
            wave.StartRecording();
            Speake.Enabled = false;
            Stop.Enabled = true;
        }
        private void ResponceUdp()
        {
            EndPoint remoteIp = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                try
                {
                    int bytes = 0;
                    do
                    {
                        try
                        {
                            byte[] data = new byte[160];
                            bytes = socketUDP.ReceiveFrom(data, ref remoteIp);
                            if (bytes != 0)
                                provider.AddSamples(data, 0, bytes);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Сокет разорвал соединение");
                            Application.Exit();
                        }
                    }
                    while (socketUDP.Available > 0);
                }
                catch(Exception ex)
                {
                    break;
                }
            }
        }

        private void Wave_DataAvailable(object sender, WaveInEventArgs e)
        {
            socketUDP.SendTo(e.Buffer, remotePoint);  
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            SendMessage(ref socketTCP, "StopSpeak|");
            Speake.Enabled = true;
            wave.StopRecording();
            wave.Dispose();
            Stop.Enabled=false;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>1)
            {
                SendMessage(ref socketTCP, $"Message|{textBox1.Text}");
                textBox1.Text = "";
            }
        }

        private void AddLeaveServ_Click(object sender, EventArgs e)
        {
            if (AddLeaveServ.Text[0] == 'Д')
            {
                if (textBox1.Text.Length >= 4)
                {
                    SendMessage(ref socketTCP, $"Create|{textBox1.Text}");
                }
                else
                {
                    warning.Visible = true;
                    warning.Text = "Длина слова должна быть больше 3";
                }
            }
            else
            {
                if(Speake.Enabled==false)
                {
                    Speake.Enabled=true;
                    Stop.Enabled=false;
                    wave.StopRecording();
                    wave.Dispose();
                }
                SendMessage(ref socketTCP, "LeaveMe|");
            }           
        }

        private void listView2_TextChanged(object sender, EventArgs e)
        {

        }

        private void settingsBut_Click(object sender, EventArgs e)
        {
            Settings form = new Settings(ref IndexIn,ref IndexOut);
            form.ShowDialog();
            IndexIn = form.IndexIn_;
            IndexOut = form.indexOut_;
            if (wave != null)
                wave.DeviceNumber = IndexIn;
            if(waveOut != null)
                waveOut.DeviceNumber = IndexOut;
        }

        private void Off_Click(object sender, EventArgs e)
        {
            if(Speake.Enabled==false && Stop.Enabled==false)
            {
                Speake.Enabled =true;
                Stop.Enabled =false;
                SendMessage(ref socketTCP, "Unmute|");

            }
            else if(Speake.Enabled==false)
            {
                Stop.Enabled = false;
                wave.StopRecording();
                wave.Dispose();
                SendMessage(ref socketTCP, "Mute|");
            }
            else 
            {
                Speake.Enabled = false;
                SendMessage(ref socketTCP, "Mute|");
            }
        }
    }
}
