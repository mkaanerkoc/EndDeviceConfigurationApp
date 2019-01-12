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
    public sealed partial class DepolamaPage : UserControl,ISerialToPageInterface
    {
        private static volatile DepolamaPage instance;
        private static object syncRoot = new Object();

        public DepolamaPage()
        {
            InitializeComponent();
            SerialPortManager.Instance.SetPageInterface(Application_TypesConstants.DepolamaPageID, this);
        }
        public static DepolamaPage Instance
        {
            get
            {
                if(instance==null)
                {
                    lock(syncRoot)
                    {
                        instance = new DepolamaPage();
                    }
                }
                return instance;
            }
        }
        public void GetReceivedPackage(UInt16 msgID, byte[] rxBuffer, UInt16 messageLength)
        {
            /*switch (msgID)
            {
                case:
                    break;
                case:
                    break;
                case:
                    break;
                default:
                    break;
            }*/
        }

    }
}
