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

    public abstract class Shape {
        protected Rectangle rectangle;


        public abstract void Draw(Graphics g,Brush brush);
    }

    public class EllipseShape : Shape {

        public EllipseShape(Rectangle rec) {
            rectangle = rec;
        }

        public override void Draw(Graphics g, Brush brush)
        {
            g.FillEllipse(brush,rectangle);
        }
    }

    public class RectangleShape : Shape {

        public RectangleShape(Rectangle rec) {
            rectangle = rec;
        }

        public override void Draw(Graphics g, Brush brush)
        {
            g.FillRectangle(brush,rectangle);
        }
    }

    public class TriangleShape : Shape {
        private Point[] points;

        public TriangleShape(Point[] points) {
            this.points = points;
        }

        public override void Draw(Graphics g, Brush brush)
        {
            g.FillPolygon(brush,points);
        }
    }

    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        private SelectionBox box;
        private string selectedShape;
        private Point cursorPoint;
        private Point movingPoint;
        private Rectangle rec;
        private bool isDragging=false;
        private Graphics g;
        private Point[] points=new Point[3];

        private List<Shape> shapes = new List<Shape>();

        private void DrawShape(Object sender,string text) {
            box?.Dispose();
            selectedShape = text;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (selectedShape!=null)
            {

                g = e.Graphics;
                Brush brush = new SolidBrush(Color.Green);
                DoubleBuffered = true;

                switch (selectedShape) {
                    case "Circle":
                        if (isDragging == false) {
                            rec = new Rectangle();
                            
                        }
                        else if (isDragging)
                        {
                            rec.Location = cursorPoint;
                            //int size = Math.Max(movingPoint.X - cursorPoint.X, movingPoint.Y - cursorPoint.Y);
                            rec.Size = new Size(movingPoint.X - cursorPoint.X, movingPoint.Y - cursorPoint.Y);

                            //rec.Location = cursorPoint;
                            //rec.Size = new Size(size,size);
                            g.FillEllipse(brush, rec);
                        }
                        break;

                    case "Rectangle":
                        if (isDragging == false)
                        {
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
                                rec.Size = new Size(movingPoint.X - cursorPoint.X, movingPoint.Y - cursorPoint.Y);
                            }

                            //rec.Location = cursorPoint;
                            //rec.Size = new Size(size,size);
                            g.FillRectangle(brush, rec);
                        }
                        break;

                    case "Triangle":
                        if (!isDragging)
                            rec = new Rectangle();
                        else {
                            int x1=movingPoint.X;
                            int y1=movingPoint.Y;
                            int x2=cursorPoint.X;
                            int y2=movingPoint.Y;
                            int x3=movingPoint.X-((movingPoint.X- cursorPoint.X) /2);
                            int y3=cursorPoint.Y;
                            points[0] = new Point(x1, y1);
                            points[1] = new Point(x2, y2);
                            points[2] = new Point(x3, y3);
                            g.FillPolygon(brush,points);
                        }
                        break;
                }

                foreach (Shape shape in shapes) {
                    shape.Draw(g,brush);
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
            if (isDragging)
            {
                if (selectedShape == "Circle") {
                    shapes.Add(new EllipseShape(rec));
                }
                else if (selectedShape == "Rectangle") {
                    shapes.Add(new RectangleShape(rec));
                }
                else if (selectedShape=="Triangle") {
                    shapes.Add(new TriangleShape(points));
                }
            }
            isDragging = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            box?.Dispose();
            if (e.Button == MouseButtons.Right)
            {

                Point CurrentClick = (new Point(e.X, e.Y));

                box = new SelectionBox();

                if (CurrentClick.X + box.Width >= Width - 17)
                {
                    CurrentClick.X = CurrentClick.X - box.Width;
                }
                if (CurrentClick.Y + box.Height >= Height - 40)
                {
                    CurrentClick.Y = CurrentClick.Y - box.Height;
                }



                box.Location = PointToScreen(CurrentClick);
                box.OnEventclick += DrawShape;
                box.Show();
            }
            else if (e.Button == MouseButtons.Left)
            {
                cursorPoint = e.Location;
                Invalidate();
                isDragging = true;
                movingPoint = e.Location;
            }
            textBox1.Text = "" + e.Location + "    ";
        }
    }
}
