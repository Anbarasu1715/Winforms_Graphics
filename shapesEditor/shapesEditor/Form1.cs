using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapesEditor
{
    public partial class Form1 : Form
    {

        public abstract class Shape {
            public Rectangle shape;
            public Point[] polyPoints;
            public abstract Rectangle GetRectangle();
            //public abstract Rectangle SetRectangle();
            public abstract void Draw(Graphics g,Pen pen);
        }

        public class RectangleShape:Shape {
            public RectangleShape(Rectangle rec) {
                shape = rec;
            }

            public override Rectangle GetRectangle() {
                return shape;
            }

            public override void Draw(Graphics g, Pen pen) {
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
                for (int i=0;i<points.Length;i++) {
                    polyPoints[i] = points[i];
                }
            }

            public override Rectangle GetRectangle()
            {
                throw new NotImplementedException();
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
        private List<Shape> shapes = new List<Shape>();

        private Graphics g;
        private Shape clickedShape;

        private void DrawRectangle(Pen pen) {
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

        public void DrawEllipse(Pen pen) {
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

        private void paintPanel_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            DoubleBuffered = true;

            Pen pen = new Pen(Color.Black,3);

            if (selectShape!=null) {
                switch (selectShape) {
                    case "Rectangle":
                        DrawRectangle(pen);
                        break;
                    case "Circle":
                        DrawEllipse(pen);
                        break;
                }
            }

            foreach (Shape shape in shapes) {
                shape.Draw(g,pen);
                //richTextBox1.Text += shape.GetRectangle().Location+"";
            }

            pen.Dispose();
        }

        private void BtnsClick(Object sender,EventArgs e) {
            selectShape = (sender as Button).Text;
        }

        private void paintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectShape != null && !isSelected) {
                isDragging = true;
                isSelected = false;
                clickPoint = e.Location;
                movingPoint = e.Location;

                paintPanel.Invalidate();
            }
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
            if (e.Button == MouseButtons.Left && clickPoint.X - movingPoint.X != 0 && clickPoint.Y - movingPoint.Y != 0 )
            {
                switch (selectShape) {
                    case "Rectangle":
                        shapes.Add(new RectangleShape(rectangle));
                        break;
                    case "Circle":
                        shapes.Add(new EllipseShape(rectangle));
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
                        textBox1.Text = clickedShape.GetRectangle().Location + "";
                        isSelected = true;
                    }
                    else if (!isSelected) {
                        isSelected = false;
                    }
                }
            }

        }
    }
}
