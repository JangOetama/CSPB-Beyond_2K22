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
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "type"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "name"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "model"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "texture_main"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "texture_sub_1"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "texture_sub_2"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "shader"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "command"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "csw"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "anim_ext"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "p_model"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "w_model"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "p_sub"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "w_sub"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "ammo"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "damage"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "gravity"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "deploy"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "buy"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "cost"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "is_cash"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "is_default"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "throw_delay"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "throw_event"));
            listBox1.Items.Add(CJDW.GetAmxxConfig("weapon.txt", "medkit", "heal"));


        }
    }
}
