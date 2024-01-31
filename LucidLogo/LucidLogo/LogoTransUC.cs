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
        private int size;

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

            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };


            StringFormat sf1 = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Brush brush = new SolidBrush(Color.FromArgb(13, 98, 177));
            Brush letterBrush1 = new SolidBrush(Color.FromArgb(13, 98, 177));
            Brush letterBrush2 = new SolidBrush(Color.FromArgb(0, 181, 226));

            //g.FillPolygon(brush,Poly1);
            //g.FillPolygon(brush,Poly2);
            //g.FillPolygon(brush,Poly3);
            //g.FillPolygon(brush,Poly4);
            //g.FillPolygon(brush,Poly5);
            //g.FillPolygon(brush,Poly6);
            //g.FillPolygon(brush,Poly7);
            //g.FillPolygon(brush,Poly8);


            Font lucidFontFormat = new Font(new FontFamily("Segoe UI"), size / 2, FontStyle.Bold | FontStyle.Italic);
            Font imagingFontFormat = new Font(new FontFamily("Segoe UI"), size / 3, FontStyle.Bold | FontStyle.Italic);

            foreach (Point[] point in fixedPoints) {
                g.FillPolygon(brush,point);
            }
            if (currentPoly < points.Count) {
                g.FillPolygon(brush,points[currentPoly]);
            }


            e.Graphics.DrawString("Lucid", lucidFontFormat, letterBrush1, new Rectangle(X1 + size, Y1, size * 3, size / 2), sf);
            e.Graphics.DrawString("Imaging", imagingFontFormat, letterBrush2, new Rectangle(X1 + size, Y1 + size / 2, size * 3, size / 2), sf1);


            brush.Dispose();

        }

        private void initialCoordinates() {
            Point[] Poly1 = {
                new Point(((size*110)/304)+X1,(size * 46) / 286 +Y1),
                new Point(((size*151)/304)+X1,(size *  5) /  286  +Y1),
                new Point(((size*173)/304)+X1,(size * 26) / 286 +Y1),
                new Point(((size*170)/304)+X1,(size * 101) / 286+Y1)
            };
            points.Add(Poly1);

            Point[] Poly2 = {
                new Point((size*176)/304+X1,(size*29)/286+Y1),
                new Point((size*215)/304+X1,(size*68)/286+Y1),
                new Point((size*179)/304+X1,(size*101)/286+Y1)
            };
            points.Add(Poly2);

            Point[] Poly3 = {
                new Point((size*218)/304+X1,(size*71)/286+Y1),
                new Point((size*257)/304+X1,(size*109)/286+Y1),
                new Point((size*185)/304+X1,(size*106)/286+Y1)
            };
            points.Add(Poly3);

            Point[] Poly4 = {
                new Point((size*185)/304+X1,(size*115)/286+Y1),
                new Point((size*259)/304+X1,(size*112)/286+Y1),
                new Point((size*286)/304+X1,(size*139)/286+Y1),
                new Point((size*280)/304+X1,(size*142)/286+Y1),
                new Point((size*273)/304+X1,(size*145)/286+Y1),
                new Point((size*265)/304+X1,(size*149)/286+Y1),
                new Point((size*253)/304+X1,(size*156)/286+Y1),
                new Point((size*241)/304+X1,(size*164)/286+Y1),
                new Point((size*236)/304+X1,(size*168)/286+Y1)
            };
            points.Add(Poly4);

            Point[] Poly5 = {
                new Point((size*179)/304+X1,(size*121)/286+Y1),
                new Point((size*232)/304+X1,(size*170)/286+Y1),
                new Point((size*225)/304+X1,(size*176)/286+Y1),
                new Point((size*216)/304+X1,(size*183)/286+Y1),
                new Point((size*208)/304+X1,(size*191)/286+Y1),
                new Point((size*200)/304+X1,(size*199)/286+Y1),
                new Point((size*190)/304+X1,(size*211)/286+Y1),
                new Point((size*176)/304+X1,(size*230)/286+Y1),
            };
            points.Add(Poly5);

            Point[] Poly6 = {
                new Point((size*173)/304+X1,(size*233)/286+Y1),
                new Point((size*166)/304+X1,(size*245)/286+Y1),
                new Point((size*161)/304+X1,(size*254)/286+Y1),
                new Point((size*157)/304+X1,(size*263)/286+Y1),
                new Point((size*151)/304+X1,(size*274)/286+Y1),
                new Point((size*145)/304+X1,(size*261)/286+Y1),
                new Point((size*141)/304+X1,(size*252)/286+Y1),
                new Point((size*137)/304+X1,(size*244)/286+Y1),
                new Point((size*132)/304+X1,(size*236)/286+Y1),
                new Point((size*129)/304+X1,(size*230)/286+Y1),
                new Point((size*124)/304+X1,(size*223)/286+Y1),
                new Point((size*119)/304+X1,(size*215)/286+Y1),
                new Point((size*112)/304+X1,(size*206)/286+Y1),
                new Point((size*98)/304 +X1,(size*190)/286+Y1),
                new Point((size*170)/304+X1,(size*122)/286+Y1)
            };
            points.Add(Poly6);

            Point[] Poly7 = {
                new Point((size*96)/304+X1,(size*188)/286+Y1),
                new Point((size*83)/304+X1,(size*177)/286+Y1),
                new Point((size*74)/304+X1,(size*170)/286+Y1),
                new Point((size*67)/304+X1,(size*165)/286+Y1),
                new Point((size*59)/304+X1,(size*160)/286+Y1),
                new Point((size*51)/304+X1,(size*155)/286+Y1),
                new Point((size*43)/304+X1,(size*151)/286+Y1),
                new Point((size*33)/304+X1,(size*146)/286+Y1),
                new Point((size*16)/304+X1,(size*139)/286+Y1),
                new Point((size*42)/304+X1,(size*113)/286+Y1),
                new Point((size*164)/304+X1,(size*115)/286+Y1)
            };
            points.Add(Poly7);

            Point[] Poly8 = {
                new Point((size*108)/304+X1,(size*47)/286+Y1),
                new Point((size*164)/304+X1,(size*107)/286+Y1),
                new Point((size*45)/304 +X1,(size*111)/286+Y1),
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
                size = Height;
                X1 = (Width - Height * 4) / 2;
                Y1 = 0;
            }
            else
            {
                size = Width / 4;
                X1 = 0;
                Y1 = (Height - size) / 2;
            }
            X1 = X1 + size / 4;
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
                size = Height;
                X1 = (Width - Height * 4) / 2;
                Y1 = 0;
            }
            else
            {
                size = Width / 4;
                X1 = 0;
                Y1 = (Height - size) / 2;
            }
            X1 = X1 + size / 4;
        }
    }
}
