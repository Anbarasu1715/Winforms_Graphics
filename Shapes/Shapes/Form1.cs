using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SelectionBox box;
        private string selectedShape;
        private Point cursorPoint;
        private Point movingPoint;
        private Rectangle rec;
        private bool isDragging=false;
        private Graphics g;

        private List<Rectangle> rectangles = new List<Rectangle>();

        private void DrawShape(Object sender,string text) {
            box?.Dispose();
            selectedShape = text;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            box?.Dispose();
            if (e.Button==MouseButtons.Right) {
                
                Point CurrentClick = (new Point(e.X,e.Y));

                box = new SelectionBox();

                if (CurrentClick.X+box.Width>=Width-17)
                {
                    CurrentClick.X = CurrentClick.X - box.Width;
                }
                if (CurrentClick.Y+box.Height>=Height-40) {
                    CurrentClick.Y = CurrentClick.Y - box.Height;
                }

                textBox1.Text = "" + CurrentClick + "    " ;

                box.Location = PointToScreen(CurrentClick);
                box.OnEventclick += DrawShape;
                box.Show();
            }
            else if (e.Button==MouseButtons.Left)
            {
                cursorPoint = e.Location;
                Invalidate();
                isDragging = true;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (selectedShape!=null)
            {

                g = e.Graphics;
                Brush brush = new SolidBrush(Color.Green);

                switch (selectedShape) {
                    case "Circle":
                        if (isDragging == false) {
                            rec = new Rectangle();
                        }
                        else if (isDragging)
                        {
                            int width = movingPoint.X - cursorPoint.X;
                            int height = movingPoint.Y - cursorPoint.Y;
                            int size = Math.Min(width, height);

                            if (width < 0 && height < 0)
                            {
                                rec.Location = new Point(movingPoint.X, movingPoint.Y);
                                //size = Math.Max(cursorPoint.X - movingPoint.X, cursorPoint.Y - movingPoint.Y);
                                rec.Size = new Size(cursorPoint.X - movingPoint.X, cursorPoint.Y - movingPoint.Y);
                            }
                            else if (width < 0 && height > 0)
                            {
                                rec.Location = new Point(movingPoint.X, cursorPoint.Y);
                                //size = Math.Max(cursorPoint.X - movingPoint.X, movingPoint.Y - cursorPoint.Y);
                                rec.Size = new Size(cursorPoint.X - movingPoint.X, movingPoint.Y - cursorPoint.Y);
                            }
                            else if (width > 0 && height < 0)
                            {
                                rec.Location = new Point(cursorPoint.X, movingPoint.Y);
                                //size = Math.Max(movingPoint.X - cursorPoint.X, cursorPoint.Y - movingPoint.Y);
                                rec.Size = new Size(movingPoint.X - cursorPoint.X, cursorPoint.Y - movingPoint.Y);
                            }
                            else if (width > 0 && height > 0)
                            {
                                rec.Location = cursorPoint;
                                //size = Math.Min(width,height);
                                rec.Size = new Size(size, size);
                            }

                            //rec.Location = cursorPoint;
                            //rec.Size = new Size(size,size);
                            g.FillRectangle(brush, rec);
                        }
                        break;
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left) {
                movingPoint = e.Location;
                isDragging = true;
                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            rectangles.Add(rec);
        }
    }
}
