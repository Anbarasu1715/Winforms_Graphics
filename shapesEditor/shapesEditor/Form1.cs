using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapesEditor
{
    public partial class Form1 : Form
    {

        public abstract class Shape
        {
            public Rectangle shape;
            public Point[] polyPoints;
            public abstract Rectangle GetRectangle();
            //public abstract Rectangle SetRectangle();
            public abstract void Draw(Graphics g,Pen pen);
            public abstract void UpdateWidth(int newWidth);
            public abstract void UpdateHeight(int newHeight);
            public abstract void UpdateLocation(Point newLocation);
            public abstract string GetName();
        }

        public class RectangleShape:Shape
        {
            public RectangleShape(Rectangle rec)
            {
                shape = rec;
            }

            public override Rectangle GetRectangle()
            {
                return shape;
            }

            public override void UpdateWidth(int newWidth)
            {
                shape.Width = newWidth;
            }

            public override void UpdateHeight(int newHeight)
            {
                shape.Height = newHeight;
            }

            public override void UpdateLocation(Point newLocation)
            {
                shape.Location = newLocation;
            }

            public override string GetName() {
                return "Rectangle";
            }


            public override void Draw(Graphics g, Pen pen)
            {
                g.DrawRectangle(pen,shape);
            }
        }

        public class EllipseShape : Shape
        {
            public EllipseShape(Rectangle rec)
            {
                shape = rec;
            }

            public override Rectangle GetRectangle()
            {
                return shape;
            }

            public override void UpdateWidth(int newWidth)
            {
                shape.Width = newWidth;
            }

            public override void UpdateHeight(int newHeight)
            {
                shape.Height = newHeight;
            }

            public override void UpdateLocation(Point newLocation)
            {
                shape.Location = newLocation;
            }

            public override string GetName()
            {
                return "Circle";
            }

            public override void Draw(Graphics g, Pen pen)
            {
                g.DrawEllipse(pen, shape);
            }
        }

        public class PolygonShape : Shape
        {
            public PolygonShape(Point[] points)
            {
                polyPoints = new Point[points.Length];
                for (int i=0;i<points.Length;i++)
                {
                    polyPoints[i] = points[i];
                }
            }

            public override Rectangle GetRectangle()
            {
                throw new NotImplementedException();
            }

            public override void UpdateWidth(int newWidth)
            {
                shape.Width = newWidth;
            }

            public override void UpdateHeight(int newHeight)
            {
                shape.Height = newHeight;
            }

            public override void UpdateLocation(Point newLocation)
            {
                shape.Location = newLocation;
            }

            public override string GetName()
            {
                return "Triangle";
            }

            public override void Draw(Graphics g, Pen pen)
            {
                g.DrawPolygon(pen, polyPoints);
            }
        }

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

        private string selectShape;
        private Point clickPoint;
        private Point movingPoint;
        private Rectangle rectangle;
        private bool isDragging = false;
        private bool isMoving = false;
        private bool isSelected = false;
        private bool isModified=false;
        private List<Shape> shapes = new List<Shape>();

        private Graphics g;
        private Pen pen;
        private Shape clickedShape;

        public delegate void Form1Handler(int a, Object obj,string s);

        private void RotateRectangle()
        {
            isModified = true;
            rectangle = new Rectangle();
            Pen pen1=new Pen(Color.Black, 3);
            rectangle.Location = clickPoint;
            rectangle.Size = new Size(movingPoint);
            paintPanel.Invalidate();
            //g.DrawRectangle(pen1, rectangle);
        }

        private void DrawRectangle(Pen pen)
        {
            if (!isDragging)
            {
                rectangle = new Rectangle();
            }
            else {

                int width = movingPoint.X - clickPoint.X;
                int height = movingPoint.Y - clickPoint.Y;

                if (width < 0 && height < 0)
                {
                    rectangle.Location = new Point(movingPoint.X, movingPoint.Y);
                    rectangle.Size = new Size(clickPoint.X - movingPoint.X, clickPoint.Y - movingPoint.Y);
                }
                else if (width < 0 && height > 0)
                {
                    rectangle.Location = new Point(movingPoint.X, clickPoint.Y);
                    rectangle.Size = new Size(clickPoint.X - movingPoint.X, movingPoint.Y - clickPoint.Y);
                }
                else if (width > 0 && height < 0)
                {
                    rectangle.Location = new Point(clickPoint.X, movingPoint.Y);
                    rectangle.Size = new Size(movingPoint.X - clickPoint.X, clickPoint.Y - movingPoint.Y);
                }
                else if (width > 0 && height > 0)
                {
                    rectangle.Location = clickPoint;
                    rectangle.Size = new Size(movingPoint.X - clickPoint.X, movingPoint.Y - clickPoint.Y);
                }

                g.DrawRectangle(pen,rectangle);

            }
        }

        public void DrawEllipse(Pen pen)
        {
            if (!isDragging)
            {
                rectangle = new Rectangle();
            }
            else
            {
                int width = movingPoint.X - clickPoint.X;
                int height = movingPoint.Y - clickPoint.Y;
                int size;

                //if (width < 0 && height < 0)
                //{
                //    rectangle.Location = new Point(movingPoint.X, movingPoint.Y);
                //    size = Math.Max(clickPoint.X - movingPoint.X, clickPoint.Y - movingPoint.Y);
                //    rectangle.Size = new Size(size,size);
                //}
                //else if (width < 0 && height > 0)
                //{
                //    rectangle.Location = new Point(movingPoint.X, clickPoint.Y);
                //    size = Math.Max(clickPoint.X - movingPoint.X, movingPoint.Y - clickPoint.Y);
                //    rectangle.Size = new Size(size, size);
                //}
                //else if (width > 0 && height < 0)
                //{
                //    rectangle.Location = new Point(clickPoint.X, movingPoint.Y);
                //    size = Math.Max(movingPoint.X - clickPoint.X, clickPoint.Y - movingPoint.Y);
                //    rectangle.Size = new Size(size, size);
                //}
                //else if (width > 0 && height > 0)
                //{
                //    rectangle.Location = clickPoint;
                //    size = Math.Min(width, height);
                //    rectangle.Size = new Size(size, size);
                //}

                rectangle.Size = new Size(movingPoint.X - clickPoint.X, movingPoint.Y - clickPoint.Y);
                rectangle.Location = clickPoint;

                g.DrawEllipse(pen,rectangle);
            }
        }

        private void DrawTriangle(Pen pen)
        {
            if (!isDragging)
                rectangle = new Rectangle();
            else
            {
                int x1 = movingPoint.X;
                int y1 = movingPoint.Y;
                int x2 = clickPoint.X;
                int y2 = movingPoint.Y;
                int x3 = movingPoint.X - ((movingPoint.X - clickPoint.X) / 2);
                int y3 = clickPoint.Y;
                //points[0] = new Point(x1, y1);
                //points[1] = new Point(x2, y2);
                //points[2] = new Point(x3, y3);
                //g.FillPolygon(brush, points);
            }
        }

        private void paintPanel_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            DoubleBuffered = true;

            pen = new Pen(Color.Black,3);

            if (selectShape!=null)
            {
                switch (selectShape)
                {
                    case "Rectangle":
                        if (isModified)
                        {
                            g.DrawRectangle(pen,rectangle);
                            
                        }
                        else
                            DrawRectangle(pen);
                        break;
                    case "Circle":
                        if (isModified)
                        {
                            g.DrawEllipse(pen, rectangle);

                        }
                        else
                            DrawEllipse(pen);
                        break;
                }
            }

            foreach (Shape shape in shapes)
            {
                shape.Draw(g,pen);
                //richTextBox1.Text += shape.GetRectangle().Location+"";
            }

            //pen.Dispose();
        }

        private void BtnsClick(Object sender,EventArgs e)
        {
            selectShape = (sender as Button).Text;
        }

        private void paintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectShape != null && !isSelected)
            {
                isDragging = true;
                isSelected = false;
                clickPoint = e.Location;
                movingPoint = e.Location;

                paintPanel.Invalidate();
            }
            clickPoint = e.Location;
            movingPoint = e.Location;
        }

        private void paintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !isSelected)
            {
                isDragging = true;
                isMoving = true;
                movingPoint = e.Location;
                paintPanel.Invalidate();
            }
        }

        private void paintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && (clickPoint.X - movingPoint.X != 0 && clickPoint.Y - movingPoint.Y != 0 || isModified))
            {
                switch (selectShape)
                {
                    case "Rectangle":
                        shapes.Add(new RectangleShape(rectangle));
                        isModified = false;
                        break;
                    case "Circle":
                        shapes.Add(new EllipseShape(rectangle));
                        isModified = false;
                        break;
                }
                
                isDragging = false;
                isMoving = false;

            }

            if (clickPoint.X - movingPoint.X == 0 && clickPoint.Y - movingPoint.Y == 0 && shapes.Count > 0)
            {
                isSelected = false;
                clickPoint = e.Location;
                foreach (Shape shape in shapes)
                {
                    int x = shape.GetRectangle().Location.X;
                    int y = shape.GetRectangle().Location.Y;
                    int width = shape.GetRectangle().Size.Width;
                    int height = shape.GetRectangle().Size.Height;

                    if (clickPoint.X >= x && clickPoint.X <= x+width && clickPoint.Y >= y && clickPoint.Y <= y+height)
                    {
                        clickedShape = shape;
                        selectShape = shape.GetName();
                        textBox1.Text = clickedShape.GetRectangle().Location + "";
                        isSelected = true;
                    }
                    else if (!isSelected)
                    {
                        isSelected = false;
                        clickedShape = null;
                    }
                }
            }

            if (shapes.Count<1)
            {
                isSelected = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (isSelected)
            {
                shapes.Remove(clickedShape);
                //paintPanel.Invalidate();
            }
            if (clickedShape!=null)
            {
                int sHeight = clickedShape.GetRectangle().Height;
                int sWidth = clickedShape.GetRectangle().Width;
                int sX = clickedShape.GetRectangle().Location.X;
                int sY = clickedShape.GetRectangle().Location.Y;

                //if (sHeight > sWidth)
                //{
                //    clickPoint.X = sX - sHeight;
                //    clickPoint.Y = sY;
                //}
                //else
                clickPoint = clickedShape.GetRectangle().Location;


                movingPoint.X = sHeight;
                movingPoint.Y = sWidth;
                RotateRectangle();

                //foreach (Shape shape in shapes) {
                //    if (shape == clickedShape) {
                //        shape.UpdateWidth(clickedShape.GetRectangle().Height);
                //        shape.UpdateHeight(clickedShape.GetRectangle().Width);
                //        //paintPanel.Invalidate();
                //        RotateRectangle();
                //        break;
                //    }
                //}

                clickedShape = null;
                //RotateRectangle();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                int x = shape.GetRectangle().Location.X;
                int y = shape.GetRectangle().Location.Y;
                int width = shape.GetRectangle().Size.Width;
                int height = shape.GetRectangle().Size.Height;

                if (clickPoint.X >= x && clickPoint.X <= x + width && clickPoint.Y >= y && clickPoint.Y <= y + height)
                {
                    clickedShape = shape;
                }
            }
            shapes.Remove(clickedShape);
            clickedShape = null;
            paintPanel.Invalidate();
        }
    }
}
