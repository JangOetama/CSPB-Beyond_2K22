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
    public partial class formWait : Form
    {
        int IP=0;
        public formWait()
        {
            InitializeComponent();
        }

        private void wait_Load(object sender, EventArgs e)
        {
            this.Size = new Size(266, 42);
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (IP == 25)
            {
                Timer1.Stop();
                this.Close();
            }
            else
            {
                IP += 1;
            }

        }
    }
}
