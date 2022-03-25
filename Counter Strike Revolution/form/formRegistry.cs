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
    public partial class formRegistry : Form
    {
        char dot = ("●").ToCharArray()[0];
        string konfirmasiid, konfirmasiemail;
        public formRegistry()
        {
            InitializeComponent();
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            if (textboxPassword.Text == "Password harus terdiri dari 8-16 karakter." || textboxPassword.Text == "")
                textboxPassword.Text = "";
            textboxPassword.PasswordChar = dot;
            buttonShowPassword.toggleState = false;

            if (textboxRePassword.Text == "" || textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
                textboxRePassword.PasswordChar = '\0';
            }
            else if (textboxRePassword.Text != "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.PasswordChar = dot;
            }

            if (textboxEmail.Text == "" || textboxEmail.Text == "Masukkan email dengan benar.")
                textboxEmail.Text = "Masukkan email dengan benar.";
            if (textboxID.Text == "" || textboxID.Text == "ID harus terdiri dari 5-16 karakter.")
                textboxID.Text = "ID harus terdiri dari 5-16 karakter.";
        }

        private void TextBox3_Click(object sender, EventArgs e)
        {
            if (textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter." || textboxRePassword.Text == "")
                textboxRePassword.Text = "";
            textboxRePassword.PasswordChar = dot;
            buttonShowRePassword.toggleState = false;
            if (textboxEmail.Text == "" || textboxEmail.Text == "Masukkan email dengan benar.")
                textboxEmail.Text = "Masukkan email dengan benar.";
            if (textboxPassword.Text == "" || textboxPassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxPassword.PasswordChar = '\0';
                textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
            }
            else if (textboxPassword.Text != "Password harus terdiri dari 8-16 karakter.")

            {
                textboxPassword.PasswordChar = dot;
                buttonShowPassword.toggleState = false;
            }
            if (textboxID.Text == "" || textboxID.Text == "ID harus terdiri dari 5-16 karakter.")
                textboxID.Text = "ID harus terdiri dari 5-16 karakter.";
        }
        private void TextBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (textboxEmail.Text == "Masukkan email dengan benar." || textboxEmail.Text == "")
                textboxEmail.Text = "";
            if (textboxRePassword.Text == "" || textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
                textboxRePassword.PasswordChar = '\0';
            }
            else if (textboxRePassword.Text != "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.PasswordChar = dot;
                buttonShowRePassword.toggleState = false;
            }

            if (textboxPassword.Text == "" || textboxPassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxPassword.PasswordChar = '\0';
                textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
            }
            else if (textboxPassword.Text != "Password harus terdiri dari 8-16 karakter.")

            {
                textboxPassword.PasswordChar = dot;
                buttonShowPassword.toggleState = false;
            }
            if (textboxID.Text == "" || textboxID.Text == "ID harus terdiri dari 5-16 karakter.")
                textboxID.Text = "ID harus terdiri dari 5-16 karakter.";

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (textboxID.Text == "ID harus terdiri dari 5-16 karakter." || textboxID.Text == "")
                textboxID.Text = "";
            if (textboxPassword.Text == "" || textboxPassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxPassword.PasswordChar = '\0';
                textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
            }
            else if (textboxPassword.Text != "Password harus terdiri dari 8-16 karakter.")

            {
                textboxPassword.PasswordChar = dot;
                buttonShowPassword.toggleState = false;
            }
            if (textboxRePassword.Text == "" || textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
                textboxRePassword.PasswordChar = '\0';
            }
            else if (textboxRePassword.Text != "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.PasswordChar = dot;
                buttonShowRePassword.toggleState = false;
            }

            if (textboxEmail.Text == "" || textboxEmail.Text == "Masukkan email dengan benar.")
                textboxEmail.Text = "Masukkan email dengan benar.";
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textboxID.Text == "ID harus terdiri dari 5-16 karakter." || textboxID.Text == "")
                textboxID.Text = "";
            if (textboxPassword.Text == "" || textboxPassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxPassword.PasswordChar = '\0';
                textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
            }
            else if (textboxPassword.Text != "Password harus terdiri dari 8-16 karakter.")

            {
                textboxPassword.PasswordChar = dot;
                buttonShowPassword.toggleState = false;
            }
            if (textboxRePassword.Text == "" || textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
                textboxRePassword.PasswordChar = '\0';
            }
            else if (textboxRePassword.Text != "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.PasswordChar = dot;
                buttonShowRePassword.toggleState = false;
            }

            if (textboxEmail.Text == "" || textboxEmail.Text == "Masukkan email dengan benar.")
                textboxEmail.Text = "Masukkan email dengan benar.";
        }

        private void TextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textboxPassword.Text == "Password harus terdiri dari 8-16 karakter." || textboxPassword.Text == "")
                textboxPassword.Text = "";
            textboxPassword.PasswordChar = dot;
            buttonShowPassword.toggleState = false;
            if (textboxRePassword.Text == "" || textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
                textboxRePassword.PasswordChar = '\0';
            }
            else if (textboxRePassword.Text != "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.PasswordChar = dot;
                buttonShowRePassword.toggleState = false;
            }

            if (textboxEmail.Text == "" || textboxEmail.Text == "Masukkan email dengan benar.")
                textboxEmail.Text = "Masukkan email dengan benar.";
            if (textboxID.Text == "" || textboxID.Text == "ID harus terdiri dari 5-16 karakter.")
                textboxID.Text = "ID harus terdiri dari 5-16 karakter.";
        }

        private void TextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter." || textboxRePassword.Text == "")
                textboxRePassword.Text = "";
            textboxRePassword.PasswordChar = dot;
            buttonShowRePassword.toggleState = false;
            if (textboxEmail.Text == "" || textboxEmail.Text == "Masukkan email dengan benar.")
                textboxEmail.Text = "Masukkan email dengan benar.";
            if (textboxPassword.Text == "" || textboxPassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxPassword.PasswordChar = '\0';
                textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
            }
            else if (textboxPassword.Text != "Password harus terdiri dari 8-16 karakter.")

            {
                textboxPassword.PasswordChar = dot;
                buttonShowPassword.toggleState = false;
            }
            if (textboxID.Text == "" || textboxID.Text == "ID harus terdiri dari 5-16 karakter.")
                textboxID.Text = "ID harus terdiri dari 5-16 karakter.";
        }

        private void TextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (textboxEmail.Text == "Masukkan email dengan benar." || textboxEmail.Text == "")
                textboxEmail.Text = "";
            if (textboxRePassword.Text == "" || textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
                textboxRePassword.PasswordChar = '\0';
            }
            else if (textboxRePassword.Text != "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.PasswordChar = dot;
                buttonShowRePassword.toggleState = false;
            }

            if (textboxPassword.Text == "" || textboxPassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxPassword.PasswordChar = '\0';
                textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
            }
            else if (textboxPassword.Text != "Password harus terdiri dari 8-16 karakter.")

            {
                textboxPassword.PasswordChar = dot;
                buttonShowPassword.toggleState = false;
            }
            if (textboxID.Text == "" || textboxID.Text == "ID harus terdiri dari 5-16 karakter.")
                textboxID.Text = "ID harus terdiri dari 5-16 karakter.";
        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            textboxID.Focus();
            if (textboxID.Text == "ID harus terdiri dari 5-16 karakter." || textboxID.Text == "")
                textboxID.Text = "";
            if (textboxPassword.Text == "" || textboxPassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxPassword.PasswordChar = '\0';
                textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
            }
            else if (textboxPassword.Text != "Password harus terdiri dari 8-16 karakter.")

            {
                textboxPassword.PasswordChar = dot;
                buttonShowPassword.toggleState = false;
            }
            if (textboxRePassword.Text == "" || textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
                textboxRePassword.PasswordChar = '\0';
            }
            else if (textboxRePassword.Text != "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.PasswordChar = dot;
                buttonShowRePassword.toggleState = false;
            }

            if (textboxEmail.Text == "" || textboxEmail.Text == "Masukkan email dengan benar.")
                textboxEmail.Text = "Masukkan email dengan benar.";
        }

        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            textboxPassword.Focus();
            if (textboxPassword.Text == "Password harus terdiri dari 8-16 karakter." || textboxPassword.Text == "")
                textboxPassword.Text = "";
            textboxPassword.PasswordChar = dot;
            buttonShowPassword.toggleState = false;


            if (textboxRePassword.Text == "" || textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
                textboxRePassword.PasswordChar = '\0';
            }
            else if (textboxRePassword.Text != "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.PasswordChar = dot;
                buttonShowRePassword.toggleState = false;
            }

            if (textboxEmail.Text == "" || textboxEmail.Text == "Masukkan email dengan benar.")
                textboxEmail.Text = "Masukkan email dengan benar.";
            if (textboxID.Text == "" || textboxID.Text == "ID harus terdiri dari 5-16 karakter.")
                textboxID.Text = "ID harus terdiri dari 5-16 karakter.";
        }

        private void Panel3_MouseClick(object sender, MouseEventArgs e)
        {
            textboxRePassword.Focus();
            if (textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter." || textboxRePassword.Text == "")
                textboxRePassword.Text = "";
            textboxRePassword.PasswordChar = dot;
            buttonShowRePassword.toggleState = false;
            if (textboxEmail.Text == "" || textboxEmail.Text == "Masukkan email dengan benar.")
                textboxEmail.Text = "Masukkan email dengan benar.";
            if (textboxPassword.Text == "" || textboxPassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxPassword.PasswordChar = '\0';
                textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
            }
            else if (textboxPassword.Text != "Password harus terdiri dari 8-16 karakter.")

            {
                textboxPassword.PasswordChar = dot;
                buttonShowPassword.toggleState = false;
            }
            if (textboxID.Text == "" || textboxID.Text == "ID harus terdiri dari 5-16 karakter.")
                textboxID.Text = "ID harus terdiri dari 5-16 karakter.";
        }

        private void Panel4_MouseClick(object sender, MouseEventArgs e)
        {
            textboxEmail.Focus();
            if (textboxEmail.Text == "Masukkan email dengan benar." || textboxEmail.Text == "")
                textboxEmail.Text = "";

            if (textboxRePassword.Text == "" || textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
                textboxRePassword.PasswordChar = '\0';
            }
            else if (textboxRePassword.Text != "Password harus terdiri dari 8-16 karakter.")
            {
                textboxRePassword.PasswordChar = dot;
                buttonShowRePassword.toggleState = false;
            }

            if (textboxPassword.Text == "" || textboxPassword.Text == "Password harus terdiri dari 8-16 karakter.")
            {
                textboxPassword.PasswordChar = '\0';
                textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
            }
            else if (textboxPassword.Text != "Password harus terdiri dari 8-16 karakter.")

            {
                textboxPassword.PasswordChar = dot;
                buttonShowPassword.toggleState = false;
            }

            if (textboxID.Text == "" || textboxID.Text == "ID harus terdiri dari 5-16 karakter.")
                textboxID.Text = "ID harus terdiri dari 5-16 karakter.";
        }

        private void ButtonRegistry_MouseClick(object sender, MouseEventArgs e)
        {

            if (buttonCheckBoxAccept.toggleState == true)
            {
                //Kata sandi harus menggunakan setidaknya satu huruf dari (a-Z) dan angka (0-9).
                if (konfirmasiid != textboxID.Text)
                {
                    MessageBox.Show("Silahkan konfirmasi ID.");
                }
                else if (konfirmasiemail != textboxEmail.Text)
                {
                    MessageBox.Show("Memerlukan verifikasi e-mail.");
                }
                else if (textboxID.Text.Length < 5 || textboxID.Text.Length > 16)
                {
                    MessageBox.Show("ID kurang dari 5 / lebih dari 16");
                }
                else if (textboxPassword.Text.Length < 8 || textboxPassword.Text.Length > 16)
                {
                    MessageBox.Show("Password kurang dari 8 / lebih dari 16");
                }
                else if (textboxPassword.Text != textboxRePassword.Text)
                {
                    MessageBox.Show("Kata sandi yang anda masukan tidak sama.");
                }
                else
                {
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "userPass" + "\"", "\"" + textboxRePassword.Text + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "userEmail" + "\"", "\"" + textboxEmail.Text + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerExp" + "\"", "\"" + "0" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerRank" + "\"", "\"" + "0" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerPoint" + "\"", "\"" + "0" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerCash" + "\"", "\"" + "0" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerKills" + "\"", "\"" + "0" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerDeaths" + "\"", "\"" + "0" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerHeadshots" + "\"", "\"" + "0" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerWin" + "\"", "\"" + "0" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerLose" + "\"", "\"" + "0" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerRetreat" + "\"", "\"" + "0" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerCharTE" + "\"", "\"" + "terror" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerCharCT" + "\"", "\"" + "urban" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerCharDino" + "\"", "\"" + "" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerWpn01" + "\"", "\"" + "k1" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerWpn02" + "\"", "\"" + "k5" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerWpn03" + "\"", "\"" + "m7" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerWpn04" + "\"", "\"" + "k400" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerWpn05" + "\"", "\"" + "smoke" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerBonusRedeemed" + "\"", "\"" + "1" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerIsDeveloper" + "\"", "\"" + "0" + "\"");
                    CJDW.SetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt", "\"" + "playerIsAdmin" + "\"", "\"" + "0" + "\"");
                    textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
                    textboxRePassword.PasswordChar = '\0';
                    textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
                    textboxPassword.PasswordChar = '\0';
                    textboxID.Text = "ID harus terdiri dari 5-16 karakter.";
                    textboxEmail.Text = "Masukkan email dengan benar.";
                    System.Threading.Thread.Sleep(3000);
                    btnBackToHome.Visible = true;
                    picCreateAccount.Visible = true;
                }




            }
        }


        private void ButtonShowPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (buttonShowPassword.toggleState == true)
            {
                if (textboxPassword.Text == "Password harus terdiri dari 8-16 karakter.")
                    textboxPassword.PasswordChar = '\0';
                else
                    textboxPassword.PasswordChar = dot;
            }
            else if (buttonShowPassword.toggleState == false)
            {
                textboxPassword.PasswordChar = '\0';
            }
        }

        private void ButtonShowRePassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (buttonShowRePassword.toggleState == true)
            {
                if (textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter.")
                    textboxRePassword.PasswordChar = '\0';
                else
                    textboxRePassword.PasswordChar = dot;
            }
            else if (buttonShowRePassword.toggleState == false)
            {
                textboxRePassword.PasswordChar = '\0';
            }
        }

        private void ButtonCheckID_MouseClick(object sender, MouseEventArgs e)
        {
            if (textboxEmail.Text == "" || textboxEmail.Text == "Masukkan email dengan benar.")
                textboxEmail.Text = "Masukkan email dengan benar.";
            if (textboxRePassword.Text == "" || textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter.")
                textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
            if (textboxPassword.Text == "" || textboxPassword.Text == "Password harus terdiri dari 8-16 karakter.")
                textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
            if (textboxID.Text == "" || textboxID.Text == "ID harus terdiri dari 5-16 karakter.")
                textboxID.Text = "ID harus terdiri dari 5-16 karakter.";

            if (textboxID.Text != "ID harus terdiri dari 5-16 karakter.")
            {
                if (textboxID.Text.Length < 5 || textboxID.Text.Length > 16)
                {
                    MessageBox.Show("ID kurang dari 5 / lebih dari 16");
                }
                else
                {
                    if (File.Exists("cstrike\\addons\\amxmodx\\data\\file_vault\\" + textboxID.Text + ".txt"))
                    {
                        textboxID.Text = "ID harus terdiri dari 5-16 karakter.";
                        MessageBox.Show("ID ini sudah terpakai");
                    }
                    else
                    {
                        konfirmasiid = textboxID.Text;
                        MessageBox.Show("ID dapat digunakan");
                    }
                }
            }
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void ButtonCheckEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (textboxEmail.Text == "" || textboxEmail.Text == "Masukkan email dengan benar.")
                if (textboxRePassword.Text == "" || textboxRePassword.Text == "Password harus terdiri dari 8-16 karakter.")
                    textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
            if (textboxPassword.Text == "" || textboxPassword.Text == "Password harus terdiri dari 8-16 karakter.")
                textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
            if (textboxID.Text == "" || textboxID.Text == "ID harus terdiri dari 5-16 karakter.")
                textboxID.Text = "ID harus terdiri dari 5-16 karakter.";

            if (textboxEmail.Text != "Masukkan email dengan benar.")
            {

                DirectoryInfo d = new DirectoryInfo("cstrike\\addons\\amxmodx\\data\\file_vault\\");
                FileInfo[] Files = d.GetFiles("*.txt");
                int ada = 0;
                foreach (FileInfo file in Files)
                {
                    if (File.ReadAllText(file.FullName).Contains(textboxEmail.Text))
                        ada = ada + 1;

                }
                if (!textboxEmail.Text.Contains("@"))
                {
                    MessageBox.Show("Alamat email yang anda masukan tidak terdaftar.");
                }
                else
                {
                    if (ada > 0)
                    {
                        textboxEmail.Text = "Masukkan email dengan benar.";
                        MessageBox.Show("E-mail sudah terpakai.");
                    }
                    else
                    {
                        konfirmasiemail = textboxEmail.Text;
                        MessageBox.Show("E-mail bisa digunakan.");
                    }
                }
            }
        }
    }
}
