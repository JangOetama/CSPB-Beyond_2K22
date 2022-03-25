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
using System.Runtime.InteropServices;

namespace Counter_Strike_Point_Blank
{
    public partial class formCSPBLauncher : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public formCSPBLauncher()
        {

            InitializeComponent();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
            if (CJDW.GetFile("Settings.ini", "Setting", "Login") == "" || CJDW.GetFile("Settings.ini", "Setting", "Login") == null)
            {
                btnLogin.Visible = true;
                btnLogout.Visible = false;
            }
            else
            {
                btnLogin.Visible = false;
                btnLogout.Visible = true;
            }

            lblNick.Text = CJDW.GetFile("Settings.ini", "Setting", "Login").ToString();

                try
            {
                if (IsConnectedToInternet() == true)
                {
                    webCSPB.Navigate("https://www.pointblank.id/launcher/index");
                    webCSPB.DocumentCompleted += (webSender, webE) =>
                    {
                        webCSPB.Visible = true;
                    };
                }

            }
            catch
            {
                webCSPB.Visible = false;
            }
            
        }



        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int des, int value);
        bool IsConnectedToInternet()
        {
            bool check;
            int description;
            check = InternetGetConnectedState(out description, 0);
            return check;
        }
        private void mover_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void mover_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void mover_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void piclogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void piclogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void piclogin_MouseMove(object sender, MouseEventArgs e)
        {

        }


        private void min_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda benar-benar ingin keluar?", "PBLauncher", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void check_MouseClick(object sender, MouseEventArgs e)
        {
            btnStart.Enabled = false;
            btnCheck.Visible = false;
            cCurrent = -1;
            cFP = 0;
            lblStatus.Text = "Memindai berkas.";
            progressFile.Width = 0;
            progressTotal.Width = 0;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (cFP < 100)
            {
                progressFile.Width = cFP * 463 / 100;
                cFP+= new Random().Next(10, 100);
            } else
            {
                timer2.Stop();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cCurrent++;
            if (cCurrent < cFiles.Length)
            {
                lblFile2.Text = cFiles[cCurrent];
                cFP = 0;
                progressTotal.Width = cCurrent * 463 / cFiles.Length;
                timer2.Start();
            }
            else
            {
                progressFile.Width = 463;
                progressTotal.Width = 463;
                btnCheck.Visible = true;
                btnStart.Enabled = true;
                lblStatus.Text = "Anda bisa memulai permainan sekarang!";
                lblFile2.Text = "";
            }
            timer1.Stop();
        }

        string[] cFiles = File.ReadAllLines("database.txt");
        int cCurrent = 0;
        int cFP = 0;

        private void star_MouseClick(object sender, MouseEventArgs e)
        {
            btnCheck.Enabled = false;
            if (CJDW.GetFile("Settings.ini", "Setting", "Login") == "" || CJDW.GetFile("Settings.ini", "Setting", "Login") == null)
            {
                login();
            }
            else
            {
                formWaitPack form2 = new formWaitPack();
                Hide();
                form2.ShowDialog();
                Close();
            }
        }

        private void LOGIN_MouseClick(object sender, MouseEventArgs e)
        {
                login();

        }

        private void login()
        {
            if (CJDW.GetFile("Settings.ini", "Setting", "SaveID") == "" || CJDW.GetFile("Settings.ini", "Setting", "SaveID") == null)
            {
                chckboxLogin.toggleState = false;
                txtboxID.Text = null;
            }
            else
            {
                chckboxLogin.toggleState = true;
                txtboxID.Text = CJDW.GetFile("Settings.ini", "Setting", "SaveID").ToString();
            }
            chckboxLogin.Visible = true;
            btnLogin2.Visible = true;
            exitLogin.Visible = true;
            txtboxID.Visible = true;
            txtboxPassword.Visible = true;
            lblForget.Visible = true;
            lblRegistry.Visible = true;
            this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\backSignin.png");
            btnLogin.Visible = false;
            btnMinimize.Visible = false;
            btnClose.Visible = false;
            webCSPB.Visible = false;
            lblStatus.Visible = false;
            lblTotal.Visible = false;
            progressTotal.Visible = false;
            lblFile.Visible = false;
            progressFile.Visible = false;
            lblFile2.Visible = false;
            btnCheck.Visible = false;
            btnStart.Visible = false;
            picCheck.Visible = false;
            picMoverUp.Size = new Size(793, 437);
        }
        private void logout()
        {
            CJDW.ChangeFile("Settings.ini", "Setting", "Login", "");
            lblNick.Text = null;
            btnLogin.Visible = true;
            btnLogout.Visible = false;
        }
        private void Exitlogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (CJDW.GetFile("Settings.ini", "Setting", "Login") == "" || CJDW.GetFile("Settings.ini", "Setting", "Login") == null)
            {
                btnLogin.Visible = true;
                btnLogout.Visible = false;
            }
            else
            {
                btnLogin.Visible = false;
                btnLogout.Visible = true;
            }
            chckboxLogin.Visible = false;
            btnLogin2.Visible = false;
            txtboxID.Visible = false;
            txtboxPassword.Visible = false;
            exitLogin.Visible = false;
            lblForget.Visible = false;
            lblRegistry.Visible = false;
            this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\backLauncher.png");
            btnLogin.Visible = true;
            btnMinimize.Visible = true;
            btnClose.Visible = true;
            webCSPB.Visible = true;
            lblStatus.Visible = true;
            lblTotal.Visible = true;
            progressTotal.Visible = true;
            lblFile.Visible = true;
            progressFile.Visible = true;
            lblFile2.Visible = true;
            btnCheck.Visible = true;
            btnStart.Visible = true;
            picCheck.Visible = true;
            picMoverUp.Size = new Size(793, 26);
        }

        private void Label1_MouseClick(object sender, MouseEventArgs e)
        {
            formRegistry form2 = new formRegistry();
            form2.ShowDialog();
        }

        private void LblForget_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void BtnLogout_MouseClick(object sender, MouseEventArgs e)
        {
            logout();
        }

        private void BtnLogin2_MouseClick(object sender, MouseEventArgs e)
        { 
            if (CJDW.GetFileNoSection("cstrike\\addons\\amxmodx\\data\\file_vault\\"+txtboxID.Text+".txt", "\"" + "userPass" + "\"" ) == "\"" + txtboxPassword.Text + "\"")
            {
                CJDW.ChangeFile("Settings.ini", "Setting", "Login", txtboxID.Text);
                lblNick.Text = CJDW.GetFile("Settings.ini", "Setting", "Login").ToString();    
                btnLogin.Visible = false;
                txtboxID.Text = "";
                txtboxPassword.Text = "";
                btnLogin2.Visible = false;
                btnLogout.Visible = true;
                txtboxID.Visible = false;
                chckboxLogin.Visible = false;
                txtboxPassword.Visible = false;
                exitLogin.Visible = false;
                lblForget.Visible = false;
                lblRegistry.Visible = false;
                this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\backLauncher.png");
                btnMinimize.Visible = true;
                btnClose.Visible = true;
                webCSPB.Visible = true;
                lblStatus.Visible = true;
                lblTotal.Visible = true;
                progressTotal.Visible = true;
                lblFile.Visible = true;
                progressFile.Visible = true;
                lblFile2.Visible = true;
                btnCheck.Visible = true;
                btnStart.Visible = true;
                picCheck.Visible = true;
                picMoverUp.Size = new Size(793, 26);
            }
        }

        private void ChckboxLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (chckboxLogin.toggleState == true)
            {
                CJDW.ChangeFile("Settings.ini", "Setting", "SaveID", "");
            }
            else if (chckboxLogin.toggleState == false)
            {
                CJDW.ChangeFile("Settings.ini", "Setting", "SaveID", txtboxID.Text);
            }
        }
    }
}
