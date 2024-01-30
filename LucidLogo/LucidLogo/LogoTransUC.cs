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

        }

        private void initialCoordinates() {
            Point[] Poly1 = {
                new Point(((minPoint*110)/304)+X1,(minPoint*46)/286+Y1),
                new Point(((minPoint*151)/304)+X1,(minPoint*5)/286+Y1),
                new Point(((minPoint*173)/304)+X1,(minPoint*26)/286+Y1),
                new Point(((minPoint*170)/304)+X1,(minPoint*101/286)+Y1)
            };
            points.Add(Poly1);

            Point[] Poly2 = {
                new Point((minPoint*176)/304+X1,(minPoint*29)/286+Y1),
                new Point((minPoint*215)/304+X1,(minPoint*68)/286+Y1),
                new Point((minPoint*179)/304+X1,(minPoint*101)/286+Y1)
            };
            points.Add(Poly2);

            Point[] Poly3 = {
                new Point((minPoint*218)/304+X1,(minPoint*71)/286+Y1),
                new Point((minPoint*257)/304+X1,(minPoint*109)/286+Y1),
                new Point((minPoint*185)/304+X1,(minPoint*106)/286+Y1)
            };
            points.Add(Poly3);

            Point[] Poly4 = {
                new Point((minPoint*185)/304+X1,(minPoint*115)/286+Y1),
                new Point((minPoint*259)/304+X1,(minPoint*112)/286+Y1),
                new Point((minPoint*286)/304+X1,(minPoint*139)/286+Y1),
                new Point((minPoint*280)/304+X1,(minPoint*142)/286+Y1),
                new Point((minPoint*273)/304+X1,(minPoint*145)/286+Y1),
                new Point((minPoint*265)/304+X1,(minPoint*149)/286+Y1),
                new Point((minPoint*253)/304+X1,(minPoint*156)/286+Y1),
                new Point((minPoint*241)/304+X1,(minPoint*164)/286+Y1),
                new Point((minPoint*236)/304+X1,(minPoint*168)/286+Y1)
            };
            points.Add(Poly4);

            Point[] Poly5 = {
                new Point((minPoint*179)/304+X1,(minPoint*121)/286+Y1),
                new Point((minPoint*232)/304+X1,(minPoint*170)/286+Y1),
                new Point((minPoint*225)/304+X1,(minPoint*176)/286+Y1),
                new Point((minPoint*216)/304+X1,(minPoint*183)/286+Y1),
                new Point((minPoint*208)/304+X1,(minPoint*191)/286+Y1),
                new Point((minPoint*200)/304+X1,(minPoint*199)/286+Y1),
                new Point((minPoint*190)/304+X1,(minPoint*211)/286+Y1),
                new Point((minPoint*176)/304+X1,(minPoint*230)/286+Y1),
            };
            points.Add(Poly5);

            Point[] Poly6 = {
                new Point((minPoint*173)/304+X1,(minPoint*233)/286+Y1),
                new Point((minPoint*166)/304+X1,(minPoint*245)/286+Y1),
                new Point((minPoint*161)/304+X1,(minPoint*254)/286+Y1),
                new Point((minPoint*157)/304+X1,(minPoint*263)/286+Y1),
                new Point((minPoint*151)/304+X1,(minPoint*274)/286+Y1),
                new Point((minPoint*145)/304+X1,(minPoint*261)/286+Y1),
                new Point((minPoint*141)/304+X1,(minPoint*252)/286+Y1),
                new Point((minPoint*137)/304+X1,(minPoint*244)/286+Y1),
                new Point((minPoint*132)/304+X1,(minPoint*236)/286+Y1),
                new Point((minPoint*129)/304+X1,(minPoint*230)/286+Y1),
                new Point((minPoint*124)/304+X1,(minPoint*223)/286+Y1),
                new Point((minPoint*119)/304+X1,(minPoint*215)/286+Y1),
                new Point((minPoint*112)/304+X1,(minPoint*206)/286+Y1),
                new Point((minPoint*98)/304+X1,(minPoint*190)/286+Y1),
                new Point((minPoint*170)/304+X1,(minPoint*122)/286+Y1)
            };
            points.Add(Poly6);

            Point[] Poly7 = {
                new Point((minPoint*96)/304+X1,(minPoint*188)/286+Y1),
                new Point((minPoint*83)/304+X1,(minPoint*177)/286+Y1),
                new Point((minPoint*74)/304+X1,(minPoint*170)/286+Y1),
                new Point((minPoint*67)/304+X1,(minPoint*165)/286+Y1),
                new Point((minPoint*59)/304+X1,(minPoint*160)/286+Y1),
                new Point((minPoint*51)/304+X1,(minPoint*155)/286+Y1),
                new Point((minPoint*43)/304+X1,(minPoint*151)/286+Y1),
                new Point((minPoint*33)/304+X1,(minPoint*146)/286+Y1),
                new Point((minPoint*16)/304+X1,(minPoint*139)/286+Y1),
                new Point((minPoint*42)/304+X1,(minPoint*113)/286+Y1),
                new Point((minPoint*164)/304+X1,(minPoint*115)/286+Y1)
            };
            points.Add(Poly7);

            Point[] Poly8 = {
                new Point((minPoint*108)/304+X1,(minPoint*47)/286+Y1),
                new Point((minPoint*164)/304+X1,(minPoint*107)/286+Y1),
                new Point((minPoint*45)/304+X1,(minPoint*111)/286+Y1),
            };
            points.Add(Poly8);

            LoadingTrans();
            timer.Start();
        }

        private void LogoTransUC_Load(object sender, EventArgs e)
        {
            initialCoordinates();
        }

        private void LogoTransUC_Resize(object sender, EventArgs e)
        {
           minPoint= Math.Min(Width,Height);
            if (Height > Width) {
                X1 = 0;
                Y1 = (Height / 2) - (Width / 2);
            }
            else if (Width>Height) {
                Y1 = 0;
                X1 = ((Width/2)-Height/2);
            }
        }
    }
}
