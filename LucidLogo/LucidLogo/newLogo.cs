using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucidLogo
{
    public partial class newLogo : UserControl
    {
        public newLogo()
        {
            InitializeComponent();
        }

        private Graphics g;
        private LogoTransUC obj;

        private void newLogo_Paint(object sender, PaintEventArgs e)
        {
            obj?.Dispose();
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(Color.FromArgb(13, 98, 177));
            Brush brush1 = new SolidBrush(Color.FromArgb(58, 184, 240));

            if (obj==null)
                obj = new LogoTransUC();

            DoubleBuffered = true;

            int logoSize = Math.Min(obj.Height,obj.Width);
            FontStyle fontStyle = FontStyle.Italic | FontStyle.Bold;
            Font font = new Font(new FontFamily("Segoe UI"), (int)(logoSize/2.5),fontStyle);
            Font font1 = new Font(new FontFamily("Segoe UI"), (int)(logoSize / 3.5), fontStyle);

            g.DrawString("Lucid",font,brush,new Point(((obj.Width*Width)/960),-45));
            g.DrawString("Imaging",font1,brush1,new Point(((470*Width)/960),90));

        }
    }
}
