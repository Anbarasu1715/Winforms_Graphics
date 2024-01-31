using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LucidLogo
{
    public partial class LogoTransUC : UserControl
    {
        public LogoTransUC()
        {
            InitializeComponent();
            timer.Interval = 1;
            timer.Tick += Transition;
            
        }

        private Graphics g;
        private bool isLoading=true;
        private Timer timer = new Timer();
        private List<Point[]> points = new List<Point[]>();
        private List<Point[]> fixedPoints = new List<Point[]>();
        private int currentPoly=0;
        private int transitionCount = 0;
        private int minPoint;
        private int X1=0, Y1 = 0;
        private int logoSize;

        private void LoadingTrans() {

            for (int i = 0; i < points[0].Length; i++)
            {
                points[0][i].Y = points[0][i].Y - 20;
            }

            for (int i = 0; i < points[1].Length; i++)
            {
                points[1][i].Y = points[1][i].Y - 20;
                points[1][i].X = points[1][i].X + 20;
            }

            for (int i = 0; i < points[2].Length; i++)
            {
                points[2][i].X = points[2][i].X + 20;
            }

            for (int i=0;i< points[3].Length;i++) {
                points[3][i].X = points[3][i].X + 20;
            }

            for (int i=0;i< points[4].Length;i++) {
                points[4][i].Y = points[4][i].Y + 20;
            }

            for (int i=0;i< points[5].Length;i++) {
                points[5][i].Y = points[5][i].Y + 20;
            }

            for (int i=0;i< points[6].Length;i++) {
                points[6][i].X = points[6][i].X - 20;
            }

            for (int i=0;i< points[7].Length;i++) {
                points[7][i].X = points[7][i].X - 20;
            }
            


        }

        private void Transition(Object sender,EventArgs e) {

            if (currentPoly == 0)
            {
                for (int i = 0; i < points[0].Length; i++)
                {
                    points[0][i].Y = points[0][i].Y + 2;
                }
            }

            if (currentPoly == 1)
            {
                for (int i = 0; i < points[1].Length; i++)
                {
                    points[1][i].Y = points[1][i].Y + 2;
                    points[1][i].X = points[1][i].X - 2;
                }
            }

            if (currentPoly == 2)
            {
                for (int i = 0; i < points[2].Length; i++)
                {
                    points[2][i].X = points[2][i].X - 2;
                }
            }

            if (currentPoly == 3)
            {
                for (int i = 0; i < points[3].Length; i++)
                {
                    points[3][i].X = points[3][i].X - 2;
                }
            }

            if (currentPoly == 4)
            {
                for (int i = 0; i < points[4].Length; i++)
                {
                    points[4][i].Y = points[4][i].Y - 2;
                }
            }

            if (currentPoly == 5)
            {
                for (int i = 0; i < points[5].Length; i++)
                {
                    points[5][i].Y = points[5][i].Y - 2;
                }
            }

            if (currentPoly == 6)
            {
                for (int i = 0; i < points[6].Length; i++)
                {
                    points[6][i].X = points[6][i].X + 2;
                }
            }

            if (currentPoly == 7)
            {
                for (int i = 0; i < points[7].Length; i++)
                {
                    points[7][i].X = points[7][i].X + 2;
                }
            }

            Invalidate();
            transitionCount++;
            if (transitionCount >= 10)
            {
                transitionCount = 0;
                fixedPoints.Add(points[currentPoly]);
                currentPoly++;
            }
            if (currentPoly > 7)
            {
                points.Clear();
                fixedPoints.Clear();
                initialCoordinates();
                currentPoly = 0;
            }
        }

        private void LogoTransUC_Paint(object sender, PaintEventArgs e)
        {

            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            DoubleBuffered = true;
            

            Brush brush = new SolidBrush(Color.FromArgb(13, 98, 177));

            //g.FillPolygon(brush,Poly1);
            //g.FillPolygon(brush,Poly2);
            //g.FillPolygon(brush,Poly3);
            //g.FillPolygon(brush,Poly4);
            //g.FillPolygon(brush,Poly5);
            //g.FillPolygon(brush,Poly6);
            //g.FillPolygon(brush,Poly7);
            //g.FillPolygon(brush,Poly8);


            foreach (Point[] point in fixedPoints) {
                g.FillPolygon(brush,point);
            }
            if (currentPoly < points.Count) {
                g.FillPolygon(brush,points[currentPoly]);
            }

            Brush b1 = new SolidBrush(Color.FromArgb(13, 98, 177));
            Brush b2 = new SolidBrush(Color.FromArgb(0, 181, 226));

            StringFormat lucidSFormat = new StringFormat();
            lucidSFormat.Alignment = StringAlignment.Near;
            lucidSFormat.LineAlignment = StringAlignment.Center;

            StringFormat imagingSFormat = new StringFormat();
            imagingSFormat.Alignment = StringAlignment.Center;
            imagingSFormat.LineAlignment = StringAlignment.Center;

            Font f1 = new Font(new FontFamily("Segoe UI"), logoSize / 2, FontStyle.Bold | FontStyle.Italic);
            Font f2 = new Font(new FontFamily("Segoe UI"), logoSize / 3, FontStyle.Bold | FontStyle.Italic);

            e.Graphics.DrawString("Lucid", f1, b1, new Rectangle(X1 + logoSize, Y1, logoSize * 3, logoSize / 2), lucidSFormat);
            e.Graphics.DrawString("Imaging", f2, b2, new Rectangle(X1 + logoSize, Y1 + logoSize / 2, logoSize * 3, logoSize / 2), imagingSFormat);


            brush.Dispose();

        }

        private void initialCoordinates() {
            Point[] Poly1 = {
                new Point(((logoSize*110)/304)+X1,(logoSize * 46) / 286 +Y1),
                new Point(((logoSize*151)/304)+X1,(logoSize *  5) /  286  +Y1),
                new Point(((logoSize*173)/304)+X1,(logoSize * 26) / 286 +Y1),
                new Point(((logoSize*170)/304)+X1,(logoSize * 101) / 286+Y1)
            };
            points.Add(Poly1);

            Point[] Poly2 = {
                new Point((logoSize*176)/304+X1,(logoSize*29)/286+Y1),
                new Point((logoSize*215)/304+X1,(logoSize*68)/286+Y1),
                new Point((logoSize*179)/304+X1,(logoSize*101)/286+Y1)
            };
            points.Add(Poly2);

            Point[] Poly3 = {
                new Point((logoSize*218)/304+X1,(logoSize*71)/286+Y1),
                new Point((logoSize*257)/304+X1,(logoSize*109)/286+Y1),
                new Point((logoSize*185)/304+X1,(logoSize*106)/286+Y1)
            };
            points.Add(Poly3);

            Point[] Poly4 = {
                new Point((logoSize*185)/304+X1,(logoSize*115)/286+Y1),
                new Point((logoSize*259)/304+X1,(logoSize*112)/286+Y1),
                new Point((logoSize*286)/304+X1,(logoSize*139)/286+Y1),
                new Point((logoSize*280)/304+X1,(logoSize*142)/286+Y1),
                new Point((logoSize*273)/304+X1,(logoSize*145)/286+Y1),
                new Point((logoSize*265)/304+X1,(logoSize*149)/286+Y1),
                new Point((logoSize*253)/304+X1,(logoSize*156)/286+Y1),
                new Point((logoSize*241)/304+X1,(logoSize*164)/286+Y1),
                new Point((logoSize*236)/304+X1,(logoSize*168)/286+Y1)
            };
            points.Add(Poly4);

            Point[] Poly5 = {
                new Point((logoSize*179)/304+X1,(logoSize*121)/286+Y1),
                new Point((logoSize*232)/304+X1,(logoSize*170)/286+Y1),
                new Point((logoSize*225)/304+X1,(logoSize*176)/286+Y1),
                new Point((logoSize*216)/304+X1,(logoSize*183)/286+Y1),
                new Point((logoSize*208)/304+X1,(logoSize*191)/286+Y1),
                new Point((logoSize*200)/304+X1,(logoSize*199)/286+Y1),
                new Point((logoSize*190)/304+X1,(logoSize*211)/286+Y1),
                new Point((logoSize*176)/304+X1,(logoSize*230)/286+Y1),
            };
            points.Add(Poly5);

            Point[] Poly6 = {
                new Point((logoSize*173)/304+X1,(logoSize*233)/286+Y1),
                new Point((logoSize*166)/304+X1,(logoSize*245)/286+Y1),
                new Point((logoSize*161)/304+X1,(logoSize*254)/286+Y1),
                new Point((logoSize*157)/304+X1,(logoSize*263)/286+Y1),
                new Point((logoSize*151)/304+X1,(logoSize*274)/286+Y1),
                new Point((logoSize*145)/304+X1,(logoSize*261)/286+Y1),
                new Point((logoSize*141)/304+X1,(logoSize*252)/286+Y1),
                new Point((logoSize*137)/304+X1,(logoSize*244)/286+Y1),
                new Point((logoSize*132)/304+X1,(logoSize*236)/286+Y1),
                new Point((logoSize*129)/304+X1,(logoSize*230)/286+Y1),
                new Point((logoSize*124)/304+X1,(logoSize*223)/286+Y1),
                new Point((logoSize*119)/304+X1,(logoSize*215)/286+Y1),
                new Point((logoSize*112)/304+X1,(logoSize*206)/286+Y1),
                new Point((logoSize*98)/304 +X1,(logoSize*190)/286+Y1),
                new Point((logoSize*170)/304+X1,(logoSize*122)/286+Y1)
            };
            points.Add(Poly6);

            Point[] Poly7 = {
                new Point((logoSize*96)/304+X1,(logoSize*188)/286+Y1),
                new Point((logoSize*83)/304+X1,(logoSize*177)/286+Y1),
                new Point((logoSize*74)/304+X1,(logoSize*170)/286+Y1),
                new Point((logoSize*67)/304+X1,(logoSize*165)/286+Y1),
                new Point((logoSize*59)/304+X1,(logoSize*160)/286+Y1),
                new Point((logoSize*51)/304+X1,(logoSize*155)/286+Y1),
                new Point((logoSize*43)/304+X1,(logoSize*151)/286+Y1),
                new Point((logoSize*33)/304+X1,(logoSize*146)/286+Y1),
                new Point((logoSize*16)/304+X1,(logoSize*139)/286+Y1),
                new Point((logoSize*42)/304+X1,(logoSize*113)/286+Y1),
                new Point((logoSize*164)/304+X1,(logoSize*115)/286+Y1)
            };
            points.Add(Poly7);

            Point[] Poly8 = {
                new Point((logoSize*108)/304+X1,(logoSize*47)/286+Y1),
                new Point((logoSize*164)/304+X1,(logoSize*107)/286+Y1),
                new Point((logoSize*45)/304 +X1,(logoSize*111)/286+Y1),
            };
            points.Add(Poly8);

            LoadingTrans();
            timer.Start();
        }

        private void LogoTransUC_Load(object sender, EventArgs e)
        {
            initialCoordinates();
            if (Height * 4 <= Width)
            {
                logoSize = Height;
                X1 = (Width - Height * 4) / 2;
                Y1 = 0;
            }
            else
            {
                logoSize = Width / 4;
                X1 = 0;
                Y1 = (Height - logoSize) / 2;
            }
            X1 = X1 + logoSize / 4;
            minPoint = Math.Min(Width, Height);
            //LogoTransUC_Resize(sender, e);
        }

        private void LogoTransUC_Resize(object sender, EventArgs e)
        {
            minPoint= Math.Min(Width,Height);
            //if (Height > Width) {
            //    X1 = 0;
            //    Y1 =(Height-Width)/2;
            //}
            //else if (Width>Height) {
            //    Y1 = 0;
            //    X1 = (Width-Height)/2;
            //}


            if (Height * 4 <= Width)
            {
                logoSize = Height;
                X1 = (Width - Height * 4) / 2;
                Y1 = 0;
            }
            else
            {
                logoSize = Width / 4;
                X1 = 0;
                Y1 = (Height - logoSize) / 2;
            }
            X1 = X1 + logoSize / 4;
        }
    }
}
