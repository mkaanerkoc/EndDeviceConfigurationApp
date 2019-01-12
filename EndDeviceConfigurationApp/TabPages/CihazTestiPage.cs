using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Interfaces;
using WindowsFormsApplication1.Managers;

namespace WindowsFormsApplication1.TabPages
{
    public sealed partial class CihazTestiPage : UserControl,ISerialToPageInterface
    {
        private static volatile CihazTestiPage instance;
        private static object syncRoot = new Object();

        public CihazTestiPage()
        {
            InitializeComponent();
            SerialPortManager.Instance.SetPageInterface(Application_TypesConstants.CihazTestiPageID, this);
        }
        public static  CihazTestiPage Instance
        {
            get
            {
                if(instance==null)
                {
                    lock(syncRoot)
                    {
                        instance = new CihazTestiPage();
                    }
                }
                return instance;
            }
        }

        public void GetReceivedPackage(UInt16 msgID, byte[] rxBuffer, UInt16 messageLength)
        {
            switch(msgID)
            {
                case SerialPort_Constants.OUTGOING_CMD_READ_BME280_RESPONSE:
                    UInt32 tempInt = (UInt32)((rxBuffer[5] << 16) | (rxBuffer[6] << 8) | (rxBuffer[7]));
                    UInt32 humdInt = (UInt32)((rxBuffer[8] << 16) | (rxBuffer[9] << 8) | (rxBuffer[10]));
                    UInt32 presInt = (UInt32)((rxBuffer[11] << 16) | (rxBuffer[12] << 8) | (rxBuffer[13]));
                    float tempFloat = (float)tempInt / 1000;
                    float humdFloat = (float)humdInt / 1000;
                    float pressFloat = (float)presInt / 1000;
                    Console.WriteLine("OUTGOING_CMD_READ_BME280_RESPONSE received -> Temperature : {0}", tempFloat);
                    bme280TempTb.Invoke((MethodInvoker)delegate
                    {
                        bme280TempTb.Text = tempFloat.ToString();
                        bme280HumdTb.Text = humdFloat.ToString();
                        bme280PressTb.Text = pressFloat.ToString();
                    });
                    break;
                case SerialPort_Constants.OUTGOING_CMD_READ_MAX31865_RESPONSE:
                    UInt32 tempIntMax31865 = (UInt32)((rxBuffer[6] << 16) | (rxBuffer[7] << 8) | (rxBuffer[8]));
                    float max31865_temp = (float)tempIntMax31865 / 1000;
                    if(rxBuffer[5] == 0)
                    {
                        max_1_TempTb.Invoke((MethodInvoker)delegate
                        {
                            max_1_TempTb.Text = max31865_temp.ToString();
                        });
                    }
                    else if(rxBuffer[5] == 1)
                    {
                        max_2_TempTb.Invoke((MethodInvoker)delegate
                        {
                            max_2_TempTb.Text = max31865_temp.ToString();
                        });
                    }
                    else
                    {
                        Console.WriteLine("OUTGOING_CMD_READ_MAX31865_RESPONSE received invalid MAX31865_DevNum received ! ");
                        return;
                    }
                    break;
                case SerialPort_Constants.OUTGOING_CMD_GPS_LOCATION_RESPONSE:
                    for(int i = 0; i < messageLength;i++)
                    {
                        Console.Write(" {0:00}", rxBuffer[i]);
                    }
                    byte numberOfSats = (rxBuffer[5]);
                    float latitudeTemp = System.BitConverter.ToSingle(rxBuffer, 6);
                    float longtitudeTemp = System.BitConverter.ToSingle(rxBuffer, 10);
                    latitudeTb.Invoke((MethodInvoker)delegate
                    {
                        latitudeTb.Text = latitudeTemp.ToString();
                        longtitudeTb.Text = longtitudeTemp.ToString();
                        satsCountTb.Text = numberOfSats.ToString();
                    });
                    break;
                default:
                    break;
            }
        }

        private void readBme280Btn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[0];
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_READ_BME280_REQUEST, 0, outputData);
        }

        private void readMax31865_1_Btn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[1];
            outputData[0] = 0;
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_READ_MAX31865_REQUEST, 1, outputData);
        }

        private void readMax31865_2_Btn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[1];
            outputData[0] = 1;
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_READ_MAX31865_REQUEST, 1, outputData);
        }

        private void readGPSLocationBtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[0];
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_GET_GPS_LOCATION_REQUEST, 0, outputData);
        }
    }
}
