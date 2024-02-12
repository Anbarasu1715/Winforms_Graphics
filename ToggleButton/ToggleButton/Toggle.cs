using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ToggleButton
{
    class Toggle : Button
    {


        private Graphics graphics;

        public Toggle() {
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;

            GraphicsPath gpath = new GraphicsPath();

            //int radius = 75;
            //Height = radius;
            //this.Width = 400;
            //BackColor = Color.White;
            //Rectangle leftRec = new Rectangle(0,0,radius,radius);
            //Rectangle rightRec = new Rectangle(Width-radius,0,radius,radius);

            //gpath.AddArc(leftRec,90,180);
            //gpath.AddArc(rightRec, 270,180);
            
            //Brush brush = new SolidBrush(Color.Green);
            //graphics.FillPath(brush,gpath);
        }

    }


}
