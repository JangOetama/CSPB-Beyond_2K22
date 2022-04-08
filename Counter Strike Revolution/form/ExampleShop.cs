using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            var lines = File.ReadAllLines(@"cstrike\addons\amxmodx\configs\nautilus\weapons.ini");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("command"))
                {
                    listBox1.Items.Add(CJDW.GetAmxxConfigNoCommand(@"cstrike\addons\amxmodx\configs\nautilus\weapons.ini", "name", i));
                    listBox1.Items.Add(CJDW.GetAmxxConfigNoCommand(@"cstrike\addons\amxmodx\configs\nautilus\weapons.ini", "cost", i));
                    listBox1.Items.Add("");
                }
            }

            listBox1.Items.Add(CJDW.GetAmxxConfig(@"cstrike\addons\amxmodx\configs\nautilus\weapons.ini", "command", "medkit", "type"));
            listBox1.Items.Add(CJDW.GetAmxxConfig(@"cstrike\addons\amxmodx\configs\nautilus\weapons.ini", "command", "medkit", "name"));
            listBox1.Items.Add(CJDW.GetAmxxConfig(@"cstrike\addons\amxmodx\configs\nautilus\weapons.ini", "command", "medkit", "model"));
            listBox1.Items.Add(CJDW.GetAmxxConfig(@"cstrike\addons\amxmodx\configs\nautilus\weapons.ini", "command", "medkit", "texture_main"));
            listBox1.Items.Add(CJDW.GetAmxxConfig(@"cstrike\addons\amxmodx\configs\nautilus\weapons.ini", "command", "medkit", "texture_sub_1"));
            listBox1.Items.Add(CJDW.GetAmxxConfig(@"cstrike\addons\amxmodx\configs\nautilus\weapons.ini", "command", "medkit", "texture_sub_2"));
            listBox1.Items.Add(CJDW.GetAmxxConfig(@"cstrike\addons\amxmodx\configs\nautilus\weapons.ini", "command", "medkit", "shader"));
            listBox1.Items.Add(CJDW.GetAmxxConfig(@"cstrike\addons\amxmodx\configs\nautilus\weapons.ini", "command", "medkit", "command"));



        }
    }
}
