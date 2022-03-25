namespace Evolved_Counter_Strike.uc
{
    partial class button
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.img = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            this.SuspendLayout();
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(0, 0);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(100, 50);
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            this.img.EnabledChanged += new System.EventHandler(this.Img_EnabledChanged);
            this.img.Click += new System.EventHandler(this.img_Click);
            this.img.DoubleClick += new System.EventHandler(this.img_DoubleClick);
            this.img.MouseClick += new System.Windows.Forms.MouseEventHandler(this.img_MouseClick);
            this.img.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.img_MouseDoubleClick);
            this.img.MouseDown += new System.Windows.Forms.MouseEventHandler(this.img_MouseDown);
            this.img.MouseEnter += new System.EventHandler(this.img_MouseEnter);
            this.img.MouseLeave += new System.EventHandler(this.img_MouseLeave);
            this.img.MouseUp += new System.Windows.Forms.MouseEventHandler(this.img_MouseUp);
            // 
            // img2
            // 
            this.img2.Location = new System.Drawing.Point(0, 0);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(100, 50);
            this.img2.TabIndex = 2;
            this.img2.TabStop = false;
            this.img2.Visible = false;
            this.img2.EnabledChanged += new System.EventHandler(this.Img_EnabledChanged2);
            this.img2.Click += new System.EventHandler(this.img_Click2);
            this.img2.DoubleClick += new System.EventHandler(this.img_DoubleClick2);
            this.img2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.img_MouseClick2);
            this.img2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.img_MouseDoubleClick2);
            this.img2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.img_MouseDown2);
            this.img2.MouseEnter += new System.EventHandler(this.img_MouseEnter2);
            this.img2.MouseLeave += new System.EventHandler(this.img_MouseLeave2);
            this.img2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.img_MouseUp2);
            // 
            // button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img);
            this.Name = "button";
            this.Load += new System.EventHandler(this.Button_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.PictureBox img2;
    }
}
