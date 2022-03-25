using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSR
{
    public partial class PanelWPN : UserControl
    {
        string namwpn = "";
        string costwpn = "";

        public PanelWPN()
        {
            InitializeComponent();
            picweapon.SizeMode = PictureBoxSizeMode.Zoom;
            
        }

        private void PanelWPN_MouseEnter(object sender, EventArgs e)
        {

        }

        private void costweapon_MouseClick(object sender, MouseEventArgs e)
        {
            //costweapon.ForeColor = Color.FromArgb(94, 234, 255);
        }
        public string Namewpn
        {
            
            get { return namwpn; }
            set
            {
                picweapon.Paint += new PaintEventHandler((sender2, e2) =>
                {
                    e2.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                    SizeF textSize2 = e2.Graphics.MeasureString(value, Font);
                    PointF locationToDraw2 = new PointF();
                    locationToDraw2.X = (picweapon.Width / 2) - (textSize2.Width / 2);
                    locationToDraw2.Y = 2;

                    Font drawFont = new Font("Microsoft Sans Serif", 8);

                    e2.Graphics.DrawString(value, drawFont, Brushes.White, locationToDraw2);
                });
            }
        }
        public string Costwpn
        {
            get { return costwpn; }
            set
            {
                picweapon.Paint += new PaintEventHandler((sender2, e2) =>
                {
                    e2.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                    SizeF textSize2 = e2.Graphics.MeasureString(value, Font);
                    PointF locationToDraw2 = new PointF();
                    locationToDraw2.Y = 101;
                    locationToDraw2.X = (picweapon.Width / 2) - (textSize2.Width / 2);

                    Font drawFont = new Font("Microsoft Sans Serif", 8);

                    e2.Graphics.DrawString(value, drawFont, Brushes.White, locationToDraw2);
                });
            }
        }

        public Image image
        {
            get { return picweapon.Image; }
            set
            {

                picweapon.Paint += new PaintEventHandler((sender2, e2) =>
                {
                    using (var src = new Bitmap(value))
                    using (var bmp = new Bitmap(196, 72, System.Drawing.Imaging.PixelFormat.Format32bppPArgb))


                        e2.Graphics.DrawImage(src, new Rectangle((picweapon.Width / 2) - (bmp.Width / 2), (picweapon.Height / 2) - (bmp.Height / 2), bmp.Width, bmp.Height));


                });

            }
        }

    }
}
