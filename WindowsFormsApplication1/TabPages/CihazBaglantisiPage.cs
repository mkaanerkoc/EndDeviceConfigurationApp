using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using WindowsFormsApplication1.Managers;
using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1.TabPages
{
    public sealed partial class CihazBaglantisiPage : UserControl,ISerialToPageInterface
    {

        private static volatile CihazBaglantisiPage instance;
        private static object syncRoot = new Object();

        public CihazBaglantisiPage()
        {
            InitializeComponent();
            SerialPortManager.Instance.SetPageInterface(Application_TypesConstants.CihazBaglantisiPageID, this);
        }

        public static CihazBaglantisiPage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new CihazBaglantisiPage();
                    }
                }
                return instance;
            }
        }

        public void GetReceivedPackage(UInt16 msgID, byte[] rxBuffer, UInt16 messageLength)
        {
            switch (msgID)
            {
                case SerialPort_Constants.OUTGOING_CMD_TIME_RESPONSE:
                    devHourCb.Invoke((MethodInvoker)delegate
                    {
                        try
                        {
                            devHourCb.SelectedIndex = rxBuffer[5];
                            devMinCb.SelectedIndex = rxBuffer[6];
                            devSecCb.SelectedIndex = rxBuffer[7];
                        }
                        catch(Exception ee)
                        {
                            Console.WriteLine("Error when parsing ..." + ee.Message);
                        }
                    });

                    break;
                case SerialPort_Constants.OUTGOING_CMD_DATE_RESPONSE:
                    devDayCb.Invoke((MethodInvoker)delegate
                    {
                        try
                        {
                            devDayCb.SelectedIndex = rxBuffer[5]-1;
                            devMonthCb.SelectedIndex = rxBuffer[6]-1;
                            devYearCb.SelectedIndex = (rxBuffer[7] - 10);
                        }
                        catch (Exception ee)
                        {
                            Console.WriteLine("Error when parsing ..." + ee.Message);
                        }
                    });
                    break;

                default:
                    Console.WriteLine("<CihazBaglantisiPage> GetReceivedPackage -> Invalid MSG_ID for this page !! {0}", msgID);
                    break;
            }
        }
        private void commandBt1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Command1 Pressed");
            byte[] buf1 = { 0x03, 0x04, 0x00, 0x05, 0x00, 0x06, 10, 11, 12, 13, 14, 15, 0x23, 0x24 };
            SerialPortManager.Instance.SendDataToDevice(buf1, 14);
        }

        private void commandBt2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Command2 Pressed");
            byte[] buf1 = { 0x03, 0x04, 0x00, 0x06, 0x00, 0x07, 10, 11, 12, 13, 14, 15, 16, 0x25, 0x26 };
            SerialPortManager.Instance.SendDataToDevice(buf1, 15);
        }

        private void commandBt3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Command3 Pressed");
            byte[] buf1 = { 0x03, 0x04, 0x00, 0x07, 0x00, 0x0A, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 0x27, 0x28 };
            SerialPortManager.Instance.SendDataToDevice(buf1, 8);
        }

        private void commandBt4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Command4 Pressed");
            byte[] buf1 = { 0x03, 0x04, 0x00, 0x08, 0x00, 0x3, 10, 11, 12, 0x29, 0x30 };
            SerialPortManager.Instance.SendDataToDevice(buf1, 11);
        }

        private void refreshDevicesBtn_Click(object sender, EventArgs e)
        {
            fillPortList();
        }

        private void connectDeviceBtn_Click(object sender, EventArgs e)
        {
            if (!SerialPortManager.Instance.IsPortOpen())
            {
                if (devicesList.SelectedItem != null)
                {
                    if(SerialPortManager.Instance.Connect(devicesList.SelectedItem.ToString()))
                    {
                        connectDeviceBtn.Text = "Disconnect";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen COM port seçiniz", "Hata");
                }
            }
            else
            {
                if(SerialPortManager.Instance.Disconnect())
                {
                    connectDeviceBtn.Text = "Connect";
                }
            }
        }

        //Functions 
        private void fillPortList()
        {
            string[] ArrayComPortsNames = null;
            ArrayComPortsNames = SerialPort.GetPortNames();
            devicesList.Items.Clear();
            for (int i = 0; i < ArrayComPortsNames.Length; i++)
            {
                devicesList.Items.Add(ArrayComPortsNames[i]);
            }
        }




        private void clearRxBoxBtn_Click(object sender, EventArgs e)
        {
            rxDataBox.Text = "";
        }

        private void getDeviceTimeBtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[0];
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_TIME_GET_REQUEST, 0, outputData);
        }

        private void getDeviceDateBtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[0];
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_DATE_GET_REQUEST, 0, outputData);
        }

        private void setDeviceTimeBtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[3];
            outputData[0] = (byte)(devHourCb.SelectedIndex);
            outputData[1] = (byte)(devMinCb.SelectedIndex);
            outputData[2] = (byte)(devSecCb.SelectedIndex);
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_TIME_SET_REQUEST, 3, outputData);
        }

        private void setDeviceDateBtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[3];
            outputData[0] = (byte)(devDayCb.SelectedIndex+1);
            outputData[1] = (byte)(devMonthCb.SelectedIndex+1);
            outputData[2] = (byte)(devYearCb.SelectedIndex+10);
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_DATE_SET_REQUEST, 3, outputData);
        }

   
    }
}
