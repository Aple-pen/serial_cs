using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;

namespace SerialLib
{
    public delegate void DataGetEventHandler(string data); // 스트링 데이터 델리게이트(콘솔 메세지 용도)
    public delegate void GetReceiveDataHandler(Byte[] data); // 바이트 데이터 델리게이트(데이터 리시브 용도)
    
    public class Serial_lib
    {
        private const int QUEBUFFSIZE = 2048; //큐버퍼 최대사이즈
        private const int RECBUFFSIZE = 2048; //리시브 최대사이즈
        private const byte CR = 0x0D; //캐리지 리턴
        
        private Thread DataReadThread;
        
        public DataGetEventHandler DataSendEvent; //string 데이터 외부로 전달
        public GetReceiveDataHandler GetReceiveByte; //byte 데이터 외부로 전달
        
        private string Comport { get; set; }
        private int Rate { get; set; }
        private StopBits StopBit { get; set; } = StopBits.One;
        private int DataBits { get; set; } = 8;
        private Parity ParityBits { get; set; } = Parity.None;
        private bool Connected { get; set; } = false;
        
        public byte[] QueBuff = new byte[QUEBUFFSIZE]; //큐버퍼
        public byte[] RecBuff = new byte[RECBUFFSIZE]; //리시브 버퍼

        public uint QueHead = 0;
        public uint QueTail = 0;
        public uint CompleteIndex = 0;

        private SerialPort port;
        
        public Serial_lib(string com,int rate)
        {
            port = new SerialPort();
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            this.Comport = com;
            this.Rate = rate;
        }

        private void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] receiveBuf = new byte[QUEBUFFSIZE];
                int nRdLen = port.Read(receiveBuf, 0, QUEBUFFSIZE);
                
                for (int k = 0; k < nRdLen; k++)
                {
                    QueBuff[QueHead] = receiveBuf[k];
                    QueHead = (uint)((QueHead + 1) % QUEBUFFSIZE);
                }
            }
            catch
            {
                
            }
        }
        private void ReadBufferData()
        {
            while (Connected)
            {
                if (QueHead != QueTail)
                {
                    byte r = QueBuff[QueTail];
                    QueTail = (uint)((QueTail + 1) % QUEBUFFSIZE);
                    RecBuff[CompleteIndex] = r;
                    CompleteIndex++;
                    if (r == CR) // 데이터의 끝
                    {
                        GetReceiveByte(RecBuff);
                        RecBuff = new byte[RECBUFFSIZE];
                        CompleteIndex = 0;
                    }
                }
            }
        }
        
        public Serial_lib()
        {
            this.Comport = "";
            this.Rate = 0;
        }

        public void Connect()
        {
            try
            {
                if (!Connected)
                {
                    DataReadThread = new Thread(ReadBufferData);
                    port.PortName = Comport;
                    port.BaudRate = Rate;
                    port.StopBits = StopBit;
                    port.DataBits = DataBits;
                    port.Parity = ParityBits;
                    
                    port.Open();
                    DataSendEvent("========= Port Open ============");

                    Connected = true;
                    
                    DataReadThread.Start();
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err);
            }
            
        }

        public void DisConnect()
        {
            if (port != null)
            {
                if (port.IsOpen)
                {
                    port.Close();
                    DataSendEvent("=========Port Close ============");
                    Connected = false;
                }
            }
        }
        
    }
}