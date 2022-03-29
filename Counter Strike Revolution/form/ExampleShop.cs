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
    public partial class ExampleShop : Form
    {
        public ExampleShop()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(CJDW.ReadAMXXConfig("weapon.txt", "870mcs", ""));
        }
    }
}
