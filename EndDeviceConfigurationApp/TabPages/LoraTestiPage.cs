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
    public sealed partial class LoraTestiPage : UserControl,ISerialToPageInterface
    {
        private const UInt16 MAX_NEIGHBOURLIST_SIZE = 20;
        private const UInt16 NEIGHBOUR_ELEMENT_SIZE = 8;

        /* ROUTING HEADER TYPE CONSTS */
        private const byte UNICAST_DIRECT_HEADER = 0;
        private const byte UNICAST_ROUTED_HEADER = 1;
        private const byte MULTICAST_DIRECT_HEADER = 2;
        private const byte MULTICAST_ROUTED_HEADER = 3;
        private const byte BROADCAST_HEADER = 4;


        private static volatile LoraTestiPage instance;
        private static object syncRoot = new Object();
        private List<ReceivedLoRaMessage> loraMessagesList;
        
        public LoraTestiPage()
        {
            InitializeComponent();
            SerialPortManager.Instance.SetPageInterface(Application_TypesConstants.LoraTestPageID, this);
            neighborListView.View = View.Details;
            rxPkgListView.View = View.Details;
            loraTimeOutTb.Enabled = true;
            loraRetryCountTb.Enabled = true;
            loraMessageTypeCb.SelectedIndex = 0;
            loraSendngPackageDataViewTypeCb.SelectedIndex = 0;
            goruntulemeSecimiCb.SelectedIndex = 0;
            loraServiceTypeCb.SelectedIndex = 0;
            loraMessagesList = new List<ReceivedLoRaMessage>();
        }
        public static LoraTestiPage Instance
        {
            get
            {
                if(instance==null)
                {
                    lock(syncRoot)
                    {
                        instance = new LoraTestiPage();
                    }
                }
                return instance;
            }
        }
        public void GetReceivedPackage(UInt16 msgID, byte[] rxBuffer, UInt16 messageLength)
        {
            switch (msgID)
            {
                case SerialPort_Constants.OUTGOING_CMD_NEIGHBOUR_LIST_RESPONSE:
                    parseNeighbourList(rxBuffer, messageLength);
                    break;
                case SerialPort_Constants.OUTGOING_CMD_LORA_ECHO_MONITOR_REPONSE:
                    if(rxBuffer[5]==0x00)
                    {
                        receiveLoRaRxPkgFromUARTCb.Invoke((MethodInvoker)delegate
                        {
                            receiveLoRaRxPkgFromUARTCb.Checked = Convert.ToBoolean(rxBuffer[6]);
                        });                        
                    }
                    //
                    break;
                case SerialPort_Constants.OUTGOING_CMD_LORA_RECEIVED_PACKAGE:
                    parseNewReceivedPackage(rxBuffer, messageLength);
                    break;
                default:
                    break;
            }
        }
            
        private void parseNeighbourList(byte[] buffer,UInt16 messageLength)
        {
            byte neighbourCount = buffer[5];
            neighborListView.Invoke((MethodInvoker)delegate
            {
                neighborListView.Items.Clear();
            });
            for (int i = 0; i < neighbourCount; i++)
            {
                string[] newNeighbourElement = new string[] { "", "", "" ,""};
                newNeighbourElement[0] = ((UInt16)(buffer[5 + i * NEIGHBOUR_ELEMENT_SIZE] << 8 | buffer[6 + i * NEIGHBOUR_ELEMENT_SIZE])).ToString();
                newNeighbourElement[2] = ((Int16)(buffer[7 + i * NEIGHBOUR_ELEMENT_SIZE] << 8 | buffer[8 + i * NEIGHBOUR_ELEMENT_SIZE])).ToString();
                newNeighbourElement[1] = ((UInt16)(buffer[12 + i * NEIGHBOUR_ELEMENT_SIZE])).ToString();
                newNeighbourElement[3] = string.Format("{0:00}:{1:00}:{2:00}", buffer[9 + i * NEIGHBOUR_ELEMENT_SIZE], buffer[10 + i * NEIGHBOUR_ELEMENT_SIZE], buffer[11 + i * NEIGHBOUR_ELEMENT_SIZE]);
                neighborListView.Invoke((MethodInvoker)delegate
                {
                    neighborListView.Items.Add(new ListViewItem(newNeighbourElement));
                });
            }
        }
        private void parseNewReceivedPackage(byte[] buffer, UInt16 messageLengthParam)
        {
            byte loraMessageDataLengthTemp = 0;
            byte parserByteTemp = 0;
            byte headerLengthInBytesTemp = 0;
            ReceivedLoRaMessage loraMsg = new ReceivedLoRaMessage();
            //Parsing Main Header

            // message type 
            loraMsg.messageType         = (byte)((buffer[5] & 0xF8) >> 3); /* msb 5 bits */
            // service type
            loraMsg.routingHeaderType   = (byte)((buffer[5] & 0x07) ); /* lsb 3 bits */
            
            // package receive time
            loraMsg.time            = DateTime.Now;
            // message RSSI 
            loraMsg.rssi            = (Int16)((buffer[messageLengthParam - 5] << 8) | (buffer[messageLengthParam - 4]));
            if (0 == loraMsg.routingHeaderType)  // UNICAST_DIRECT_HEADER
            {
                loraMsg.unicastDirectHeader.sourceUnit = buffer[6] ;
                loraMsg.unicastDirectHeader.destinationUnit = buffer[7] ;
                headerLengthInBytesTemp = 2;
            }
            else if (1 == loraMsg.routingHeaderType) // UNICAST_ROUTED_HEADER
            {
                loraMsg.unicastRoutedHeader.sourceUnit = buffer[6];
                loraMsg.unicastRoutedHeader.destinationUnit = buffer[7];
                loraMsg.unicastRoutedHeader.toUnit = buffer[8];
                loraMsg.unicastRoutedHeader.fromUnit = buffer[9];
                loraMsg.unicastRoutedHeader.hopIndex = buffer[10];
                headerLengthInBytesTemp = 5;
            }
            else if (2 == loraMsg.routingHeaderType)
            {
                // not implemented yet
            }
            else if (3 == loraMsg.routingHeaderType)
            {
                // not implemented yet
            }
            else if (4 == loraMsg.routingHeaderType)
            {
                // not implemented yet
            }
            loraMessageDataLengthTemp = (byte)(messageLengthParam - 8 - 2 - headerLengthInBytesTemp);

            for(int i = 0; i < loraMessageDataLengthTemp; i++)
            {
                loraMsg.data[i] = buffer[5 + headerLengthInBytesTemp + i];
            }
            loraMessagesList.Add(loraMsg);
            string[] newPackage = new string[] { "" ,"" ,""};
            newPackage[0] = Application_TypesConstants.MessageType_StringList[loraMsg.messageType];
            newPackage[1] = string.Format("{0:00}:{1:00}:{2:00}",loraMsg.time.Hour, loraMsg.time.Minute, loraMsg.time.Second);
            newPackage[2] = loraMsg.rssi.ToString();
            rxPkgListView.Invoke((MethodInvoker)delegate
            {
                rxPkgListView.Items.Add(new ListViewItem(newPackage));
            });
        }
        private void sendLoRaPackageBtn_Click(object sender, EventArgs e)
        {
            byte destinationID = 0x00;
            UInt16 msgTimeOut = 0x00;
            byte retryCount = 0x00;
            byte messageType = 0;
            if (0 == loraMessageTypeCb.SelectedIndex) /* PING MESSAGE */ 
            {
                messageType = 3;
            }
            else if ( 1 == loraMessageTypeCb.SelectedIndex ) /* ECHO MESSAGE */
            {
                messageType = 13;
            }
            else if ( 2 == loraMessageTypeCb.SelectedIndex ) /* UNCATEGORIZED RELIABLE MESSAGE */
            {
                messageType = 11;
            }
            else if (3 == loraMessageTypeCb.SelectedIndex) /* UNCATEGORIZED UNRELIABLE MESSAGE */
            {
                messageType = 10;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir mesaj türü seçiniz..");
            }

            byte serviceType = (byte)loraServiceTypeCb.SelectedIndex;
            byte msgLength = (byte)(txLoRaPackageDataTb.Text.Length);
            byte[] msgData = new byte[msgLength];
            byte[] packageData = new byte[msgLength + 9];
            try
            {
                destinationID = Convert.ToByte(txLoraPkgDestTb.Text);

                msgTimeOut = Convert.ToUInt16(loraTimeOutTb.Text);
                retryCount = Convert.ToByte(loraRetryCountTb.Text);
                msgData = Encoding.ASCII.GetBytes(txLoRaPackageDataTb.Text);
            }
            catch(Exception ee)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz");
            }

            packageData[0] = (byte)(destinationID);
            packageData[1] = messageType;
            packageData[2] = serviceType;
            packageData[3] = (byte)(msgTimeOut >> 8);
            packageData[4] = (byte)(msgTimeOut & 0xFF);
            packageData[5] = retryCount;
            packageData[6] = msgLength;
            Array.Copy(msgData, 0, packageData, 7 , msgLength);
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_LORA_SEND_PACKAGE_REQUEST,(ushort)(msgLength + 7), packageData);
        }

        private void getNeighbourListBtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[0];
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_NEIGHBOUR_LIST_GET_REQUEST, 0, outputData);
        }

        private void sendGetEchoSettingsBtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[1];
            outputData[0] = 0;
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_LORA_ECHO_MONITOR_GET_REQUEST, 1, outputData);
        }

        private void sendReceiveLoRaPackageCmdBtn_Click(object sender, EventArgs e)
        {
            byte[] outputData = new byte[2];
            outputData[0] = 0;
            if (receiveLoRaRxPkgFromUARTCb.Checked)
                outputData[1] = 1;
            else
                outputData[1] = 0;
            SerialPortManager.Instance.SendRemoteDeviceCmd(SerialPort_Constants.INCOMING_CMD_LORA_ECHO_MONITOR_SET_REQUEST, 2, outputData);
        }


        private void loraSendngPackageDataViewTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string packageDataStr = "";
            byte[] packageDataByteArray;
            if(loraSendngPackageDataViewTypeCb.SelectedIndex!=-1)
            {
                switch(loraSendngPackageDataViewTypeCb.SelectedIndex)
                {
                    case 0:
                        byte[] array = Encoding.ASCII.GetBytes(packageDataStr);
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            }
        }

        private void txLoRaPackageDataTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (loraSendngPackageDataViewTypeCb.SelectedIndex == 0 || loraSendngPackageDataViewTypeCb.SelectedIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
                {
                    e.Handled = true;
                }
            }
        }

        private void clearReceivedMsgsBtn_Click(object sender, EventArgs e)
        {
            rxPkgListView.Items.Clear();
            loraMessagesList.Clear();
        }


        private void rxPkgListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReceivedLoRaMessage loraMsgTemp;
            if(rxPkgListView.SelectedItems.Count>0)
            {
                loraMsgTemp = loraMessagesList[rxPkgListView.SelectedIndices[0]];
                rxPkgSourceTb.Text = getSourceUnitFromRcvdMessage(loraMsgTemp).ToString();
                rxPkgDestinationTb.Text = getDestinationUnitFromRcvdMessage(loraMsgTemp).ToString();
                rxLoRaMsgTb.Text = Encoding.ASCII.GetString(loraMsgTemp.data);
                //rxPkgSourceTb.Text = loraMsgTemp.sourceUnit.ToString();
            }
        }


        public class ReceivedLoRaMessage
        {
            public byte messageType { get; set; }
            public byte serviceType { get; set; }
            public byte routingHeaderType { get; set; }
            public UnicastDirectHeader unicastDirectHeader { get; set; }
            public UnicastRoutedHeader unicastRoutedHeader { get; set; }
            public MulticastDirectHeader multicastDirectHeader { get; set; }
            public MulticastRoutedHeader multicastRoutedHeader { get; set; }
            public BroadcastHeader broadcastHeader { get; set; }
            public DateTime time { get; set; }
            public UInt16 messageID { get; set; }
            public byte dataLength { get; set; }
            public byte[] data { get; set; }
            public Int16 rssi { get; set; }

            public ReceivedLoRaMessage()
            {
                data = new byte[256];
                unicastDirectHeader = new UnicastDirectHeader();
                unicastRoutedHeader = new UnicastRoutedHeader();
                multicastDirectHeader = new MulticastDirectHeader();
                multicastRoutedHeader = new MulticastRoutedHeader();
                broadcastHeader = new BroadcastHeader();
            }
        }

        public class UnicastDirectHeader
        {
            public byte sourceUnit { get; set; }
            public byte destinationUnit { get; set; }
        }
        public class UnicastRoutedHeader
        {
            public byte sourceUnit { get; set; }
            public byte destinationUnit { get; set; }
            public byte fromUnit { get; set; }
            public byte toUnit { get; set; }
            public byte hopIndex { get; set; }
        }
        public class MulticastDirectHeader
        {
            public byte sourceUnit { get; set; }
            public byte destinationCount { get; set; }
        }
        public class MulticastRoutedHeader
        {
            public byte sourceUnit { get; set; }
            public byte destinationCount { get; set; }
        }
        public class BroadcastHeader
        {
            public byte sourceUnit { get; set; }
        }

        private byte getSourceUnitFromRcvdMessage(ReceivedLoRaMessage loraMsgParam)
        {
            byte retValueTemp = 0;
            switch (loraMsgParam.routingHeaderType)
            {
                case UNICAST_DIRECT_HEADER:
                    retValueTemp = loraMsgParam.unicastDirectHeader.sourceUnit;
                    break;
                case UNICAST_ROUTED_HEADER:
                    retValueTemp = loraMsgParam.unicastRoutedHeader.sourceUnit;
                    break;
                case MULTICAST_DIRECT_HEADER:
                    break;
                case MULTICAST_ROUTED_HEADER:
                    break;
                case BROADCAST_HEADER:
                    retValueTemp = loraMsgParam.broadcastHeader.sourceUnit;
                    break;
                default:
                    retValueTemp = 0;
                    break;
            }
            return retValueTemp;
        }

        private byte getDestinationUnitFromRcvdMessage(ReceivedLoRaMessage loraMsgParam)
        {
            byte retValueTemp = 0;
            switch (loraMsgParam.routingHeaderType)
            {
                case UNICAST_DIRECT_HEADER:
                    retValueTemp = loraMsgParam.unicastDirectHeader.destinationUnit;
                    break;
                case UNICAST_ROUTED_HEADER:
                    retValueTemp = loraMsgParam.unicastRoutedHeader.destinationUnit;
                    break;
                case MULTICAST_DIRECT_HEADER:
                    break;
                case MULTICAST_ROUTED_HEADER:
                    break;
                case BROADCAST_HEADER:
                    retValueTemp = 255;
                    break;
                default:
                    retValueTemp = 0;
                    break;
            }
            return retValueTemp;
        }
    }
}
