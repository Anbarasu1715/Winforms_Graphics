using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DCar
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            Graphics g = e.Graphics;


            g.FillRectangle(Brushes.Blue, 50, 30, 100, 50);



            Point[] roofPoints = { new Point(50, 30), new Point(100, 30), new Point(125, 10), new Point(25, 10) };
            g.FillPolygon(Brushes.Blue, roofPoints);


            g.FillEllipse(Brushes.Black, 60, 70, 20, 20);
            g.FillEllipse(Brushes.Black, 120, 70, 20, 20);
        }
    }
}
