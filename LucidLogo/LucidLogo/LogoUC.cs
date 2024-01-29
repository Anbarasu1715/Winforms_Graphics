using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LucidLogo
{
    public partial class LogoUC : UserControl
    {
        private Graphics g;
        private Rectangle formSize;

        public LogoUC()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(13, 98, 177);
            formSize = new Rectangle(Location, Size);
        }

        private void LogoUC_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(13, 98, 177);
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            int rX = (Width / 2) - 25;
            int rY = (Height / 2) - 15;
            int rWidth = Width * 2;
            int rHeight = Height * 2;

            int lX = 10 + (-Width) - (Width / 2);
            int lY = (Height / 2) - 20;
            int lWidth = 20 + (Width * 2);
            int lHeight = Height * 2;

            Rectangle RightRec = new Rectangle(rX, rY, rWidth, rHeight);
            Rectangle LeftRec = new Rectangle(lX, lY, lWidth, lHeight);

            Brush brush = new SolidBrush(Color.White);

            
            Point[] LeftPoints = {
                new Point(-1, (Height / 2) + 10),
                new Point((Width / 2) + 1, 30),
                new Point((Width / 2) + 1, -1),
                new Point(-1, -1)
            };
           
            Point[] RightPoints = {
                new Point((Width / 2) - 1, -1),
                new Point(Width, -1),
                new Point(Width, (Height / 2) + 10),
                new Point((Width / 2) - 1, 30)
            };

            g.FillPolygon(brush, LeftPoints);
            g.FillPolygon(brush, RightPoints);

            g.FillEllipse(brush, RightRec);
            g.FillEllipse(brush, LeftRec);

            
            Point[] sticks = {
                new Point(22 * Width / 250, 125 * Height / 250),
                new Point(139 * Width / 250, 122 * Height / 250),
                new Point(86 * Width / 250, 65 * Height / 250),
                new Point(144 * Width / 250, 117 * Height / 250),
                new Point(149 * Width / 250, 45 * Height / 250),
                new Point(153 * Width / 250, 117 * Height / 250),
                new Point(188 * Width / 250, 86 * Height / 250),
                new Point(158 * Width / 250, 121 * Height / 250),
                new Point(227 * Width / 250, 125 * Height / 250),
                new Point(157 * Width / 250, 129 * Height / 250),
                new Point(204 * Width / 250, 180 * Height / 250),
                new Point(152 * Width / 250, 129 * Height / 250),
                new Point(204 * Width / 250, 180 * Height / 250),
                new Point(152 * Width / 250, 135 * Height / 250),
                new Point(148 * Width / 250, 270 * Height / 250),
                new Point(145 * Width / 250, 134 * Height / 250),
                new Point(57 * Width / 250, 216 * Height / 250),
                new Point(139 * Width / 250, 129 * Height / 250),
            };
            g.FillPolygon(brush, sticks);
        }

        private void LogoUC_Resize(object sender, EventArgs e)
        {
            
            formSize = new Rectangle(Location, Size);
            Invalidate(); 
        }

        private void LogoUC_MouseMove(object sender, MouseEventArgs e)
        {
            //textBox1.Text = e.Location+"";
        }
    }
}
