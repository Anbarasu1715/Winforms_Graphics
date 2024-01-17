using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace _2DCar
{
    public partial class carUC : UserControl
    {
        public carUC()
        {
            InitializeComponent();
        }

        private Graphics g;

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            g = e.Graphics;
            GraphicsPath path = new GraphicsPath();

            Point[] points = {
                new Point(30,75),
                new Point(30,135),
                new Point(250,135),
                new Point(250,75),
                new Point(220,75),
                new Point(170,30),
                new Point(90,30),
            };

            

            g.FillPolygon(Brushes.Orange,points);
            g.FillEllipse(Brushes.Black, 50, 115, 35, 35);
            g.FillEllipse(Brushes.Black, 180, 115, 35, 35);
            g.FillRectangle(Brushes.White, 90, 50, 20, 25);
            g.FillRectangle(Brushes.White, 120, 50, 20, 25);
            g.FillRectangle(Brushes.White, 150, 50, 20, 25);
        }
    }
}
