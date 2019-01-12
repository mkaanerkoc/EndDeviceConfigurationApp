using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Interfaces;
using static WindowsFormsApplication1.Managers.LoRa_Constants;

namespace WindowsFormsApplication1.Managers
{
    public sealed class LoRaManager
    {

        //Singletone objects
        private static volatile LoRaManager instance;
        private static object syncRoot = new Object();

        private ILoRaToPageInterface veriKanaliOkumaPageInterface;

        public static LoRaManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new LoRaManager();
                    }
                }
                return instance;
            }
        }


        public void SendLoRaPackageToRemoteDevice(byte[] data, UInt16 length)
        {
            //kaanimportant

        }
        public void SendLoRaPackageToResponsiblePage(byte[] data, UInt16 length)
        {
            RadioMessageType messageIdTemp = (RadioMessageType)((data[5] & 0xF8) >> 3);
            RadioRoutingHeaderType routingHeaderTypeTemp = (RadioRoutingHeaderType)(data[5] & 0x03);
            byte routingHeaderLength = 0;
            Int16 signalRssiValue = 0;
            signalRssiValue = (Int16)((data[length - 5] << 8) | (data[length - 4]));
            if (routingHeaderTypeTemp == RadioRoutingHeaderType.UNICAST_DIRECT_HEADER)
            {
                routingHeaderLength = 3;  /* 1 byte main + 2 byte routing header */
            }
            else if (routingHeaderTypeTemp == RadioRoutingHeaderType.UNICAST_ROUTED_HEADER)
            {
                routingHeaderLength = 6; /* 1 byte main + 5 byte routing header */
            }
            else
            {
                // not implemented yet...
                return;
            }
            byte[] loraMessageData = new byte[length - 5 - routingHeaderLength];
            Array.Copy(data, (5 + routingHeaderLength), loraMessageData, 0, length - 5 - routingHeaderLength);
            switch (messageIdTemp)
            {
                case RadioMessageType.DATA_CHANNEL_REQUEST:
                    break;
                case RadioMessageType.DATA_CHANNEL_RESPONSE:
                    //veriKanaliOkumaPageInterface.SendLoRaMessageToPage(messageIdTemp, loraMessageData, signalRssiValue);
                    break;
                case RadioMessageType.DEVICE_INFORMATION_REQUEST:
                    break;
                case RadioMessageType.DEVICE_INFORMATION_RESPONSE:
                    break;
                case RadioMessageType.DISCOVER_NEIGHBOUR_REQUEST:
                    break;
                case RadioMessageType.DISCOVER_NEIGHBOUR_RESPONSE:
                    break;
                case RadioMessageType.ECHO_MESSAGE_REQUEST:
                    break;
                case RadioMessageType.ECHO_MESSAGE_RESPONSE:
                    break;
                case RadioMessageType.OPERATIONAL_REQUEST:
                    break;
                case RadioMessageType.OPERATIONAL_RESPONSE:
                    break;
                case RadioMessageType.PING_MESSAGE:
                    break;
                case RadioMessageType.PONG_MESSAGE:
                    break;
                case RadioMessageType.UNCATEGORIZED_REL_MSG_REQUEST:
                    break;
                case RadioMessageType.UNCATEGORIZED_REL_MSG_RESPONSE:
                    break;
            }
        }
        public void SetLoRaPageInterface(ushort pageID, ILoRaToPageInterface interfaceParam)
        {
            switch (pageID)
            {
                case Application_TypesConstants.VeriOkumaPageID:
                    this.veriKanaliOkumaPageInterface = interfaceParam;
                    break;
                default:
                    break;
            }
        }
    }
}
