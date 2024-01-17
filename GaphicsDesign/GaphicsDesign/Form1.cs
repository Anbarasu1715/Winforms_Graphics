using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaphicsDesign
{
    //public partial class Form1 : Form
    //{
    //    public Form1()
    //    {
    //        InitializeComponent();
    //    }
    //    private Graphics g;
    //    private void Form1_Paint(object sender, PaintEventArgs e)
    //    {

    //        g = e.Graphics;
    //        Pen pen = new Pen(Color.Orange);
    //        Brush brush = new SolidBrush(Color.Orange);
    //        g.DrawRectangle(pen,50,50,200,200);
    //        g.FillRectangle(brush,260,this.Height-200,200,200);

    //    }
    //}

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Create a graphics path



            GraphicsPath path = new GraphicsPath();

            // Add points to the path (including the curved segment)
            path.AddLine(50, 50, 150, 50);
            path.AddLine(150, 50, 200, 100);

            // Add a curved segment (Bezier curve)
            Point[] bezierPoints = { new Point(200, 100), new Point(150, 150), new Point(100, 100) };
            path.AddBezier(bezierPoints[0], bezierPoints[1], bezierPoints[2], bezierPoints[0]);

            // Draw the filled polygon
            e.Graphics.FillPolygon(Brushes.Blue, path.PathPoints);

            // Draw the polygon outline
            e.Graphics.DrawPolygon(Pens.Black, path.PathPoints);
        }
    }

}
