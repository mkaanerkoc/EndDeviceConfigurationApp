using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Managers;

using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1.TabPages
{
    public sealed partial class CihazKonfigurasyonPage : UserControl,ISerialToPageInterface
    {
        private static volatile CihazKonfigurasyonPage instance;
        private static object syncRoot = new Object();

       

        public CihazKonfigurasyonPage()
        {
            InitializeComponent();
            staticRoutingInfoListView.View = View.Details;
            SerialPortManager.Instance.SetPageInterface(Application_TypesConstants.CihazKonfigurasyonPageID, this);
        }
        public static CihazKonfigurasyonPage Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(syncRoot)
                    {
                        instance = new CihazKonfigurasyonPage();
                    }
                }
                return instance;
            }
        }
        // Handle packages coming from Serial  ...
        public void GetReceivedPackage(UInt16 msgID, byte[] rxBuffer, UInt16 messageLength)
        {
            switch(msgID)
            {
                case SerialPort_Constants.OUTGOING_CMD_DEVICE_UNIQUE_ID_RESPONSE:
                    devUniqueIDTb.Invoke((MethodInvoker)delegate
                    {
                        devUniqueIDTb.Text = (rxBuffer[5] << 8 | rxBuffer[6]).ToString();
                    });
                    break;
                case SerialPort_Constants.OUTGOING_CMD_DEVICE_LORA_ID_RESPONSE:
                    devLoraIDTb.Invoke((MethodInvoker)delegate
                    {
                        devLoraIDTb.Text = (rxBuffer[5]).ToString();
                    });
                    break;
                case SerialPort_Constants.OUTGOING_CMD_DEVICE_LORA_GATEWAY_ID_RESPONSE:
                    devGatewayIDTb.Invoke((MethodInvoker)delegate
                    {
                        devGatewayIDTb.Text = (rxBuffer[5]).ToString();
                    });
                    break;
                case SerialPort_Constants.OUTGOING_CMD_LORA_STATIC_ROUTING_TABLE_RESPONSE:
                    parseStaticRoutingTableMsg(rxBuffer);
                    break;
                case SerialPort_Constants.OUTGOING_CMD_LORA_CONFIG_RESPONSE:
                    devCodingRateCb.Invoke((MethodInvoker)delegate
                    {
                        try
                        {
                            devCodingRateCb.SelectedIndex = (int)(rxBuffer[5]-0x01);
                            devSpreadingFactorCb.SelectedIndex = (int)(rxBuffer[6]-0x06);
                            devBandwidthCb.SelectedIndex = (int)rxBuffer[7];
                        }
                        catch(ArgumentOutOfRangeException ee)
                        {
                            Console.WriteLine("Cannot parse OUTGOING_CMD_LORA_CONFIG_RESPONSE msg " + ee.Message);
                        }
                    });
                    break;
                default:
                    break;
            }
        }

        private void parseStaticRoutingTableMsg(byte[] buffer)
        {
            staticRoutingInfoListView.Invoke((MethodInvoker)delegate
            {
                staticRoutingInfoListView.Items.Clear();
            });
            for (int i = 0; i< Application_TypesConstants.MAX_STATIC_ROUTING_TABLE_SIZE; i++)
            {
                string[] newRoutingElement = new string[] { "", "", "" };
                newRoutingElement[0] = (buffer[5 + i * Application_TypesConstants.STATIC_ROUTING_TABLE_ELEMENT_SIZE]).ToString();
                newRoutingElement[1] = (buffer[6 + i * Application_TypesConstants.STATIC_ROUTING_TABLE_ELEMENT_SIZE]).ToString();
                newRoutingElement[2] = (buffer[7 + i * Application_TypesConstants.STATIC_ROUTING_TABLE_ELEMENT_SIZE]).ToString();
                staticRoutingInfoListView.Invoke((MethodInvoker)delegate
                {
                    staticRoutingInfoListView.Items.Add(new ListViewItem(newRoutingElement));
                });
            }
        }

        private void getDeviceUniqueIDbtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[0];
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_DEVICE_UNIQUE_ID_GET_REQUEST, 0, outputData);
        }

        private void setDeviceUniqueIDbtn_Click(object sender, EventArgs e)
        {
            UInt16 deviceUniqueID = 0x00;
            byte[] outputData = new byte[2];
            try
            {
                deviceUniqueID = Convert.ToUInt16(devUniqueIDTb.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Device Unique ID'sini uygun formatta giriniz");
                return;
            }
            outputData[0] = (byte)(deviceUniqueID >> 8);
            outputData[1] = (byte)(deviceUniqueID & 0xFF);
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_DEVICE_UNIQUE_ID_SET_REQUEST, 2, outputData);
        }

        private void setDeviceLoRaIDbtn_Click(object sender, EventArgs e)
        {
            byte deviceLoraID = 0x00;
            byte[] outputData = new byte[1];
            try
            {
                deviceLoraID = Convert.ToByte(devLoraIDTb.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Device Unique ID'sini uygun formatta giriniz");
                return;
            }
            if (deviceLoraID > Application_TypesConstants.MAX_UNIT_NUMBER_IN_NET)
            {
                MessageBox.Show(" LoRa ID'si " + Application_TypesConstants.MAX_UNIT_NUMBER_IN_NET.ToString() + " 'den büyük olamaz ...");
                return;
            }
            outputData[0] = (byte)(deviceLoraID);
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_DEVICE_LORA_ID_SET_REQUEST, 1, outputData);
        }
        private void setDeviceLoRaGatewayIDbtn_Click(object sender, EventArgs e)
        {
            byte deviceLoraGatewayID = 0x00;
            byte[] outputData = new byte[1];
            try
            {
                deviceLoraGatewayID = Convert.ToByte(devGatewayIDTb.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Device Unique ID'sini uygun formatta giriniz");
                return;
            }
            if( deviceLoraGatewayID > Application_TypesConstants.MAX_UNIT_NUMBER_IN_NET )
            {
                MessageBox.Show(" Gateway ID'si " + Application_TypesConstants.MAX_UNIT_NUMBER_IN_NET.ToString() + " 'den büyük olamaz ...");
                return;
            }
            outputData[0] = (byte)(deviceLoraGatewayID);
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_DEVICE_LORA_GATEWAY_ID_SET_REQUEST, 1, outputData);
        }



        private void getDeviceLoRaIDbtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[0];
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_DEVICE_LORA_ID_GET_REQUEST, 0, outputData);
        }

        private void getDeviceLoRaGatewayIDbtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[0];
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_DEVICE_LORA_GATEWAY_ID_GET_REQUEST, 0, outputData);
        }

        private void getRoutingInfoBtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[0];
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_LORA_STATIC_ROUTING_TABLE_GET_REQUEST, 0, outputData);
        }

        private void setLoraConfigurationsBtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[3];
            outputData[0] = (byte)(devCodingRateCb.SelectedIndex+0x01);
            outputData[1] = (byte)(devSpreadingFactorCb.SelectedIndex+0x06);
            outputData[2] = (byte)devBandwidthCb.SelectedIndex;
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_LORA_CONFIG_SET_REQUEST, 3, outputData);
        }

        private void getLoraConfigurationsBtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[0];
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_LORA_CONFIG_GET_REQUEST, 0, outputData);
        }

        private void staticRoutingInfoListView_ItemActivate(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("From : {0}, Destination {1}, NextHop : {2}", staticRoutingInfoListView.SelectedItems[0].SubItems[0].ToString(),
                                                                                        staticRoutingInfoListView.SelectedItems[0].SubItems[1].ToString(),
                                                                                        staticRoutingInfoListView.SelectedItems[0].SubItems[2].ToString()));
        }

        private void staticRoutingInfoListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*MessageBox.Show(string.Format("From : {0}, Destination {1}, NextHop : {2}", staticRoutingInfoListView.SelectedItems[0].SubItems[0].ToString(),
                                                                                        staticRoutingInfoListView.SelectedItems[0].SubItems[1].ToString(),
                                                                                        staticRoutingInfoListView.SelectedItems[0].SubItems[2].ToString()));*/
            if (staticRoutingInfoListView.SelectedItems.Count > 0)
            {
                st_rtFromTb.Text = staticRoutingInfoListView.SelectedItems[0].SubItems[0].Text;
                st_rtDestTb.Text = staticRoutingInfoListView.SelectedItems[0].SubItems[1].Text;
                st_rtNextHopTb.Text = staticRoutingInfoListView.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void setStaticRoutingInfoBtn_Click(object sender, EventArgs e)
        {
            if(staticRoutingInfoListView.SelectedItems.Count>0)
            {
                staticRoutingInfoListView.SelectedItems[0].SubItems[0].Text = st_rtFromTb.Text;
                staticRoutingInfoListView.SelectedItems[0].SubItems[1].Text = st_rtDestTb.Text;
                staticRoutingInfoListView.SelectedItems[0].SubItems[2].Text = st_rtNextHopTb.Text;
            }
        }

        private void setRoutingInfoBtn_Click(object sender, EventArgs e)
        {
            if(staticRoutingInfoListView.Items.Count!= Application_TypesConstants.MAX_STATIC_ROUTING_TABLE_SIZE)
            {
                MessageBox.Show("Öncelikle cihazdaki yönlendirme tablosunu çekiniz !");
                return;
            }
            byte[] outputData = new byte[Application_TypesConstants.STATIC_ROUTING_TABLE_ELEMENT_SIZE * Application_TypesConstants.MAX_STATIC_ROUTING_TABLE_SIZE];
            for(int i = 0; i < Application_TypesConstants.MAX_STATIC_ROUTING_TABLE_SIZE; i++)
            {
                byte fromUnit, nextUnit, destinationUnit;
                fromUnit = Convert.ToByte(staticRoutingInfoListView.Items[i].SubItems[0].Text);
                destinationUnit = Convert.ToByte(staticRoutingInfoListView.Items[i].SubItems[1].Text);
                nextUnit = Convert.ToByte(staticRoutingInfoListView.Items[i].SubItems[2].Text);

                outputData[i * Application_TypesConstants.STATIC_ROUTING_TABLE_ELEMENT_SIZE] = (byte)(fromUnit);
                outputData[i * Application_TypesConstants.STATIC_ROUTING_TABLE_ELEMENT_SIZE + 1] = (byte)(destinationUnit);
                outputData[i * Application_TypesConstants.STATIC_ROUTING_TABLE_ELEMENT_SIZE + 2] = (byte)(nextUnit);
            }
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_LORA_STATIC_ROUTING_TABLE_SET_REQUEST, (ushort)(Application_TypesConstants.STATIC_ROUTING_TABLE_ELEMENT_SIZE * Application_TypesConstants.MAX_STATIC_ROUTING_TABLE_SIZE), outputData);
        }
    }
}
