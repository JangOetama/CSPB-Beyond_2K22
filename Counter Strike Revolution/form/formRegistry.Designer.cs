using System;
using System.Drawing;

namespace Counter_Strike_Point_Blank
{
    partial class formRegistry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistry));
            this.textboxID = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.textboxRePassword = new System.Windows.Forms.TextBox();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelInputID = new System.Windows.Forms.Panel();
            this.panelInputPassword = new System.Windows.Forms.Panel();
            this.panelInputRePassword = new System.Windows.Forms.Panel();
            this.panelInputEmail = new System.Windows.Forms.Panel();
            this.labelConfirm1 = new System.Windows.Forms.Label();
            this.labelConfirmKetentuanLayanan = new System.Windows.Forms.Label();
            this.labelConfirmKebijakanPrivasi = new System.Windows.Forms.Label();
            this.buttonRegistry = new Evolved_Counter_Strike.uc.button();
            this.buttonCheckBoxAccept = new Evolved_Counter_Strike.uc.button();
            this.buttonShowRePassword = new Evolved_Counter_Strike.uc.button();
            this.buttonShowPassword = new Evolved_Counter_Strike.uc.button();
            this.buttonCheckEmail = new Evolved_Counter_Strike.uc.button();
            this.buttonCheckID = new Evolved_Counter_Strike.uc.button();
            this.picCreateAccount = new System.Windows.Forms.PictureBox();
            this.btnBackToHome = new Evolved_Counter_Strike.uc.button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelInputPassword.SuspendLayout();
            this.panelInputRePassword.SuspendLayout();
            this.panelInputEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // pic nya
            //

            this.buttonRegistry.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnSignup.png");
            this.buttonCheckBoxAccept.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnUnCheckBox.png");
            this.buttonCheckBoxAccept.ImageButtonToggle = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnCheckBox.png");
            this.buttonShowRePassword.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnShowPass.png");
            this.buttonShowRePassword.ImageButtonToggle = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnShowPass1.png");
            this.buttonShowPassword.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnShowPass.png");
            this.buttonShowPassword.ImageButtonToggle = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnShowPass1.png");
            this.buttonCheckEmail.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnChck.png");
            this.buttonCheckID.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnChck.png");
            this.picCreateAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCreateAccount.BackgroundImage")));
            this.btnBackToHome.ImageButton = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\btnSignup.png");
            this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Pack\\Gui\\Launcher\\backSignUp.png");

            // 
            // textboxID
            // 
            this.textboxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textboxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.textboxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.textboxID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textboxID.Location = new System.Drawing.Point(313, 123);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(273, 13);
            this.textboxID.TabIndex = 1;
            this.textboxID.Text = "ID harus terdiri dari 5-16 karakter.";
            this.textboxID.Click += new System.EventHandler(this.TextBox1_Click);
            this.textboxID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyUp);
            // 
            // textboxPassword
            // 
            this.textboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.textboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.textboxPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textboxPassword.Location = new System.Drawing.Point(19, 21);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(273, 13);
            this.textboxPassword.TabIndex = 2;
            this.textboxPassword.Text = "Password harus terdiri dari 8-16 karakter.";
            this.textboxPassword.Click += new System.EventHandler(this.TextBox2_Click);
            this.textboxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox2_KeyUp);
            // 
            // textboxRePassword
            // 
            this.textboxRePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textboxRePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.textboxRePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.textboxRePassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textboxRePassword.Location = new System.Drawing.Point(19, 22);
            this.textboxRePassword.Name = "textboxRePassword";
            this.textboxRePassword.Size = new System.Drawing.Size(273, 13);
            this.textboxRePassword.TabIndex = 3;
            this.textboxRePassword.Text = "Password harus terdiri dari 8-16 karakter.";
            this.textboxRePassword.Click += new System.EventHandler(this.TextBox3_Click);
            this.textboxRePassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox3_KeyUp);
            // 
            // textboxEmail
            // 
            this.textboxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textboxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.textboxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.textboxEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textboxEmail.Location = new System.Drawing.Point(19, 22);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(273, 13);
            this.textboxEmail.TabIndex = 4;
            this.textboxEmail.Text = "Masukkan email dengan benar.";
            this.textboxEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox4_MouseClick);
            this.textboxEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox4_KeyUp);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(355, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(234, 39);
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // panelInputID
            // 
            this.panelInputID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelInputID.BackColor = System.Drawing.Color.Transparent;
            this.panelInputID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelInputID.Location = new System.Drawing.Point(294, 101);
            this.panelInputID.Name = "panelInputID";
            this.panelInputID.Size = new System.Drawing.Size(303, 57);
            this.panelInputID.TabIndex = 0;
            this.panelInputID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseClick);
            // 
            // panelInputPassword
            // 
            this.panelInputPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelInputPassword.BackColor = System.Drawing.Color.Transparent;
            this.panelInputPassword.Controls.Add(this.textboxPassword);
            this.panelInputPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelInputPassword.Location = new System.Drawing.Point(294, 197);
            this.panelInputPassword.Name = "panelInputPassword";
            this.panelInputPassword.Size = new System.Drawing.Size(365, 57);
            this.panelInputPassword.TabIndex = 0;
            this.panelInputPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseClick);
            // 
            // panelInputRePassword
            // 
            this.panelInputRePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelInputRePassword.BackColor = System.Drawing.Color.Transparent;
            this.panelInputRePassword.Controls.Add(this.textboxRePassword);
            this.panelInputRePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelInputRePassword.Location = new System.Drawing.Point(294, 290);
            this.panelInputRePassword.Name = "panelInputRePassword";
            this.panelInputRePassword.Size = new System.Drawing.Size(365, 57);
            this.panelInputRePassword.TabIndex = 0;
            this.panelInputRePassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseClick);
            // 
            // panelInputEmail
            // 
            this.panelInputEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelInputEmail.BackColor = System.Drawing.Color.Transparent;
            this.panelInputEmail.Controls.Add(this.textboxEmail);
            this.panelInputEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelInputEmail.Location = new System.Drawing.Point(294, 388);
            this.panelInputEmail.Name = "panelInputEmail";
            this.panelInputEmail.Size = new System.Drawing.Size(303, 57);
            this.panelInputEmail.TabIndex = 0;
            this.panelInputEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseClick);
            // 
            // labelConfirm1
            // 
            this.labelConfirm1.AutoSize = true;
            this.labelConfirm1.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F);
            this.labelConfirm1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelConfirm1.Location = new System.Drawing.Point(340, 482);
            this.labelConfirm1.Name = "labelConfirm1";
            this.labelConfirm1.Size = new System.Drawing.Size(273, 16);
            this.labelConfirm1.TabIndex = 0;
            this.labelConfirm1.Text = "Saya telah menyetujui                                     dan";
            // 
            // labelConfirmKetentuanLayanan
            // 
            this.labelConfirmKetentuanLayanan.AutoSize = true;
            this.labelConfirmKetentuanLayanan.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirmKetentuanLayanan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelConfirmKetentuanLayanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F);
            this.labelConfirmKetentuanLayanan.ForeColor = System.Drawing.Color.White;
            this.labelConfirmKetentuanLayanan.Location = new System.Drawing.Point(465, 482);
            this.labelConfirmKetentuanLayanan.Name = "labelConfirmKetentuanLayanan";
            this.labelConfirmKetentuanLayanan.Size = new System.Drawing.Size(118, 16);
            this.labelConfirmKetentuanLayanan.TabIndex = 0;
            this.labelConfirmKetentuanLayanan.Text = "Ketentuan layanan";
            // 
            // labelConfirmKebijakanPrivasi
            // 
            this.labelConfirmKebijakanPrivasi.AutoSize = true;
            this.labelConfirmKebijakanPrivasi.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirmKebijakanPrivasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelConfirmKebijakanPrivasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F);
            this.labelConfirmKebijakanPrivasi.ForeColor = System.Drawing.Color.White;
            this.labelConfirmKebijakanPrivasi.Location = new System.Drawing.Point(340, 502);
            this.labelConfirmKebijakanPrivasi.Name = "labelConfirmKebijakanPrivasi";
            this.labelConfirmKebijakanPrivasi.Size = new System.Drawing.Size(115, 16);
            this.labelConfirmKebijakanPrivasi.TabIndex = 0;
            this.labelConfirmKebijakanPrivasi.Text = "Kebijakan Privasi.";
            // 
            // buttonRegistry
            // 
            this.buttonRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonRegistry.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegistry.ImageButtonToggle = null;
            this.buttonRegistry.ImagePositionActive = "0,0";
            this.buttonRegistry.ImagePositionDisabled = "0,0";
            this.buttonRegistry.ImagePositionHover = "0,90";
            this.buttonRegistry.ImagePositionNormal = "0,0";
            this.buttonRegistry.ImageTogglePositionActive = null;
            this.buttonRegistry.ImageTogglePositionDisabled = null;
            this.buttonRegistry.ImageTogglePositionHover = null;
            this.buttonRegistry.ImageTogglePositionNormal = null;
            this.buttonRegistry.Location = new System.Drawing.Point(376, 560);
            this.buttonRegistry.Name = "buttonRegistry";
            this.buttonRegistry.Size = new System.Drawing.Size(192, 60);
            this.buttonRegistry.SizeButton = "291,  90";
            this.buttonRegistry.TabIndex = 0;
            this.buttonRegistry.TextButton = "REGISTRY";
            this.buttonRegistry.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistry.TextFontColorActive = "#FFFFFF";
            this.buttonRegistry.TextFontColorDisabled = "#FFFFFF";
            this.buttonRegistry.TextFontColorHover = "#FFFFFF";
            this.buttonRegistry.TextFontColorNormal = "#FFFFFF";
            this.buttonRegistry.Toggle = false;
            this.buttonRegistry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonRegistry_MouseClick);
            // 
            // buttonCheckBoxAccept
            // 
            this.buttonCheckBoxAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonCheckBoxAccept.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheckBoxAccept.ImagePositionActive = "0,52";
            this.buttonCheckBoxAccept.ImagePositionDisabled = "0,0";
            this.buttonCheckBoxAccept.ImagePositionHover = "0,26";
            this.buttonCheckBoxAccept.ImagePositionNormal = "0,0";
            this.buttonCheckBoxAccept.ImageTogglePositionActive = null;
            this.buttonCheckBoxAccept.ImageTogglePositionDisabled = null;
            this.buttonCheckBoxAccept.ImageTogglePositionHover = null;
            this.buttonCheckBoxAccept.ImageTogglePositionNormal = null;
            this.buttonCheckBoxAccept.Location = new System.Drawing.Point(312, 481);
            this.buttonCheckBoxAccept.Name = "buttonCheckBoxAccept";
            this.buttonCheckBoxAccept.Size = new System.Drawing.Size(18, 18);
            this.buttonCheckBoxAccept.SizeButton = "26, 26";
            this.buttonCheckBoxAccept.TabIndex = 5;
            this.buttonCheckBoxAccept.TextButton = null;
            this.buttonCheckBoxAccept.TextFont = null;
            this.buttonCheckBoxAccept.TextFontColorActive = null;
            this.buttonCheckBoxAccept.TextFontColorDisabled = null;
            this.buttonCheckBoxAccept.TextFontColorHover = null;
            this.buttonCheckBoxAccept.TextFontColorNormal = null;
            this.buttonCheckBoxAccept.Toggle = true;
            // 
            // buttonShowRePassword
            // 
            this.buttonShowRePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonShowRePassword.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowRePassword.ImagePositionActive = "0,0";
            this.buttonShowRePassword.ImagePositionDisabled = "0,0";
            this.buttonShowRePassword.ImagePositionHover = "0,19";
            this.buttonShowRePassword.ImagePositionNormal = "0,0";
            this.buttonShowRePassword.ImageTogglePositionActive = null;
            this.buttonShowRePassword.ImageTogglePositionDisabled = null;
            this.buttonShowRePassword.ImageTogglePositionHover = null;
            this.buttonShowRePassword.ImageTogglePositionNormal = null;
            this.buttonShowRePassword.Location = new System.Drawing.Point(612, 312);
            this.buttonShowRePassword.Name = "buttonShowRePassword";
            this.buttonShowRePassword.Size = new System.Drawing.Size(24, 19);
            this.buttonShowRePassword.SizeButton = "24, 19";
            this.buttonShowRePassword.TabIndex = 0;
            this.buttonShowRePassword.TextButton = null;
            this.buttonShowRePassword.TextFont = null;
            this.buttonShowRePassword.TextFontColorActive = null;
            this.buttonShowRePassword.TextFontColorDisabled = null;
            this.buttonShowRePassword.TextFontColorHover = null;
            this.buttonShowRePassword.TextFontColorNormal = null;
            this.buttonShowRePassword.Toggle = true;
            this.buttonShowRePassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonShowRePassword_MouseClick);
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowPassword.ImagePositionActive = "0,0";
            this.buttonShowPassword.ImagePositionDisabled = "0,0";
            this.buttonShowPassword.ImagePositionHover = "0,19";
            this.buttonShowPassword.ImagePositionNormal = "0,0";
            this.buttonShowPassword.ImageTogglePositionActive = null;
            this.buttonShowPassword.ImageTogglePositionDisabled = null;
            this.buttonShowPassword.ImageTogglePositionHover = null;
            this.buttonShowPassword.ImageTogglePositionNormal = null;
            this.buttonShowPassword.Location = new System.Drawing.Point(612, 218);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(24, 19);
            this.buttonShowPassword.SizeButton = "24, 19";
            this.buttonShowPassword.TabIndex = 0;
            this.buttonShowPassword.TextButton = null;
            this.buttonShowPassword.TextFont = null;
            this.buttonShowPassword.TextFontColorActive = null;
            this.buttonShowPassword.TextFontColorDisabled = null;
            this.buttonShowPassword.TextFontColorHover = null;
            this.buttonShowPassword.TextFontColorNormal = null;
            this.buttonShowPassword.Toggle = true;
            this.buttonShowPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonShowPassword_MouseClick);
            // 
            // buttonCheckEmail
            // 
            this.buttonCheckEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonCheckEmail.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheckEmail.ImageButtonToggle = null;
            this.buttonCheckEmail.ImagePositionActive = "0,0";
            this.buttonCheckEmail.ImagePositionDisabled = "0,0";
            this.buttonCheckEmail.ImagePositionHover = "0,60";
            this.buttonCheckEmail.ImagePositionNormal = "0,0";
            this.buttonCheckEmail.ImageTogglePositionActive = null;
            this.buttonCheckEmail.ImageTogglePositionDisabled = null;
            this.buttonCheckEmail.ImageTogglePositionHover = null;
            this.buttonCheckEmail.ImageTogglePositionNormal = null;
            this.buttonCheckEmail.Location = new System.Drawing.Point(597, 388);
            this.buttonCheckEmail.Name = "buttonCheckEmail";
            this.buttonCheckEmail.Size = new System.Drawing.Size(62, 57);
            this.buttonCheckEmail.SizeButton = "62, 60";
            this.buttonCheckEmail.TabIndex = 0;
            this.buttonCheckEmail.TextButton = "CHECK";
            this.buttonCheckEmail.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckEmail.TextFontColorActive = "#777777";
            this.buttonCheckEmail.TextFontColorDisabled = "#777777";
            this.buttonCheckEmail.TextFontColorHover = "BFBFBF";
            this.buttonCheckEmail.TextFontColorNormal = "#777777";
            this.buttonCheckEmail.Toggle = false;
            this.buttonCheckEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonCheckEmail_MouseClick);
            // 
            // buttonCheckID
            // 
            this.buttonCheckID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonCheckID.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheckID.ImageButtonToggle = null;
            this.buttonCheckID.ImagePositionActive = "0,0";
            this.buttonCheckID.ImagePositionDisabled = "0,0";
            this.buttonCheckID.ImagePositionHover = "0,60";
            this.buttonCheckID.ImagePositionNormal = "0,0";
            this.buttonCheckID.ImageTogglePositionActive = null;
            this.buttonCheckID.ImageTogglePositionDisabled = null;
            this.buttonCheckID.ImageTogglePositionHover = null;
            this.buttonCheckID.ImageTogglePositionNormal = null;
            this.buttonCheckID.Location = new System.Drawing.Point(597, 101);
            this.buttonCheckID.Name = "buttonCheckID";
            this.buttonCheckID.Size = new System.Drawing.Size(62, 57);
            this.buttonCheckID.SizeButton = "62, 60";
            this.buttonCheckID.TabIndex = 0;
            this.buttonCheckID.TextButton = "CHECK";
            this.buttonCheckID.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckID.TextFontColorActive = "#777777";
            this.buttonCheckID.TextFontColorDisabled = "#777777";
            this.buttonCheckID.TextFontColorHover = "BFBFBF";
            this.buttonCheckID.TextFontColorNormal = "#777777";
            this.buttonCheckID.Toggle = false;
            this.buttonCheckID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonCheckID_MouseClick);
            // 
            // picCreateAccount
            // 
            this.picCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCreateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCreateAccount.Location = new System.Drawing.Point(0, 0);
            this.picCreateAccount.Name = "picCreateAccount";
            this.picCreateAccount.Size = new System.Drawing.Size(969, 688);
            this.picCreateAccount.TabIndex = 6;
            this.picCreateAccount.TabStop = false;
            this.picCreateAccount.Visible = false;
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBackToHome.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToHome.ImageButtonToggle = null;
            this.btnBackToHome.ImagePositionActive = "0,0";
            this.btnBackToHome.ImagePositionDisabled = "0,0";
            this.btnBackToHome.ImagePositionHover = "0,90";
            this.btnBackToHome.ImagePositionNormal = "0,0";
            this.btnBackToHome.ImageTogglePositionActive = null;
            this.btnBackToHome.ImageTogglePositionDisabled = null;
            this.btnBackToHome.ImageTogglePositionHover = null;
            this.btnBackToHome.ImageTogglePositionNormal = null;
            this.btnBackToHome.Location = new System.Drawing.Point(378, 492);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(211, 48);
            this.btnBackToHome.SizeButton = "291,  90";
            this.btnBackToHome.TabIndex = 7;
            this.btnBackToHome.TextButton = "KEMBALI KE HALAMAN UTAMA";
            this.btnBackToHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHome.TextFontColorActive = "#FFFFFF";
            this.btnBackToHome.TextFontColorDisabled = "#FFFFFF";
            this.btnBackToHome.TextFontColorHover = "#FFFFFF";
            this.btnBackToHome.TextFontColorNormal = "#FFFFFF";
            this.btnBackToHome.Toggle = false;
            this.btnBackToHome.Visible = false;
            this.btnBackToHome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseClick);
            // 
            // formRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(953, 649);
            this.Controls.Add(this.btnBackToHome);
            this.Controls.Add(this.picCreateAccount);
            this.Controls.Add(this.buttonRegistry);
            this.Controls.Add(this.buttonCheckBoxAccept);
            this.Controls.Add(this.labelConfirmKebijakanPrivasi);
            this.Controls.Add(this.labelConfirmKetentuanLayanan);
            this.Controls.Add(this.labelConfirm1);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.buttonShowRePassword);
            this.Controls.Add(this.buttonShowPassword);
            this.Controls.Add(this.buttonCheckEmail);
            this.Controls.Add(this.buttonCheckID);
            this.Controls.Add(this.panelInputID);
            this.Controls.Add(this.panelInputPassword);
            this.Controls.Add(this.panelInputRePassword);
            this.Controls.Add(this.panelInputEmail);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(969, 688);
            this.MinimumSize = new System.Drawing.Size(456, 688);
            this.Name = "formRegistry";
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelInputPassword.ResumeLayout(false);
            this.panelInputPassword.PerformLayout();
            this.panelInputRePassword.ResumeLayout(false);
            this.panelInputRePassword.PerformLayout();
            this.panelInputEmail.ResumeLayout(false);
            this.panelInputEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.TextBox textboxRePassword;
        private System.Windows.Forms.TextBox textboxEmail;
        private Evolved_Counter_Strike.uc.button buttonCheckID;
        private Evolved_Counter_Strike.uc.button buttonCheckEmail;
        private Evolved_Counter_Strike.uc.button buttonShowPassword;
        private Evolved_Counter_Strike.uc.button buttonShowRePassword;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelInputID;
        private System.Windows.Forms.Panel panelInputPassword;
        private System.Windows.Forms.Panel panelInputRePassword;
        private System.Windows.Forms.Panel panelInputEmail;
        private System.Windows.Forms.Label labelConfirm1;
        private System.Windows.Forms.Label labelConfirmKetentuanLayanan;
        private System.Windows.Forms.Label labelConfirmKebijakanPrivasi;
        private Evolved_Counter_Strike.uc.button buttonCheckBoxAccept;
        private Evolved_Counter_Strike.uc.button buttonRegistry;
        private System.Windows.Forms.PictureBox picCreateAccount;
        private Evolved_Counter_Strike.uc.button btnBackToHome;
    }
}