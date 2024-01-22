using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class pb : UserControl
    {
        public pb()
        {
            InitializeComponent();
        }

        private Graphics g;

        private void pb_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            //int x = (int)(Width * 0.1)/2;
            //int y = (int)(Height * 0.1)/2;
            
            //int width = Width - (2*x);
            //int height = Height - (2*y);
            Brush brush = new SolidBrush(Color.Gray);
            Brush innerBrush = new SolidBrush(Color.White);
            Pen bar = new Pen(Color.Green,17);
            bar.StartCap = bar.EndCap = LineCap.Round;
            g.FillEllipse(brush,0,0,Width,Height);
            g.DrawArc(bar,17/2, 17/2.0f, Width-17,Height-17,270,270);
            g.FillEllipse(innerBrush,17,17,Width-(2*17),Height-(2*17));
            g.Dispose();
        }
    }
}
