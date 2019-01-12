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
    public sealed partial class YazilimYuklemePage : UserControl,ISerialToPageInterface
    {
        private static volatile YazilimYuklemePage instance;
        private static object syncRoot = new Object();

        public YazilimYuklemePage()
        {
            InitializeComponent();
            SerialPortManager.Instance.SetPageInterface(Application_TypesConstants.YazilimYuklemePageID, this);
        }
        public static YazilimYuklemePage Instance
        {
            get
            {
                if(instance==null)
                {
                    lock(syncRoot)
                    {
                        instance = new YazilimYuklemePage();
                    }
                }
                return instance;
            }
        }

        public void GetReceivedPackage(UInt16 msgID, byte[] rxBuffer, UInt16 messageLength)
        {
            //throw new NotImplementedException();
        }
    }
}
