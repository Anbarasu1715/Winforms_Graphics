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
        }

        public Notification(int radius)
        {
            InitializeComponent();
            this.TransparencyKey = Color.Magenta;
            this.BackColor = Color.Magenta;
            Cornerradius = radius; 
        }


        private Graphics graphics;
        private int Cornerradius;
        public EventHandler<EventArgs> OnExit;
        
        [Browsable(true)]
        [Category("Layout")]
        [Description("Specifies the display position of the notification.")]
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
            if (text.Length > 25)
                label1.Height = 100;
            label1.Text = text;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;

            GraphicsPath path = new GraphicsPath();

            //Rectangle leftRec = new Rectangle(0, 0, Height, Height);
            //Rectangle rightRec = new Rectangle(Width - Height, 0, Height, Height);

            //path.AddArc(leftRec, 90, 180);
            //path.AddArc(rightRec, 270, 180);
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
    }
}
