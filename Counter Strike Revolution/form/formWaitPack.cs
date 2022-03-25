using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter_Strike_Point_Blank
{
    
    public partial class formWaitPack : Form
    {
        private System.Windows.Forms.Timer tmr;
        public formWaitPack()
        {
            InitializeComponent();


            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                formMainLoading form2 = new formMainLoading();
                Hide();
                tmr.Stop();
                form2.ShowDialog();
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(5).TotalMilliseconds;
            tmr.Start();
        }

    }
}
