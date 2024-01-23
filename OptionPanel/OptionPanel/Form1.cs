using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Controls obj;
        private Graphics g;
        private string shape;

        private void CreateShape(Object sender,string s) {
            obj?.Dispose();
            shape = s;
            panel.Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point ClickedLocation =new Point(e.Location.X, e.Location.Y);
            ClickedLocation = PointToScreen(ClickedLocation);

            obj?.Dispose();

            if (e.Button == MouseButtons.Right)
            {
                obj = new Controls();

                if (ClickedLocation.X + obj.Width >= Width)
                {
                    ClickedLocation.X = ClickedLocation.X - obj.Width;
                }

                //if (ClickedLocation.X <= panel.Width)
                //{
                //    ClickedLocation.X = panel.Width+15;
                //}

                if (ClickedLocation.Y + obj.Height >= Height)
                {
                    ClickedLocation.Y -= obj.Height;
                }

                obj.Location = new Point(ClickedLocation.X, ClickedLocation.Y);
                obj.Show();
                obj.OnBtnClick += CreateShape;
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = {
                new Point((panel.Width/2)-75,(panel.Height/2)),
                new Point((panel.Width/2)+75,(panel.Height/2)),
                new Point((panel.Width/2),(panel.Height/2)-125),
            };


            g?.Dispose();
            g = e.Graphics;
            Brush brush = new SolidBrush(Color.Blue);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            //GraphicsPath path = new GraphicsPath();
            

            int shapeWidth = 150,shapeHeight=150;
            switch (shape)
            {
                case "Rectangle":
                    g.FillRectangle(brush,(panel.Width/2)+20-shapeWidth,(panel.Height/2)+20-shapeHeight,shapeWidth+70,shapeHeight);
                    break;
                case "Circle":
                    g.FillEllipse(brush, (panel.Width / 2)+50 - shapeWidth, (panel.Height / 2)+20 - shapeHeight, shapeWidth, shapeHeight);
                    break;
                case "Square":
                    g.FillRectangle(brush, (panel.Width / 2)+50 - shapeWidth, (panel.Height / 2)+20 - shapeHeight, shapeWidth, shapeHeight);
                    break;
                case "Triangle":
                    g.FillPolygon(Brushes.Blue, points);
                    break;
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            obj?.Dispose();
        }
    }
}
