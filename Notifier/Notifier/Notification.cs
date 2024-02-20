using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Notifier
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Magenta;
            this.BackColor = Color.Magenta;
            OpacityTimer = new Timer();
            OpacityTimer.Interval = 50;
            OpacityTimer.Tick += ReduceOpacity;
        }

        public Notification(int radius)
        {
            InitializeComponent();
            this.TransparencyKey = Color.Magenta;
            this.BackColor = Color.Magenta;
            CornerRadius = radius; 
        }


        private Graphics graphics;
        private int CornerRadius;
        public EventHandler<EventArgs> OnExit;
        public EventHandler<EventArgs> OnDisplay;
        private MsgBox obj;

        public Position DisplayPosition
        {
            get;
            set;
        }

        public enum Position
        {
            Left,
            Right
        }

        public void SetText(string text) {
            label1.Text = text;
        }

        public int labelWidth() {
            return label1.Width;
        }

        public Font labelFont() {
            return label1.Font;
        }

        public void SetHeight(int h,int Width) {
            label1.Height = (h)*label1.Height;
            this.Height += label1.Height-30;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;

            GraphicsPath path = new GraphicsPath();

           
            AddRoundRect(path,0,0,Width,Height, 20);

            Brush brush = new SolidBrush(Color.DarkGray);

            graphics.FillPath(brush, path);
            pictureBoxExit.BringToFront();

            graphics.DrawLine(new Pen(Color.White, 3), 7, 30, Width-7, 30);

            pictureBoxExit.BackColor = Color.DarkGray;
        }

        private void AddRoundRect(GraphicsPath path, int x, int y, int width, int height, int cornerRadius)
        {
            path.Reset();

            RectangleF rect = new RectangleF(x, y, width, height);

            float radius = cornerRadius * 2;

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); 
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); 
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90); 
            path.CloseFigure();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            OnExit?.Invoke(this,e);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OnDisplay?.Invoke(this, e);
            this.Close();
        }

        private double OpacityIncrement = 0.1;
        private double TargetOpacity = 0.01;
        private Timer OpacityTimer;

        private void ReduceOpacity(object sender, EventArgs e)
        {
            if (this.Opacity > TargetOpacity)
            {
                this.Opacity -= OpacityIncrement;
            }
            else
            {
                OpacityTimer.Stop();
                this.Close();
            }
        }

        private void Notification_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            OpacityTimer.Start();
        }
    }
}
