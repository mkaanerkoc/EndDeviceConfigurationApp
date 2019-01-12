using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Interfaces
{
    public interface ILoRaToPageInterface
    {
        void SendLoRaMessageToPage(RadioMessageType messageType, byte[] data, int rssi);
    }
}
