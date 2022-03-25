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
    public partial class formBackground : Form
    {
        int cFP = 0;
        public formBackground()
        {
            InitializeComponent();
            CJDW.Rescale(this, true);

        }

        private void MainLoading_Load(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
     
        }
    }
}
