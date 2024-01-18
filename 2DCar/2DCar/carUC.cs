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
                new Point(0,35),
                new Point(5,95),
                new Point(210,95),
                new Point(200,45),
                new Point(200,45),
                new Point(130,0),
                new Point(50,0),
            };

            

            g.FillPolygon(Brushes.Orange,points);
            //g.FillEllipse(Brushes.Black, 50, 115, 35, 35);
            //g.FillEllipse(Brushes.Black, 180, 115, 35, 35);

            g.DrawEllipse(new Pen(Color.Black,3), 20, 75, 35, 35);
            g.DrawEllipse(new Pen(Color.Black,2), 25, 80, 25, 25);
            g.FillEllipse(Brushes.Black,30,85,15,15);

            g.DrawEllipse(new Pen(Color.Black,3), 140, 75, 35, 35);
            g.DrawEllipse(new Pen(Color.Black,2), 145, 80, 25, 25);
            g.FillEllipse(Brushes.Black,150,85,15,15);

            g.FillRectangle(Brushes.White, 50, 20, 20, 25);
            g.FillRectangle(Brushes.White, 80, 20, 20, 25);
            g.FillRectangle(Brushes.White, 110, 20, 20, 25);
        }
    }
}
