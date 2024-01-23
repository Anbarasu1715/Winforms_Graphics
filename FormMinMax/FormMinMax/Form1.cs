using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMinMax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Location = new Point(625,340);
            formSize = this.Size;

            Btn1 = new Rectangle(button1.Location,button1.Size);
            Btn2 = new Rectangle(button2.Location,button2.Size);
            Btn3 = new Rectangle(button3.Location,button3.Size);
            Btn4 = new Rectangle(button4.Location,button4.Size);
            Btn5 = new Rectangle(button5.Location,button5.Size);

            this.Focus();
        }

        private Point minPoint = new Point(625,340);
        private Point maxPoint = new Point(0,0);
        private Size minSize = new Size(625,355);
        private Size maxSize = new Size(1936,1066);

        private Size formSize;
        private MinMaxControl obj;
        private string BtnText = "Maximize";

        private Rectangle Btn1;
        private Rectangle Btn2;
        private Rectangle Btn3;
        private Rectangle Btn4;
        private Rectangle Btn5;


        private void Form1_Move(object sender, EventArgs e)
        {
            // textBox1.Text = Location+"    "+Size;
            obj?.Dispose();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(button1, Btn1);
            resizeControl(button2, Btn2);
            resizeControl(button3, Btn3);
            resizeControl(button4, Btn4);
            resizeControl(button5, Btn5);
        }

        private void resizeControl(Control control, Rectangle rec)
        {
            float XRatio = (float)this.Size.Width / (float)formSize.Width;
            float YRatio = (float)this.Size.Height / (float)formSize.Height;

            int newX = (int)(rec.X * XRatio);
            int newY = (int)(rec.Y * YRatio);

            int newWidth = (int)(rec.Width * XRatio);
            int newHeight = (int)(rec.Height * YRatio);

            control.Location = new System.Drawing.Point(newX, newY);
            control.Size = new System.Drawing.Size(newWidth, newHeight);
        }

        private void CheckSize(Object sender,EventArgs e)
        {
            switch ((sender as Button).Text) {
                case "Maximize":
                    Location = maxPoint;
                    Size = maxSize;
                    BtnText = "Minimize";
                    obj?.Dispose();
                    break;
                case "Minimize":
                    Location = minPoint;
                    Size = minSize;
                    BtnText = "Maximize";
                    obj?.Dispose();
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Point ClickedLocation = new Point(e.Location.X, e.Location.Y);

            obj?.Dispose();

            if (e.Button==MouseButtons.Right) {
                obj = new MinMaxControl(BtnText);
                

                if (ClickedLocation.X + obj.Width >= Width-25)
                {
                    ClickedLocation.X = ClickedLocation.X - obj.Width-15;
                }

                if ((ClickedLocation.Y+obj.Height) >= Height-46)
                {
                    ClickedLocation.Y -= obj.Height+10;
                }

                obj.Location = PointToScreen(new Point(ClickedLocation.X, ClickedLocation.Y));
                obj.Show();
                obj.OnBtnClick += CheckSize;   
            }
        }
    }
}