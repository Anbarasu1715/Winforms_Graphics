using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            public abstract Point[] GetPoints();
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

            public override Point[] GetPoints()
            {
                throw new NotImplementedException();
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

            public override Point[] GetPoints()
            {
                throw new NotImplementedException();
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
                return new Rectangle(0,0,0,0);
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

            public override Point[] GetPoints()
            {
                return polyPoints;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private string selectShape;
        private Point clickPoint;
        private Point movingPoint;
        private Rectangle rectangle;
        private bool isDragging = false;
        private bool isResize = false;
        private bool isSelected = false;
        private bool isModified=false;
        private bool isMoving=false;
        private bool isRotate = false;
        private bool upLeft = false;
        private bool upRight = false;
        private bool downLeft = false;
        private bool downRight = false;
        private bool top = false;
        private bool left = false;
        private bool right = false;
        private bool down = false;
        private List<Shape> shapes = new List<Shape>();
        private Point[] points;
        private Point loc;
        private int offsetX;
        private int offsetY;


        private Graphics g;
        private Pen pen;
        private Shape clickedShape;

        public delegate void Form1Handler(int a, Object obj,string s);

        private void RotateRectangle()
        {
            isModified = true;
            isRotate = true;
            //rectangle = new Rectangle();
            //Pen pen1=new Pen(Color.Black, 3);
            //rectangle.Location = clickPoint;
            //rectangle.Size = new Size(movingPoint);
            //if (selectShape != null) 

            //{
            //    switch (selectShape)
            //    {
            //        case "Rectangle":
            //            foreach (Shape shape in shapes)
            //            {
            //                if (shape == clickedShape && shape is RectangleShape)
            //                {
            //                    RectangleShape rectangleShape = (RectangleShape)shape;
            //                    rectangleShape.shape = rectangle;
            //                    break;
            //                }
            //            }
            //                break;
            //        case "Circle":

            //            break;
            //        case "Triangle":

            //            break;
            //    }
            //}
            foreach (Shape shape in shapes) {
                if (shape == clickedShape) {
                    shape.UpdateHeight(movingPoint.Y);
                    shape.UpdateWidth(movingPoint.X);
                    clickedShape = shape;
                    break;
                }
            }

            //isModified = false;
            paintPanel.Invalidate();
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
                points = new Point[3];
                int x1 = movingPoint.X;
                int y1 = movingPoint.Y;
                int x2 = clickPoint.X;
                int y2 = movingPoint.Y;
                int x3 = movingPoint.X - ((movingPoint.X - clickPoint.X) / 2);
                int y3 = clickPoint.Y;
                points[0] = new Point(x1, y1);
                points[1] = new Point(x2, y2);
                points[2] = new Point(x3, y3);
                g.DrawPolygon(pen, points);
            }
        }

        private void paintPanel_Paint(object sender, PaintEventArgs e)
        {

            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            DoubleBuffered = true;
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, paintPanel, new object[] { true });


            pen = new Pen(Color.Black,3);

            if ((selectShape!=null && !isResize && !isMoving && !isSelected )||isRotate)
            {
                isRotate = false;
                switch (selectShape)
                {
                    case "Rectangle":
                        if (!isModified)
                        {
                            //g.DrawRectangle(pen,rectangle);
                            DrawRectangle(pen);

                        }
                            
                        break;
                    case "Circle":
                        if (!isModified)
                        {
                            //g.DrawEllipse(pen, rectangle);
                            DrawEllipse(pen);

                        }
   
                        break;
                    case "Triangle":
                        if (!isModified)
                        {
                            //g.DrawPolygon(pen, points);
                            DrawTriangle(pen);

                        }
                            
                        break;
                }
            }

            foreach (Shape shape in shapes)
            {
                shape.Draw(g,pen);
            }

            if (clickedShape != null)
                clickedShape.Draw(g,new Pen(Color.Red,3));

            //pen.Dispose();
        }

        private void BtnsClick(Object sender,EventArgs e)
        {
            selectShape = (sender as Button).Text;
        }

        private void paintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectShape != null && !isSelected )
            {
                isDragging = true;
                isSelected = false;
                clickPoint = e.Location;
                movingPoint = e.Location;

                paintPanel.Invalidate();
            }
            clickPoint = e.Location;
            if (clickedShape != null && clickedShape.GetName()!="Triangle")
            {
                offsetX = e.Location.X - clickedShape.GetRectangle().Location.X;
                offsetY = e.Location.Y - clickedShape.GetRectangle().Location.Y;
            }
            movingPoint = e.Location;

            upLeft = false;
            upRight = false;
            downLeft = false;
            downRight = false;
            top = false;
            left = false;
            right = false;
            down = false;
            isMoving=false;
            isResize = false;

        }

        private void paintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //textBox1.Text = "" + e.Location;
            //textBox2.Text = "" + paintPanel.PointToScreen(e.Location);
            //textBox3.Text = "" + paintPanel.PointToClient(paintPanel.PointToScreen(e.Location));
            //isResize = false;

            //if (clickedShape!=null && clickedShape.GetName()!="Triangle") {
            //    return;
            //}

            if (e.Button == MouseButtons.Left && !isSelected && !isMoving)
            {
                isDragging = true;
                movingPoint = e.Location;
                paintPanel.Invalidate();
            }

            if (clickedShape!=null) {
                isMoving = true;
                int sHeight = clickedShape.GetRectangle().Height;
                int sWidth = clickedShape.GetRectangle().Width;
                int sX = clickedShape.GetRectangle().Location.X;
                int sY = clickedShape.GetRectangle().Location.Y;

                if (e.X >= sX && e.X <= sX + 15 && e.Y >= sY && e.Y <= sY + 15) {
                    isMoving = false;
                    this.Cursor = Cursors.SizeNWSE;
                    upLeft = true;
                }
                else if (e.X >= sX && e.X <= sX + 15 && e.Y <= sY + sHeight && e.Y >= sY + sHeight - 15) {
                    this.Cursor = Cursors.SizeNESW;
                    downLeft = true;
                }
                else if (e.X <= sX + sWidth && e.X >= sX + sWidth - 15 && e.Y >= sY && e.Y <= sY + 15) {
                    this.Cursor = Cursors.SizeNESW;
                    upRight = true;
                }
                else if (e.X <= sX + sWidth && e.X >= sX + sWidth - 15 && e.Y <= sY + sHeight && e.Y >= sY + sHeight - 15)
                {
                    this.Cursor = Cursors.SizeNWSE;
                    downRight = true;
                }
                else if (e.X >= sX + 15 && e.X <= sX + sWidth - 15 && e.Y >= sY - 5 && e.Y <= sY + 5) {
                    this.Cursor = Cursors.SizeNS;
                    top = true;
                }
                else if (e.X >= sX + 15 && e.X <= sX + sWidth - 15 && e.Y >= sY + sHeight - 5 && e.Y <= sY + sHeight + 5) {
                    this.Cursor = Cursors.SizeNS;
                    down = true;
                }
                else if (e.X>=sX-5 && e.X<=sX+5 && e.Y>=sY+15 && e.Y<=sY+sHeight-15) {
                    this.Cursor = Cursors.SizeWE;
                    left = true;
                }
                else if (e.X>=sX+sWidth-5 && e.X<=sX+sWidth+5 && e.Y>=sY+15 && e.Y<=sY+sHeight-15) {
                    this.Cursor = Cursors.SizeWE;
                    right = true;
                }
                else
                {
                    Cursor = Cursors.Arrow;
                }


                if (upLeft && e.Button == MouseButtons.Left)
                {

                    isResize = true;
                    foreach (Shape shape in shapes)
                    {
                        if (shape == clickedShape)
                        {
                            shape.UpdateHeight(loc.Y - e.Y);
                            shape.UpdateWidth(loc.X - e.X);
                            shape.UpdateLocation(e.Location);

                            paintPanel.Invalidate();
                        }
                    }
                }
                else if (downRight && e.Button == MouseButtons.Left) {
                    isResize = true;
                    foreach (Shape shape in shapes)
                    {
                        if (shape == clickedShape)
                        {
                            loc = shape.GetRectangle().Location;
                            shape.UpdateHeight((e.Y - (loc.Y)));
                            shape.UpdateWidth((e.X - (loc.X)));

                            paintPanel.Invalidate();
                        }
                    }
                }
                else if (downLeft && e.Button == MouseButtons.Left) {
                    isResize = true;
                    foreach (Shape shape in shapes)
                    {
                        if (shape == clickedShape)
                        {
                            shape.UpdateHeight(e.Y - shape.GetRectangle().Location.Y);
                            shape.UpdateWidth((loc.X - e.X));
                            shape.UpdateLocation(new Point(e.X, shape.GetRectangle().Location.Y));

                            paintPanel.Invalidate();
                        }
                    }
                }
                else if (upRight && e.Button == MouseButtons.Left) {
                    isResize = true;
                    foreach (Shape shape in shapes)
                    {
                        if (shape == clickedShape)
                        {
                            shape.UpdateHeight(loc.Y - e.Y);
                            shape.UpdateWidth(e.X - shape.GetRectangle().Location.X);
                            shape.UpdateLocation(new Point(shape.GetRectangle().Location.X, e.Y));

                            paintPanel.Invalidate();
                        }
                    }
                }
                else if (top && e.Button == MouseButtons.Left) {
                    isResize = true;
                    foreach (Shape shape in shapes)
                    {
                        if (shape == clickedShape)
                        {
                            shape.UpdateHeight(loc.Y - e.Y);
                            shape.UpdateLocation(new Point(shape.GetRectangle().Location.X, e.Y));

                            paintPanel.Invalidate();
                        }
                    }
                }
                else if (down && e.Button == MouseButtons.Left) {
                    isResize = true;
                    foreach (Shape shape in shapes)
                    {
                        if (shape == clickedShape)
                        {
                            
                           shape.UpdateHeight(e.Y-clickedShape.GetRectangle().Location.Y);

                            paintPanel.Invalidate();
                        }
                    }
                }
                else if (left && e.Button == MouseButtons.Left) {
                    isResize = true;
                    foreach (Shape shape in shapes)
                    {
                        if (shape == clickedShape)
                        {
                            
                           shape.UpdateWidth(loc.X - e.X);
                           shape.UpdateLocation(new Point(e.X,shape.GetRectangle().Location.Y));

                            paintPanel.Invalidate();
                        }
                    }
                }
                else if (right && e.Button == MouseButtons.Left) {
                    isResize = true;
                    foreach (Shape shape in shapes)
                    {
                        if (shape == clickedShape)
                        {
                            
                           shape.UpdateWidth(e.X-clickedShape.GetRectangle().Location.X);

                            paintPanel.Invalidate();
                        }
                    }
                }

                if (!isResize && e.Button == MouseButtons.Left && e.X >= sX + 7 && e.X <= sX + sWidth - 7 && e.Y >= sY + 7 && e.Y <= sY + sHeight - 7)
                {
                    foreach (Shape shape in shapes)
                    {
                        if (shape == clickedShape)
                        {
                            isMoving = true;
                            shape.UpdateLocation(new Point(e.X-offsetX,e.Y-offsetY));
                            paintPanel.Invalidate();
                        }
                    }
                }
            }
        }

        private void paintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isModified = false;
            if (e.Button == MouseButtons.Left && (clickPoint.X - movingPoint.X != 0 && clickPoint.Y - movingPoint.Y != 0 || isModified))
            {
                switch (selectShape)
                {
                    case "Rectangle":
                        shapes.Add(new RectangleShape(rectangle));

                        break;
                    case "Circle":
                        shapes.Add(new EllipseShape(rectangle));
                        isModified = false;
                        break;
                    case "Triangle":
                        shapes.Add(new PolygonShape(points));
                        isModified = false;
                        break;
                }
                
                isDragging = false;
                isResize = false;

                

            }
            upLeft = false;
            upRight = false;
            downLeft = false;
            downRight = false;
            top = false;
            left = false;
            right = false;
            down = false;
            loc = new Point(0,0);

            if (clickPoint.X - movingPoint.X == 0 && clickPoint.Y - movingPoint.Y == 0 && shapes.Count > 0)
            {
                isSelected = false;
                clickPoint = e.Location;
                foreach (Shape shape in shapes)
                {

                    if (shape.GetName() == "Triangle")
                    {

                        int x1 = shape.GetPoints()[0].X;
                        int y1 = shape.GetPoints()[0].Y;
                        int x2 = shape.GetPoints()[1].X;
                        int y2 = shape.GetPoints()[1].Y;
                        int x3 = shape.GetPoints()[2].X;
                        int y3 = shape.GetPoints()[2].Y;

                        if (clickPoint.X <= x1 && clickPoint.X >= x2 && clickPoint.Y >= y3 && clickPoint.Y <= y1)
                        {
                            clickedShape = shape;
                            paintPanel.Invalidate();
                            selectShape = shape.GetName();
                            //loc.X = shape.GetRectangle().Location.X + shape.GetRectangle().Size.Width;
                            //loc.Y = shape.GetRectangle().Location.Y + shape.GetRectangle().Size.Height;
                            isSelected = true;
                        }
                        else if (!isSelected)
                        {
                            isSelected = false;
                            clickedShape = null;
                        }

                        continue;
                    }

                    int x = shape.GetRectangle().Location.X;
                    int y = shape.GetRectangle().Location.Y;
                    int width = shape.GetRectangle().Size.Width;
                    int height = shape.GetRectangle().Size.Height;


                    if (clickPoint.X >= x && clickPoint.X <= x+width && clickPoint.Y >= y && clickPoint.Y <= y+height)
                    {
                        clickedShape = shape;
                        paintPanel.Invalidate();
                        selectShape = shape.GetName();
                        loc.X = shape.GetRectangle().Location.X+shape.GetRectangle().Size.Width;
                        loc.Y = shape.GetRectangle().Location.Y+shape.GetRectangle().Size.Height;
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

            //isMoving = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //if (isSelected)
            //{
            //    shapes.Remove(clickedShape);
            //}
            if (clickedShape!=null)
            {
                int sHeight = clickedShape.GetRectangle().Height;
                int sWidth = clickedShape.GetRectangle().Width;
                int sX = clickedShape.GetRectangle().Location.X;
                int sY = clickedShape.GetRectangle().Location.Y;

                clickPoint = clickedShape.GetRectangle().Location;

                movingPoint.X = sHeight;
                movingPoint.Y = sWidth;
                RotateRectangle();

                //clickedShape = null;
                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Shape currentShape=clickedShape;
            bool isEntered = false;
            foreach (Shape shape in shapes)
            {
                if (shape.GetName() == "Triangle")
                {
                    int x1 = shape.GetPoints()[0].X;
                    int y1 = shape.GetPoints()[0].Y;
                    int x2 = shape.GetPoints()[1].X;
                    int y2 = shape.GetPoints()[1].Y;
                    int x3 = shape.GetPoints()[2].X;
                    int y3 = shape.GetPoints()[2].Y;
                    if (clickPoint.X <= x1 && clickPoint.X >= x2 && clickPoint.Y >= y3 && clickPoint.Y <= y1)
                    {
                        currentShape = shape;
                        isEntered = true;
                    }
                    continue;
                }

                int x = shape.GetRectangle().Location.X;
                int y = shape.GetRectangle().Location.Y;
                int width = shape.GetRectangle().Size.Width;
                int height = shape.GetRectangle().Size.Height;

                if (clickPoint.X >= x && clickPoint.X <= x + width && clickPoint.Y >= y && clickPoint.Y <= y + height)
                {
                    currentShape = shape;
                    isEntered = true;
                }
            }
            if(isEntered)
                shapes.Remove(currentShape);
            clickedShape = null;
            paintPanel.Invalidate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
