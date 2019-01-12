using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.TabPages;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabPage1.Controls.Add(CihazBaglantisiPage.Instance);
            tabPage2.Controls.Add(CihazTestiPage.Instance);
            tabPage6.Controls.Add(LoraTestiPage.Instance);
            tabPage3.Controls.Add(YazilimYuklemePage.Instance);
            tabPage4.Controls.Add(CihazKonfigurasyonPage.Instance);
            tabPage5.Controls.Add(DepolamaPage.Instance);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
