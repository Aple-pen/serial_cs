using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialLib;

namespace SerialLibrary
{
    public partial class Form1 : Form
    {
        private Serial_lib serial;
        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            PortBox.DataSource = new BindingList<string>()
            {
                "COM1","COM2","COM3","COM4","COM5","COM6","COM7","COM8","COM9","COM10"
            };
            RateBox.DataSource = new BindingList<int>()
            {
                1200,2400,4800,9600,14400,19200,38400,57600,115200
            };
            DatabitBox.DataSource = new BindingList<int>()
            {
                
                4, 5, 6, 7, 8
            };
            
            ParitybitBox.DataSource = new BindingList<string>()
            {
                "no", "odd", "even", "mark", "space"
            };
            StopbitBox.DataSource = new BindingList<string>()
            {
                "1", "1.5", "2"
            };

            PortBox.SelectedIndex = 5;
            DatabitBox.SelectedIndex = 4;
        }

        private void Evt(string str)
        {
            Debug.WriteLine(str);
        }

        private void ReceiveByte(byte[] data)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                string str = Encoding.Default.GetString(data);
                ReceiveBox.AppendText(str);
            }));
        }
        
        /// <summary>
        /// 시리얼 연결
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string comport = PortBox.SelectedItem.ToString();
            int rate = int.Parse(RateBox.SelectedItem.ToString());
            serial = new Serial_lib(comport,rate);
            
            serial.DataSendEvent += new DataGetEventHandler(this.Evt); 
            serial.GetReceiveByte += new GetReceiveDataHandler(this.ReceiveByte);
            
            serial.Connect();
        }

        /// <summary>
        /// 시리얼 연결 해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (serial == null)
            {
                MessageBox.Show("연결이 되지 않았습니다.");
                return;
            }
            serial.DisConnect();
        }
    }
}