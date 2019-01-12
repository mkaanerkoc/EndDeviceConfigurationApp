using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Interfaces
{
    public interface ISerialToPageInterface
    {
        void GetReceivedPackage(UInt16 msgID, byte[] rxBuffer, UInt16 messageLength);
    }
}
