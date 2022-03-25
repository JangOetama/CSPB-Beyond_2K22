using System;
using System.Drawing;

namespace Counter_Strike_Point_Blank
{
    partial class formCSPBLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCSPBLauncher));
            this.picMoverUp = new System.Windows.Forms.PictureBox();
            this.picMoverDown = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFile2 = new System.Windows.Forms.Label();
            this.progressFile = new System.Windows.Forms.PictureBox();
            this.progressTotal = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.webCSPB = new System.Windows.Forms.WebBrowser();
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.lblRegistry = new System.Windows.Forms.Label();
            this.lblForget = new System.Windows.Forms.Label();
            this.lblNick = new System.Windows.Forms.Label();
            this.chckboxLogin = new Evolved_Counter_Strike.uc.button();
            this.btnLogin2 = new Evolved_Counter_Strike.uc.button();
            this.btnLogout = new Evolved_Counter_Strike.uc.button();
            this.exitLogin = new Evolved_Counter_Strike.uc.button();
            this.btnLogin = new Evolved_Counter_Strike.uc.button();
            this.btnMinimize = new Evolved_Counter_Strike.uc.button();
            this.btnClose = new Evolved_Counter_Strike.uc.button();
            this.btnCheck = new Evolved_Counter_Strike.uc.button();
            this.btnStart = new Evolved_Counter_Strike.uc.button();
            ((System.ComponentModel.ISupportInitialize)(this.picMoverUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMoverDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            this.SuspendLayout();

            this.picCheck.BackgroundImage = new Bitmap(CJDW.CropImage(new Bitmap(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnCheck.png")), new Rectangle(new Point(2, 490), new Size(221, 158))), new Size(508, 451));
            this.chckboxLogin.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnCheckBoxLogin.png");
            this.chckboxLogin.ImageButtonToggle = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnCheckBoxLogin.png");
            this.btnLogin2.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnLogin.png");
            this.btnLogout.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnLogout.png");
            this.exitLogin.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnCloseLogin.png");
            this.btnLogin.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnLogin.png");
            this.btnMinimize.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnMinimize.png");
            this.btnClose.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnClose.png");
            this.btnCheck.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnCheck.png");
            this.btnStart.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnStart.png");
            this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\backLauncher.png");
            // 
            // picMoverUp
            // 
            this.picMoverUp.BackColor = System.Drawing.Color.Transparent;
            this.picMoverUp.Location = new System.Drawing.Point(-1, 0);
            this.picMoverUp.Name = "picMoverUp";
            this.picMoverUp.Size = new System.Drawing.Size(793, 26);
            this.picMoverUp.TabIndex = 0;
            this.picMoverUp.TabStop = false;
            this.picMoverUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mover_MouseDown);
            this.picMoverUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mover_MouseMove);
            this.picMoverUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mover_MouseUp);
            // 
            // picMoverDown
            // 
            this.picMoverDown.BackColor = System.Drawing.Color.Transparent;
            this.picMoverDown.Location = new System.Drawing.Point(-1, 437);
            this.picMoverDown.Name = "picMoverDown";
            this.picMoverDown.Size = new System.Drawing.Size(793, 93);
            this.picMoverDown.TabIndex = 1;
            this.picMoverDown.TabStop = false;
            this.picMoverDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mover_MouseDown);
            this.picMoverDown.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mover_MouseMove);
            this.picMoverDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mover_MouseUp);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(11, 443);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(264, 17);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Anda bisa memulai permainan sekarang!";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.BackColor = System.Drawing.Color.Transparent;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFile.Location = new System.Drawing.Point(12, 463);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(30, 17);
            this.lblFile.TabIndex = 22;
            this.lblFile.Text = "File";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(12, 495);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "Total";
            // 
            // lblFile2
            // 
            this.lblFile2.AutoSize = true;
            this.lblFile2.BackColor = System.Drawing.Color.Transparent;
            this.lblFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFile2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFile2.Location = new System.Drawing.Point(49, 463);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(0, 17);
            this.lblFile2.TabIndex = 24;
            // 
            // progressFile
            // 
            this.progressFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(172)))), ((int)(((byte)(240)))));
            this.progressFile.Location = new System.Drawing.Point(14, 481);
            this.progressFile.Name = "progressFile";
            this.progressFile.Size = new System.Drawing.Size(463, 9);
            this.progressFile.TabIndex = 25;
            this.progressFile.TabStop = false;
            // 
            // progressTotal
            // 
            this.progressTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(172)))), ((int)(((byte)(240)))));
            this.progressTotal.Location = new System.Drawing.Point(14, 514);
            this.progressTotal.Name = "progressTotal";
            this.progressTotal.Size = new System.Drawing.Size(463, 9);
            this.progressTotal.TabIndex = 26;
            this.progressTotal.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtboxID
            // 
            this.txtboxID.BackColor = System.Drawing.Color.Black;
            this.txtboxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtboxID.Location = new System.Drawing.Point(482, 170);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(250, 15);
            this.txtboxID.TabIndex = 29;
            this.txtboxID.Visible = false;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BackColor = System.Drawing.Color.Black;
            this.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtboxPassword.Location = new System.Drawing.Point(482, 251);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(250, 13);
            this.txtboxPassword.TabIndex = 30;
            this.txtboxPassword.UseSystemPasswordChar = true;
            this.txtboxPassword.Visible = false;
            // 
            // webCSPB
            // 
            this.webCSPB.Location = new System.Drawing.Point(2, 28);
            this.webCSPB.MinimumSize = new System.Drawing.Size(20, 20);
            this.webCSPB.Name = "webCSPB";
            this.webCSPB.Size = new System.Drawing.Size(787, 412);
            this.webCSPB.TabIndex = 31;
            this.webCSPB.Url = new System.Uri("", System.UriKind.Relative);
            this.webCSPB.Visible = false;
            // 
            // picCheck
            // 
            this.picCheck.BackColor = System.Drawing.Color.Transparent;
            this.picCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCheck.Location = new System.Drawing.Point(508, 451);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(106, 76);
            this.picCheck.TabIndex = 13;
            this.picCheck.TabStop = false;
            // 
            // lblRegistry
            // 
            this.lblRegistry.AutoSize = true;
            this.lblRegistry.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRegistry.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRegistry.Location = new System.Drawing.Point(561, 374);
            this.lblRegistry.Name = "lblRegistry";
            this.lblRegistry.Size = new System.Drawing.Size(150, 15);
            this.lblRegistry.TabIndex = 40;
            this.lblRegistry.Text = "Belum memiliki akun?";
            this.lblRegistry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRegistry.Visible = false;
            this.lblRegistry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseClick);
            // 
            // lblForget
            // 
            this.lblForget.AutoSize = true;
            this.lblForget.BackColor = System.Drawing.Color.Transparent;
            this.lblForget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblForget.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblForget.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblForget.Location = new System.Drawing.Point(598, 402);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(113, 15);
            this.lblForget.TabIndex = 41;
            this.lblForget.Text = "Lupa Password?";
            this.lblForget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblForget.Visible = false;
            this.lblForget.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblForget_MouseClick);
            // 
            // lblNick
            // 
            this.lblNick.BackColor = System.Drawing.Color.Transparent;
            this.lblNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblNick.ForeColor = System.Drawing.Color.White;
            this.lblNick.Location = new System.Drawing.Point(403, 3);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(211, 23);
            this.lblNick.TabIndex = 42;
            this.lblNick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mover_MouseDown);
            this.lblNick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mover_MouseMove);
            this.lblNick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mover_MouseUp);
            // 
            // chckboxLogin
            // 
            this.chckboxLogin.ImagePositionActive = "0,26";
            this.chckboxLogin.ImagePositionDisabled = "0,0";
            this.chckboxLogin.ImagePositionHover = "0,13";
            this.chckboxLogin.ImagePositionNormal = "0,0";
            this.chckboxLogin.ImageTogglePositionActive = "0,26";
            this.chckboxLogin.ImageTogglePositionDisabled = "0,26";
            this.chckboxLogin.ImageTogglePositionHover = "0,26";
            this.chckboxLogin.ImageTogglePositionNormal = "0,26";
            this.chckboxLogin.Location = new System.Drawing.Point(469, 281);
            this.chckboxLogin.Name = "chckboxLogin";
            this.chckboxLogin.Size = new System.Drawing.Size(13, 13);
            this.chckboxLogin.SizeButton = "13,13";
            this.chckboxLogin.TabIndex = 45;
            this.chckboxLogin.TextButton = null;
            this.chckboxLogin.TextFont = null;
            this.chckboxLogin.TextFontColorActive = null;
            this.chckboxLogin.TextFontColorDisabled = null;
            this.chckboxLogin.TextFontColorHover = null;
            this.chckboxLogin.TextFontColorNormal = null;
            this.chckboxLogin.Toggle = true;
            this.chckboxLogin.Visible = false;
            this.chckboxLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChckboxLogin_MouseClick);
            // 
            // btnLogin2
            // 
            this.btnLogin2.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin2.ImageButtonToggle = null;
            this.btnLogin2.ImagePositionActive = "0,48";
            this.btnLogin2.ImagePositionDisabled = "";
            this.btnLogin2.ImagePositionHover = "0,24";
            this.btnLogin2.ImagePositionNormal = "0,0";
            this.btnLogin2.ImageTogglePositionActive = null;
            this.btnLogin2.ImageTogglePositionDisabled = null;
            this.btnLogin2.ImageTogglePositionHover = null;
            this.btnLogin2.ImageTogglePositionNormal = null;
            this.btnLogin2.Location = new System.Drawing.Point(469, 316);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.Size = new System.Drawing.Size(235, 43);
            this.btnLogin2.SizeButton = "122,24";
            this.btnLogin2.TabIndex = 44;
            this.btnLogin2.TextButton = "Log in";
            this.btnLogin2.TextFont = new System.Drawing.Font("Arial Black", 12.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLogin2.TextFontColorActive = "FFFFF2";
            this.btnLogin2.TextFontColorDisabled = "C0C1C5";
            this.btnLogin2.TextFontColorHover = "0000CF";
            this.btnLogin2.TextFontColorNormal = "FFFFFF";
            this.btnLogin2.Toggle = false;
            this.btnLogin2.Visible = false;
            this.btnLogin2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnLogin2_MouseClick);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.ImageButtonToggle = null;
            this.btnLogout.ImagePositionActive = "0,48";
            this.btnLogout.ImagePositionDisabled = "";
            this.btnLogout.ImagePositionHover = "0,24";
            this.btnLogout.ImagePositionNormal = "0,0";
            this.btnLogout.ImageTogglePositionActive = null;
            this.btnLogout.ImageTogglePositionDisabled = null;
            this.btnLogout.ImageTogglePositionHover = null;
            this.btnLogout.ImageTogglePositionNormal = null;
            this.btnLogout.Location = new System.Drawing.Point(615, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(121, 24);
            this.btnLogout.SizeButton = "122,24";
            this.btnLogout.TabIndex = 43;
            this.btnLogout.TextButton = "Logout";
            this.btnLogout.TextFont = new System.Drawing.Font("Arial Narrow", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.TextFontColorActive = "FFFFF2";
            this.btnLogout.TextFontColorDisabled = "C0C1C5";
            this.btnLogout.TextFontColorHover = "0000CF";
            this.btnLogout.TextFontColorNormal = "FFFFFF";
            this.btnLogout.Toggle = false;
            this.btnLogout.Visible = false;
            this.btnLogout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnLogout_MouseClick);
            // 
            // exitLogin
            // 
            this.exitLogin.BackColor = System.Drawing.Color.Transparent;
            this.exitLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitLogin.ImageButtonToggle = null;
            this.exitLogin.ImagePositionActive = "0,0";
            this.exitLogin.ImagePositionDisabled = "0,0";
            this.exitLogin.ImagePositionHover = "0,24";
            this.exitLogin.ImagePositionNormal = "0,0";
            this.exitLogin.ImageTogglePositionActive = null;
            this.exitLogin.ImageTogglePositionDisabled = null;
            this.exitLogin.ImageTogglePositionHover = null;
            this.exitLogin.ImageTogglePositionNormal = null;
            this.exitLogin.Location = new System.Drawing.Point(745, 21);
            this.exitLogin.Name = "exitLogin";
            this.exitLogin.Size = new System.Drawing.Size(24, 24);
            this.exitLogin.SizeButton = "24,24";
            this.exitLogin.TabIndex = 36;
            this.exitLogin.TextButton = null;
            this.exitLogin.TextFont = null;
            this.exitLogin.TextFontColorActive = null;
            this.exitLogin.TextFontColorDisabled = null;
            this.exitLogin.TextFontColorHover = null;
            this.exitLogin.TextFontColorNormal = null;
            this.exitLogin.Toggle = false;
            this.exitLogin.Visible = false;
            this.exitLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exitlogin_MouseClick);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.ImageButtonToggle = null;
            this.btnLogin.ImagePositionActive = "0,48";
            this.btnLogin.ImagePositionDisabled = "";
            this.btnLogin.ImagePositionHover = "0,24";
            this.btnLogin.ImagePositionNormal = "0,0";
            this.btnLogin.ImageTogglePositionActive = null;
            this.btnLogin.ImageTogglePositionDisabled = null;
            this.btnLogin.ImageTogglePositionHover = null;
            this.btnLogin.ImageTogglePositionNormal = null;
            this.btnLogin.Location = new System.Drawing.Point(615, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 24);
            this.btnLogin.SizeButton = "122,24";
            this.btnLogin.TabIndex = 39;
            this.btnLogin.TextButton = "Log in";
            this.btnLogin.TextFont = new System.Drawing.Font("Arial Narrow", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnLogin.TextFontColorActive = "FFFFF2";
            this.btnLogin.TextFontColorDisabled = "C0C1C5";
            this.btnLogin.TextFontColorHover = "0000CF";
            this.btnLogin.TextFontColorNormal = "FFFFFF";
            this.btnLogin.Toggle = false;
            this.btnLogin.Visible = false;
            this.btnLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LOGIN_MouseClick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.ImageButtonToggle = null;
            this.btnMinimize.ImagePositionActive = "0,104";
            this.btnMinimize.ImagePositionDisabled = "0,0";
            this.btnMinimize.ImagePositionHover = "0,52";
            this.btnMinimize.ImagePositionNormal = "0,0";
            this.btnMinimize.ImageTogglePositionActive = null;
            this.btnMinimize.ImageTogglePositionDisabled = null;
            this.btnMinimize.ImageTogglePositionHover = null;
            this.btnMinimize.ImageTogglePositionNormal = null;
            this.btnMinimize.Location = new System.Drawing.Point(736, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeButton = "52,52";
            this.btnMinimize.TabIndex = 38;
            this.btnMinimize.TextButton = null;
            this.btnMinimize.TextFont = null;
            this.btnMinimize.TextFontColorActive = null;
            this.btnMinimize.TextFontColorDisabled = null;
            this.btnMinimize.TextFontColorHover = null;
            this.btnMinimize.TextFontColorNormal = null;
            this.btnMinimize.Toggle = false;
            this.btnMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.min_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.ImageButtonToggle = null;
            this.btnClose.ImagePositionActive = "0,104";
            this.btnClose.ImagePositionDisabled = "0,0";
            this.btnClose.ImagePositionHover = "0,52";
            this.btnClose.ImagePositionNormal = "0,0";
            this.btnClose.ImageTogglePositionActive = null;
            this.btnClose.ImageTogglePositionDisabled = null;
            this.btnClose.ImageTogglePositionHover = null;
            this.btnClose.ImageTogglePositionNormal = null;
            this.btnClose.Location = new System.Drawing.Point(764, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeButton = "52,52";
            this.btnClose.TabIndex = 37;
            this.btnClose.TextButton = null;
            this.btnClose.TextFont = null;
            this.btnClose.TextFontColorActive = null;
            this.btnClose.TextFontColorDisabled = null;
            this.btnClose.TextFontColorHover = null;
            this.btnClose.TextFontColorNormal = null;
            this.btnClose.Toggle = false;
            this.btnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_MouseClick);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.ImageButtonToggle = null;
            this.btnCheck.ImagePositionActive = "2,327";
            this.btnCheck.ImagePositionDisabled = "2,490";
            this.btnCheck.ImagePositionHover = "2,165";
            this.btnCheck.ImagePositionNormal = "2,2";
            this.btnCheck.ImageTogglePositionActive = null;
            this.btnCheck.ImageTogglePositionDisabled = null;
            this.btnCheck.ImageTogglePositionHover = null;
            this.btnCheck.ImageTogglePositionNormal = null;
            this.btnCheck.Location = new System.Drawing.Point(508, 451);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(106, 76);
            this.btnCheck.SizeButton = "221,158";
            this.btnCheck.TabIndex = 33;
            this.btnCheck.TextButton = null;
            this.btnCheck.TextFont = null;
            this.btnCheck.TextFontColorActive = null;
            this.btnCheck.TextFontColorDisabled = null;
            this.btnCheck.TextFontColorHover = null;
            this.btnCheck.TextFontColorNormal = null;
            this.btnCheck.Toggle = false;
            this.btnCheck.MouseClick += new System.Windows.Forms.MouseEventHandler(this.check_MouseClick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.ImageButtonToggle = null;
            this.btnStart.ImagePositionActive = "2,327";
            this.btnStart.ImagePositionDisabled = "2,490";
            this.btnStart.ImagePositionHover = "2,165";
            this.btnStart.ImagePositionNormal = "2,2";
            this.btnStart.ImageTogglePositionActive = null;
            this.btnStart.ImageTogglePositionDisabled = null;
            this.btnStart.ImageTogglePositionHover = null;
            this.btnStart.ImageTogglePositionNormal = null;
            this.btnStart.Location = new System.Drawing.Point(621, 451);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(166, 76);
            this.btnStart.SizeButton = "346,158";
            this.btnStart.TabIndex = 32;
            this.btnStart.TextButton = null;
            this.btnStart.TextFont = null;
            this.btnStart.TextFontColorActive = null;
            this.btnStart.TextFontColorDisabled = null;
            this.btnStart.TextFontColorHover = null;
            this.btnStart.TextFontColorNormal = null;
            this.btnStart.Toggle = false;
            this.btnStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.star_MouseClick);
            // 
            // formCSPBLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 531);
            this.ControlBox = false;
            this.Controls.Add(this.chckboxLogin);
            this.Controls.Add(this.btnLogin2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.lblForget);
            this.Controls.Add(this.lblRegistry);
            this.Controls.Add(this.exitLogin);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxID);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picMoverUp);
            this.Controls.Add(this.webCSPB);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressTotal);
            this.Controls.Add(this.progressFile);
            this.Controls.Add(this.lblFile2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.picCheck);
            this.Controls.Add(this.picMoverDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCSPBLauncher";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSPBLauncher";
            ((System.ComponentModel.ISupportInitialize)(this.picMoverUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMoverDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.PictureBox picMoverUp;
        private System.Windows.Forms.PictureBox picMoverDown;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFile2;
        private System.Windows.Forms.PictureBox progressFile;
        private System.Windows.Forms.PictureBox progressTotal;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.WebBrowser webCSPB;
        private Evolved_Counter_Strike.uc.button btnStart;
        private Evolved_Counter_Strike.uc.button btnCheck;
        private System.Windows.Forms.PictureBox picCheck;
        private Evolved_Counter_Strike.uc.button exitLogin;
        private Evolved_Counter_Strike.uc.button btnClose;
        private Evolved_Counter_Strike.uc.button btnMinimize;
        private Evolved_Counter_Strike.uc.button btnLogin;
        private System.Windows.Forms.Label lblRegistry;
        private System.Windows.Forms.Label lblForget;
        private System.Windows.Forms.Label lblNick;
        private Evolved_Counter_Strike.uc.button btnLogout;
        private Evolved_Counter_Strike.uc.button btnLogin2;
        private Evolved_Counter_Strike.uc.button chckboxLogin;
    }
}

