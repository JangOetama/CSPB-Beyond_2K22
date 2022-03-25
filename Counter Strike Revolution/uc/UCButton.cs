using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomButton
{
    public partial class UCButton : UserControl
    {

            
       public virtual System.Drawing.Font font { get; set; }
        public String text { get; set; }
        public Image ImgRes { get; set; }

        public bool Toggle { get; set; }
        public bool toggleState;
        public Image ImgResToggle { get; set; }


        public UCButton()
        {
            InitializeComponent();
        }
        private void UCButton_Load(object sender, EventArgs e)
        {
          
            img.Paint += new PaintEventHandler((sender2, e2) =>
             {
                 e2.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                 SizeF textSize3 = e2.Graphics.MeasureString(text, font);
                 PointF locationToDraw3 = new PointF();
                 locationToDraw3.X = (img.Width / 2) - (textSize3.Width / 2);
                 locationToDraw3.Y = (((img.Height / 3) * 5) / 2) - (textSize3.Height / 2);

                 SizeF textSize = e2.Graphics.MeasureString(text, font);
                 PointF locationToDraw = new PointF();
                 locationToDraw.X = (img.Width / 2) - (textSize.Width / 2);
                 locationToDraw.Y = ((img.Height / 3) / 2) - (textSize.Height / 2);


                 SizeF textSize2 = e2.Graphics.MeasureString(text, font);
                 PointF locationToDraw2 = new PointF();
                 locationToDraw2.X = (img.Width / 2) - (textSize2.Width / 2);
                 locationToDraw2.Y = (img.Height / 2) - (textSize2.Height / 2);

                 e2.Graphics.DrawString(text, font, Brushes.White, locationToDraw);

                 e2.Graphics.DrawString(text, font, Brushes.White, locationToDraw3);

    
             });



            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = this.Width;
            if (ImgRes != null)
            {
                img.Image = ImgRes;
                img.Height = (this.Height * ImgRes.Height) / (ImgRes.Height / 3);
            }
            if (Toggle)
            {
                if (ImgResToggle != null)
                    img2.Image = ImgResToggle;
                img2.Width = this.Width;
                img2.SizeMode = PictureBoxSizeMode.StretchImage;
                img2.Height = img.Height;
            }
        }
        private void setState(int i)
        {
            switch (i)
            {
                case 0:
                    img.Top = 0;
                    img2.Top = 0;
                    break;
                case 1:
                    img.Top = (img.Height / 3) * -1;
                    img2.Top = (img.Height / 3) * -1;
                    break;
                case 2:
                    img.Top = (img.Height / 3) * -2;
                    img2.Top = (img.Height / 3) * -2;
                    break;
            }
        }
        private void img_MouseEnter(object sender, EventArgs e)
        {
            setState(1);
            this.OnMouseEnter(e);
        }
        private void img_MouseLeave(object sender, EventArgs e)
        {
            setState(0);
            this.OnMouseLeave(e);
        }
        private void img_MouseDown(object sender, MouseEventArgs e)
        {
            setState(2); 
            this.OnMouseDown(e);
        }
        private void img_MouseUp(object sender, MouseEventArgs e)
        {
            setState(1);
            this.OnMouseUp(e);
        }
        private void img_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void img_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
            if (Toggle)
            {
                toggleState = !toggleState;
                img2.Visible = toggleState;
                img2.Enabled = toggleState;
            }
        }
        private void img_DoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }
        private void img_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.OnMouseDoubleClick(e);
        }
    }
}
