using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace Evolved_Counter_Strike.uc
{
    public partial class button : UserControl
    {
        
        Bitmap bmp;
        Image btnNormal, btnHover, btnActive, btnDisabled, btnNormalT, btnHoverT, btnActiveT, btnDisabledT;
        string Position1, Position2;
        public Image ImageButton { get; set; }
        public string ImagePositionNormal { get; set; }
        public string ImagePositionHover { get; set; }
        public string ImagePositionActive { get; set; }
        public string ImagePositionDisabled { get; set; }
        public string ImageTogglePositionNormal { get; set; }
        public string ImageTogglePositionHover { get; set; }
        public string ImageTogglePositionActive { get; set; }
        public string ImageTogglePositionDisabled { get; set; }
        public string SizeButton { get; set; }
        public bool Toggle { get; set; }
        public bool toggleState;
        public Image ImageButtonToggle { get; set; }
        public String TextButton { get; set; }
        public virtual System.Drawing.Font TextFont { get; set; }
        public string TextFontColorNormal { get; set; }
        public string TextFontColorHover { get; set; }
        public string TextFontColorActive { get; set; }
        public string TextFontColorDisabled { get; set; }
        public button()
        {
            InitializeComponent();
        }
        public Bitmap CropImage(Bitmap source, Rectangle section)
        {
            var bitmap = new Bitmap(section.Width, section.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
                return bitmap;
            }
        }


        public Bitmap GrayScaleFilter(Bitmap image)
        {
            Bitmap grayScale = new Bitmap(image.Width, image.Height);

            for (Int32 y = 0; y < grayScale.Height; y++)
                for (Int32 x = 0; x < grayScale.Width; x++)
                {
                    System.Drawing.Color c = image.GetPixel(x, y);

                    Int32 gs = (Int32)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);

                    grayScale.SetPixel(x, y, System.Drawing.Color.FromArgb(gs, gs, gs));
                }
            return grayScale;
        }

        // Example use:     

        private void SetTextorPic(int i)
        {

            switch (i)
            {
                case 0:
                    Position1 = ImagePositionNormal.Split(',')[0];
                    Position2 = ImagePositionNormal.Split(',')[1];
                    break;
                case 1:
                    Position1 = ImagePositionHover.Split(',')[0];
                    Position2 = ImagePositionHover.Split(',')[1];
                    break;
                case 2:
                    Position1 = ImagePositionActive.Split(',')[0];
                    Position2 = ImagePositionActive.Split(',')[1];
                    break;
                case 3:
                    Position1 = ImagePositionDisabled.Split(',')[0];
                    Position2 = ImagePositionDisabled.Split(',')[1];
                    break;
            }
            if (TextButton != null)
            {

                bmp = new Bitmap(CropImage(new Bitmap(ImageButton), new Rectangle(new Point(Int32.Parse(Position1), Int32.Parse(Position2)), new Size(Int32.Parse(SizeButton.Split(',')[0]), Int32.Parse(SizeButton.Split(',')[1])))), new Size(this.Width, this.Height));

                RectangleF rectf = new RectangleF(0, 0, bmp.Width, bmp.Height);
                Graphics g = Graphics.FromImage(bmp);
                StringFormat format = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                if (i == 0)
                {
                    g.DrawString(TextButton, TextFont, new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#" + TextFontColorNormal.Replace("#", ""))), rectf, format);
                }
                else if (i == 1)
                {
                    g.DrawString(TextButton, TextFont, new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#" + TextFontColorHover.Replace("#", ""))), rectf, format);
                }
                else if (i == 2)
                {
                    g.DrawString(TextButton, TextFont, new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#" + TextFontColorActive.Replace("#", ""))), rectf, format);
                }
                else if (i == 3)
                {
                    g.DrawString(TextButton, TextFont, new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#" + TextFontColorDisabled.Replace("#", ""))), rectf, format);
                }
                
                g.Flush();
            }
            else
            {
                bmp = CropImage(new Bitmap(ImageButton), new Rectangle(new Point(Int32.Parse(Position1), Int32.Parse(Position2)), new Size(Int32.Parse(SizeButton.Split(',')[0]), Int32.Parse(SizeButton.Split(',')[1]))));
            }
        }
        private void Button_Load(object sender, EventArgs e)
        {

            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = this.Width;
            img.Height = this.Height;

            if (ImageButton != null)
            {
                if (ImagePositionNormal != null | ImagePositionHover != null | ImagePositionActive != null)
                {

                    SetTextorPic(0);
                    btnNormal = (Image)bmp;

                    SetTextorPic(1);
                    btnHover = (Image)bmp;

                    SetTextorPic(2);
                    btnActive = (Image)bmp;

                    if (ImagePositionDisabled == null || ImagePositionDisabled == "")
                    {
                        SetTextorPic(0);
                        btnDisabled = (Image)GrayScaleFilter(bmp);
                    }
                    else
                    {
                        SetTextorPic(3);
                        btnDisabled = (Image)bmp;

                    }


                    if (this.Enabled == false)
                        img.Image = btnDisabled;
                    else
                        img.Image = btnNormal;
                }
            }
            if (Toggle)
            {
                if (ImageButtonToggle != null)
                {
                    if (ImageTogglePositionNormal != null)
                    {
                        btnNormalT = (Image)CropImage(new Bitmap(ImageButtonToggle), new Rectangle(new Point(Int32.Parse(ImageTogglePositionNormal.Split(',')[0]), Int32.Parse(ImageTogglePositionNormal.Split(',')[1])), new Size(Int32.Parse(SizeButton.Split(',')[0]), Int32.Parse(SizeButton.Split(',')[1]))));

                    }
                    else
                        btnNormalT = (Image)CropImage(new Bitmap(ImageButtonToggle), new Rectangle(new Point(Int32.Parse(ImagePositionNormal.Split(',')[0]), Int32.Parse(ImagePositionNormal.Split(',')[1])), new Size(Int32.Parse(SizeButton.Split(',')[0]), Int32.Parse(SizeButton.Split(',')[1]))));

                    if (ImageTogglePositionHover != null)
                        btnHoverT = (Image)CropImage(new Bitmap(ImageButtonToggle), new Rectangle(new Point(Int32.Parse(ImageTogglePositionHover.Split(',')[0]), Int32.Parse(ImageTogglePositionHover.Split(',')[1])), new Size(Int32.Parse(SizeButton.Split(',')[0]), Int32.Parse(SizeButton.Split(',')[1]))));
                    else
                        btnHoverT = (Image)CropImage(new Bitmap(ImageButtonToggle), new Rectangle(new Point(Int32.Parse(ImagePositionHover.Split(',')[0]), Int32.Parse(ImagePositionHover.Split(',')[1])), new Size(Int32.Parse(SizeButton.Split(',')[0]), Int32.Parse(SizeButton.Split(',')[1]))));


                    if (ImageTogglePositionActive != null)
                        btnActiveT = (Image)CropImage(new Bitmap(ImageButtonToggle), new Rectangle(new Point(Int32.Parse(ImageTogglePositionActive.Split(',')[0]), Int32.Parse(ImageTogglePositionActive.Split(',')[1])), new Size(Int32.Parse(SizeButton.Split(',')[0]), Int32.Parse(SizeButton.Split(',')[1]))));
                    else
                        btnActiveT = (Image)CropImage(new Bitmap(ImageButtonToggle), new Rectangle(new Point(Int32.Parse(ImagePositionActive.Split(',')[0]), Int32.Parse(ImagePositionActive.Split(',')[1])), new Size(Int32.Parse(SizeButton.Split(',')[0]), Int32.Parse(SizeButton.Split(',')[1]))));




                    if (ImageTogglePositionDisabled == null && ImagePositionDisabled == null)
                        btnDisabledT = (Image)GrayScaleFilter(CropImage(new Bitmap(ImageButtonToggle), new Rectangle(new Point(Int32.Parse(ImagePositionActive.Split(',')[0]), Int32.Parse(ImagePositionActive.Split(',')[1])), new Size(Int32.Parse(SizeButton.Split(',')[0]), Int32.Parse(SizeButton.Split(',')[1])))));
                    else if (ImageTogglePositionActive != null)
                        btnDisabledT = (Image)CropImage(new Bitmap(ImageButtonToggle), new Rectangle(new Point(Int32.Parse(ImageTogglePositionDisabled.Split(',')[0]), Int32.Parse(ImageTogglePositionDisabled.Split(',')[1])), new Size(Int32.Parse(SizeButton.Split(',')[0]), Int32.Parse(SizeButton.Split(',')[1]))));
                    else
                        btnDisabledT = (Image)CropImage(new Bitmap(ImageButtonToggle), new Rectangle(new Point(Int32.Parse(ImagePositionDisabled.Split(',')[0]), Int32.Parse(ImagePositionDisabled.Split(',')[1])), new Size(Int32.Parse(SizeButton.Split(',')[0]), Int32.Parse(SizeButton.Split(',')[1]))));

                    if (this.Enabled == false)
                        img2.Image = btnDisabledT;
                    else
                        img2.Image = btnNormalT;

                    img2.Width = this.Width;
                    img2.Height = img.Height;
                    img2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                img2.Visible = toggleState;
                img2.Enabled = toggleState;
            }
        }

        private void img_MouseEnter(object sender, EventArgs e)
        {
            img.Image = btnHover;
            this.OnMouseEnter(e);
        }
        private void img_MouseLeave(object sender, EventArgs e)
        {
            img.Image = btnNormal;
            this.OnMouseLeave(e);
        }
        private void img_MouseDown(object sender, MouseEventArgs e)
        {
            img.Image = btnActive;
            this.OnMouseDown(e);
        }
        private void img_MouseUp(object sender, MouseEventArgs e)
        {
            img.Image = btnHover;
            this.OnMouseUp(e);
        }
        private void img_Click(object sender, EventArgs e)
        {
            this.OnClick(e);

        }
        private void Img_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled == false)
                img.Image = btnDisabled;
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
        private void img_MouseEnter2(object sender, EventArgs e)
        {
            img2.Image = btnHoverT;
            this.OnMouseEnter(e);
        }
        private void img_MouseLeave2(object sender, EventArgs e)
        {
            img2.Image = btnNormalT;
            this.OnMouseLeave(e);
        }
        private void img_MouseDown2(object sender, MouseEventArgs e)
        {
            img2.Image = btnActiveT;
            this.OnMouseDown(e);
        }
        private void img_MouseUp2(object sender, MouseEventArgs e)
        {
            img2.Image = btnHoverT;
            this.OnMouseUp(e);
        }
        private void img_Click2(object sender, EventArgs e)
        {
            this.OnClick(e);

        }
        private void Img_EnabledChanged2(object sender, EventArgs e)
        {
            if (this.Enabled == false)
                img2.Image = btnDisabledT;
        }
        private void img_MouseClick2(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
            if (Toggle)
            {
                toggleState = !toggleState;
                img2.Visible = toggleState;
                img2.Enabled = toggleState;
            }
        }
        private void img_DoubleClick2(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }
        private void img_MouseDoubleClick2(object sender, MouseEventArgs e)
        {
            this.OnMouseDoubleClick(e);
        }


    }


}