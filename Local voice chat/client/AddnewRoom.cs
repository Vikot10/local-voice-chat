using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using NAudio.Wave;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kur_seti
{
    public partial class Settings : Form
    {
        public int IndexIn_,indexOut_;
        public Settings()
        {
            InitializeComponent();
            for (int deviceId = 0; deviceId < WaveIn.DeviceCount; deviceId++)
            {
                var deviceInfo = WaveIn.GetCapabilities(deviceId);
               comboBox1.Items.Add(deviceInfo.ProductName);
            }

            for (int deviceId = 0; deviceId < WaveOut.DeviceCount; deviceId++)
            {
                var deviceInfo = WaveOut.GetCapabilities(deviceId);
                comboBox2.Items.Add(deviceInfo.ProductName);
            }
        }
        public Settings(ref int IndexIn,ref int IndexOut)
        {
            InitializeComponent();
            for (int deviceId = 0; deviceId < WaveIn.DeviceCount; deviceId++)
            {
                var deviceInfo = WaveIn.GetCapabilities(deviceId);
                comboBox1.Items.Add(deviceInfo.ProductName);
            }

            for (int deviceId = 0; deviceId < WaveOut.DeviceCount; deviceId++)
            {
                var deviceInfo = WaveOut.GetCapabilities(deviceId);
                comboBox2.Items.Add(deviceInfo.ProductName);
            }
            IndexIn_ = IndexIn;
            indexOut_ = IndexOut;
            comboBox1.SelectedIndex = IndexIn;
            comboBox2.SelectedIndex = IndexOut;
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
                IndexIn_ = comboBox1.SelectedIndex;
            indexOut_=comboBox2.SelectedIndex;
        }
    }
}
