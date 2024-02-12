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

        private Graphics graphics;

        
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

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;

            GraphicsPath path = new GraphicsPath();

            Rectangle leftRec = new Rectangle(0, 0, Height, Height);
            Rectangle rightRec = new Rectangle(Width - Height, 0, Height, Height);

            path.AddArc(leftRec, 90, 180);
            path.AddArc(rightRec, 270, 180);

            Brush brush = new SolidBrush(Color.DarkGray);

            graphics.FillPath(brush, path);
            pictureBoxExit.BringToFront();
            pictureBoxExit.BackColor = Color.DarkGray;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
