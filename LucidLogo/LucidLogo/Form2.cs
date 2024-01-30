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

namespace LucidLogo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Graphics g;

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            GraphicsPath path = new GraphicsPath();

            Rectangle rec1 = new Rectangle(15,15,100,150);
            Rectangle rec2 = new Rectangle(200,250,100,150);

            Brush brush = new SolidBrush(Color.White);
            Pen pen = new Pen(Color.Blue,3);

            g.FillRectangle(new SolidBrush(Color.Orange),rec1);
            path.AddArc(rec1,180,-90);
            path.AddLine(new Point(115, 165), new Point(115, 15));
            path.AddLine(new Point(115, 15), new Point(15, 15));
            //path.AddArc(rec2,0,180);
            //path.CloseFigure();
            //g.DrawPath(pen,path);
            g.FillPath(brush,path);

        }
    }
}
