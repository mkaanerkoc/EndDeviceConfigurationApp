using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1.Managers
{
    public sealed class SerialPortManager
    {
        private SerialPort serialPort;
        private const int MAX_RX_BUFFER_LENGTH = 512;
        private const byte COMMAND_STARTER_BYTE_1 = 0x03;
        private const byte COMMAND_STARTER_BYTE_2 = 0x04;
        private const byte COMMAND_FINISH_BYTE_1 = 0x33;
        private const byte COMMAND_FINISH_BYTE_2 = 0x34;

        private const byte MINIMUM_COMMAND_SIZE = 0x08;

        private byte[] SerialRXBuffer;
        private byte rxState = 0x00;
        private UInt16 rxBufferIndex;
        private static volatile SerialPortManager instance;
        private static object syncRoot = new Object();
        private MessageDatagram RxMsgDatagram;
        private MessageDatagram TxMsgDatagram;

        private ISerialToPageInterface cihazBaglantisiPageInterface, cihazKonfigurasyonPageInterface, cihazTestiPageInterface,depolamaPageInterface, loraTestiPageInterface,yazilimYuklemePageInterface;

        public class MessageDatagram
        {
            public UInt16 MessageID { get; set; }
            public UInt16 Length { get; set; }
            public UInt16 MessageCRC { get; set; }
            public byte[] Data { get; set; }

            public MessageDatagram()
            {
                Data = new byte[512];
            }
        }

        public SerialPortManager()
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += SerialPort_DataReceived;
            SerialRXBuffer = new byte[MAX_RX_BUFFER_LENGTH];
            rxState = 0;
        }

        public static SerialPortManager Instance
        {
            get
            {
                if(instance==null)
                {
                    lock(syncRoot)
                    {
                        instance = new SerialPortManager();
                    }
                }
                return instance;
            }
        }

        public bool Connect(string portName)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = portName;
                serialPort.BaudRate = 57600;
                serialPort.Parity = Parity.None;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Handshake = Handshake.None;
                serialPort.RtsEnable = true;
                try
                {
                    serialPort.Open();
                    byte[] buf1 = { 0x03, 0x04, 0x00, 0x00, 0x00, 0x00, 0x25, 0x26 };
                    //SendDataToDevice(buf1, 8);
                    return true;
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Cannot connect serial Port  "+ee.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Disconnect()
        {
            if(serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                    return true;
                }
                catch(Exception ee)
                {
                    MessageBox.Show("Cannot discconnect serial Port  " + ee.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool IsPortOpen()
        {
            return serialPort.IsOpen;
        }

        /*Core Functions */
        public void SendDataToDevice(byte[] data, ushort length)
        {
            Console.WriteLine("Command Send");

            if (serialPort.IsOpen)
            {
                serialPort.Write(data, 0, length);
            }
            else
            {
                MessageBox.Show("COM Port Açık değil !", "Hata");
            }
        }

        /*Packer Functions */
        /*Parser Functions */
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int receivedByteCount = serialPort.BytesToRead;
            byte[] rxBytes = new byte[receivedByteCount];
            serialPort.Read(rxBytes, 0, receivedByteCount);
            if (receivedByteCount < 1)
            {
                Console.WriteLine("Paket Alinamadi...");
                return;
            }
            //Console.WriteLine("RX STATE : {0}", rxState);
            if (rxState == 0x00) // henuz paket alinmaya baslanmamis
            {
                if (rxBytes[0] == COMMAND_STARTER_BYTE_1)
                {
                    //paket alinmaya baslaniyor...
                    rxBufferIndex = 0;
                    for(int i = 0; i < receivedByteCount;i++)
                    {
                        SerialRXBuffer[rxBufferIndex++] = rxBytes[i];
                        if ((rxBytes[i] == COMMAND_FINISH_BYTE_1) && rxBufferIndex >= MINIMUM_COMMAND_SIZE)
                        {
                            //PAKET Alimi tamamlanmis olmali, ama yine de uzunluga gore kontrol yapicaz..
                            //paketin mesaj uzunlugunu alalim..
                            ushort msgLength = (ushort)((SerialRXBuffer[3] << 8) | SerialRXBuffer[4]);
                            if (rxBufferIndex == (msgLength + MINIMUM_COMMAND_SIZE))
                            {
                                //paket alimi tamamlandi 
                                ushort msgId = (ushort)((SerialRXBuffer[1] << 8) | SerialRXBuffer[2]);
                                //Console.WriteLine("1 - Paket Alimi Tamamlandi.. MSG ID : {0}", msgId);
                                rxState = 0x00;
                                ParseIncomingPackage(msgId, SerialRXBuffer, rxBufferIndex);
                                return;
                            }
                        }
                    }
                    rxState = 0x01;
                }
                else
                {
                    Console.WriteLine("RX_STATE = 0x00 ' ken rxBytes[0] COMMAND_STARTER_BYTE_1 disinda gelemez..");
                    return;
                }
            }
            else if (rxState == 0x01)
            {
                for (int i = 0; i < receivedByteCount; i++)
                {
                    SerialRXBuffer[rxBufferIndex++] = rxBytes[i];
                    if((rxBytes[i] == COMMAND_FINISH_BYTE_1 ) && rxBufferIndex >= MINIMUM_COMMAND_SIZE)
                    {
                        //PAKET Alimi tamamlanmis olmali, ama yine de uzunluga gore kontrol yapicaz..
                        //paketin mesaj uzunlugunu alalim..
                        ushort msgLength = (ushort)((SerialRXBuffer[3]<<8) | SerialRXBuffer[4]);
                        if(rxBufferIndex == (msgLength+MINIMUM_COMMAND_SIZE))
                        {
                            //paket alimi tamamlandi 
                            ushort msgId = (ushort)((SerialRXBuffer[1] << 8) | SerialRXBuffer[2]);
                            //Console.WriteLine("2 - Paket Alimi Tamamlandi.. MSG ID : {0}",msgId);
                            rxState = 0x00;
                            ParseIncomingPackage(msgId, SerialRXBuffer, rxBufferIndex);
                        }
                    }
                }
            }
        }
        private void ResetRxCounters()
        {
            rxState = 0;
            rxBufferIndex = 0;
        }
        public void SendRemoteDeviceCmd(UInt16 msgID,UInt16 length,byte[] package)
        {
            byte[] outputBuffer = new byte[length + 8];
            outputBuffer[0] = COMMAND_STARTER_BYTE_1;
            outputBuffer[1] = COMMAND_STARTER_BYTE_2;
            outputBuffer[2] = (byte)(msgID >> 8);
            outputBuffer[3] = (byte)(msgID & 0xFF);
            outputBuffer[4] = (byte)(length >> 8);
            outputBuffer[5] = (byte)(length & 0xFF);
            package.CopyTo(outputBuffer, 6);
            //kaanbak ADD CRC HERE//
            outputBuffer[length + 6] = 0x32;
            outputBuffer[length + 7] = 0x33;
            SendDataToDevice(outputBuffer, (ushort)(length + 8));
        }

        private void ParseIncomingPackage(UInt16 msgID,byte[] package, UInt16 messageLength)
        {
            Console.WriteLine("PackageReceived ID :{0}", msgID);
            switch(msgID)
            {
                case SerialPort_Constants.OUTGOING_CMD_ACK:
                    Console.WriteLine("CMD_ACK Received ! Result : {0}, Cmd : {1}",package[5],package[6]);
                    break;
                case SerialPort_Constants.OUTGOING_CMD_DATE_RESPONSE:
                    cihazBaglantisiPageInterface.GetReceivedPackage(msgID, package,messageLength);
                    //Console.WriteLine("OUTGOING_CMD_DATE_RESPONSE received");
                    break;
                case SerialPort_Constants.OUTGOING_CMD_TIME_RESPONSE:
                    //Console.WriteLine("OUTGOING_CMD_TIME_RESPONSE received");
                    cihazBaglantisiPageInterface.GetReceivedPackage(msgID, package, messageLength);
                    break;
                case SerialPort_Constants.OUTGOING_CMD_READ_BME280_RESPONSE:
                    Console.WriteLine("OUTGOING_CMD_READ_BME280_RESPONSE received");
                    cihazTestiPageInterface.GetReceivedPackage(msgID, package,messageLength); // kaanbak degistirileccek
                    break;
                case SerialPort_Constants.OUTGOING_CMD_READ_MAX31865_RESPONSE:
                case SerialPort_Constants.OUTGOING_CMD_GPS_LOCATION_RESPONSE:
                    cihazTestiPageInterface.GetReceivedPackage(msgID, package, messageLength); // kaanbak degistirileccek
                    break;
                case SerialPort_Constants.OUTGOING_CMD_DEVICE_UNIQUE_ID_RESPONSE:
                case SerialPort_Constants.OUTGOING_CMD_DEVICE_LORA_ID_RESPONSE:
                case SerialPort_Constants.OUTGOING_CMD_DEVICE_LORA_GATEWAY_ID_RESPONSE:       
                case SerialPort_Constants.OUTGOING_CMD_LORA_CODING_RATE_RESPONSE:
                case SerialPort_Constants.OUTGOING_CMD_LORA_CONFIG_RESPONSE:
                case SerialPort_Constants.OUTGOING_CMD_LORA_STATIC_ROUTING_TABLE_RESPONSE:
                    cihazKonfigurasyonPageInterface.GetReceivedPackage(msgID, package, messageLength);
                    break;
                case SerialPort_Constants.OUTGOING_CMD_NEIGHBOUR_LIST_RESPONSE:
                case SerialPort_Constants.OUTGOING_CMD_LORA_ECHO_MONITOR_REPONSE:
                case SerialPort_Constants.OUTGOING_CMD_LORA_RECEIVED_PACKAGE:
                    loraTestiPageInterface.GetReceivedPackage(msgID, package, messageLength);
                    break;
                default:
                    break;
            }
        }

        public void SetPageInterface(ushort PageID,ISerialToPageInterface pageInterface)
        {
            switch(PageID)
            {
                case Application_TypesConstants.CihazBaglantisiPageID:
                    cihazBaglantisiPageInterface = pageInterface;
                    break;
                case Application_TypesConstants.CihazKonfigurasyonPageID:
                    cihazKonfigurasyonPageInterface = pageInterface;
                    break;
                case Application_TypesConstants.CihazTestiPageID:
                    cihazTestiPageInterface = pageInterface;
                    break;
                case Application_TypesConstants.DepolamaPageID:
                    depolamaPageInterface = pageInterface;
                    break;
                case Application_TypesConstants.LoraTestPageID:
                    loraTestiPageInterface = pageInterface;
                    break;
                case Application_TypesConstants.YazilimYuklemePageID:
                    yazilimYuklemePageInterface = pageInterface;
                    break;
                default:
                    break;
            }
        }
    }
}
