using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//using System.Timers;
using System.Windows.Forms;

namespace RippleButton
{
    class CustomBtn:Button
    {

        private Graphics g;
        public Timer time;
        private int interval=10;
        //private int radius=0;
        private Point cursorPoint;
        private List<rippleSign> ripples = new List<rippleSign>();

        public CustomBtn() {
            time = new Timer();
            time.Interval = interval;
            time.Tick += WaveRadius;
            Width = 165;
            Height = 175;
            Click += OnClick;
            MouseDown += mouseDown;
        }

        private void OnClick(Object s,EventArgs e) {
            time.Start();
        }

        private void mouseDown(Object s,MouseEventArgs e) {
            cursorPoint.X = e.X;
            cursorPoint.Y = e.Y;
            rippleSign obj = new rippleSign();
            obj.radius = 5;
            obj.brush = new SolidBrush(Color.FromArgb(150,Color.White));
            obj.timeLimit = interval;
            obj.X = e.X;
            obj.Y = e.Y;
            ripples.Add(obj);
        }

        private void WaveRadius(Object s,EventArgs e) {
            for(int i= 0;i<ripples.Count;i++) {
                if (ripples[i].radius/2 >= Width+(Height/2) )
                    ripples.Remove(ripples[i]);
                else {
                    
                    ripples[i].radius += 20;
                }
            }
            Invalidate();
            if (ripples.Count<=0) {
                time.Stop();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            g = pevent.Graphics;
            //Pen pen = new Pen(Color.White,2);
            //g.DrawEllipse(pen,(Width/2)-radius/2,(Height/2)-radius/2,radius,radius);

            String text = "Welcome Friday";
            Font font = new Font("Arial",15);
            Point p = new Point((Width/2)-text.Length*5,(Height/2)-2);
            Brush tb = new SolidBrush(Color.Green);

            

            Brush b = new SolidBrush(Color.FromArgb(150,Color.White));
            foreach (rippleSign ripple in ripples) {
                g.FillEllipse(b, (ripple.X) - ripple.radius / 2, (ripple.Y) - ripple.radius / 2, ripple.radius, ripple.radius);
                ripple.brush.Dispose();
            }
            g.DrawString(text, font, tb, p);
        }
    }
}
