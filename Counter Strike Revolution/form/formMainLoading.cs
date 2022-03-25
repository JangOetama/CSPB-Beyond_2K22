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

    
         
    public partial class formMainLoading : Form
    {
        private System.Windows.Forms.Timer tmr;
        int cFP = 0;
        public formMainLoading()
        {
            InitializeComponent();
            CJDW.Rescale(this, true);
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                if (cFP <= 101)
                {
                    picLoading.Width = (cFP * 1314 / 100) * Screen.PrimaryScreen.Bounds.Width / 1366;
                    cFP++;

                }
                else
                {
                    formBackground form2 = new formBackground();
                    Hide();
                    tmr.Stop();
                    form2.ShowDialog();
                    this.Close();
                }

                
            };
            tmr.Interval = (int)TimeSpan.FromMilliseconds(1).TotalMilliseconds;


            tmr.Start();

        }

        private void MainLoading_Load(object sender, EventArgs e)
        {
            picLoading.Height = (8) * Screen.PrimaryScreen.Bounds.Height / 768;
  
            
        }

    }
}
