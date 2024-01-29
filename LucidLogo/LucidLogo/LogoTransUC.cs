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
        }

        private Graphics g;

        private void LogoTransUC_Paint(object sender, PaintEventArgs e)
        {

            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            Point[] Poly1 = {
                new Point((Width*110)/304,(Height*46)/286),
                new Point((Width*151)/304,(Height*5)/286),
                new Point((Width*173)/304,(Height*26)/286),
                new Point((Width*170)/304,(Height*101/286))
            };

            Point[] Poly2 = {
                new Point((Width*176)/304,(Height*29)/286),
                new Point((Width*215)/304,(Height*68)/286),
                new Point((Width*179)/304,(Height*101)/286)
            };

            Point[] Poly3 = {
                new Point((Width*218)/304,(Height*71)/286),
                new Point((Width*257)/304,(Height*109)/286),
                new Point((Width*185)/304,(Height*106)/286)
            };

            Point[] Poly4 = {
                new Point((Width*185)/304,(Height*115)/286),
                new Point((Width*259)/304,(Height*112)/286),
                new Point((Width*286)/304,(Height*139)/286),
                new Point((Width*280)/304,(Height*142)/286),
                new Point((Width*273)/304,(Height*145)/286),
                new Point((Width*265)/304,(Height*149)/286),
                new Point((Width*253)/304,(Height*156)/286),
                new Point((Width*241)/304,(Height*164)/286),
                new Point((Width*236)/304,(Height*168)/286)
            };

            Point[] Poly5 = {
                new Point((Width*179)/304,(Height*121)/286),
                new Point((Width*232)/304,(Height*170)/286),
                new Point((Width*225)/304,(Height*176)/286),
                new Point((Width*216)/304,(Height*183)/286),
                new Point((Width*208)/304,(Height*191)/286),
                new Point((Width*200)/304,(Height*199)/286),
                new Point((Width*190)/304,(Height*211)/286),
                new Point((Width*176)/304,(Height*230)/286),
            };

            Point[] Poly6 = {
                new Point((Width*173)/304,(Height*233)/286),
                new Point((Width*166)/304,(Height*245)/286),
                new Point((Width*161)/304,(Height*254)/286),
                new Point((Width*157)/304,(Height*263)/286),
                new Point((Width*151)/304,(Height*274)/286),
                new Point((Width*145)/304,(Height*261)/286),
                new Point((Width*141)/304,(Height*252)/286),
                new Point((Width*137)/304,(Height*244)/286),
                new Point((Width*132)/304,(Height*236)/286),
                new Point((Width*129)/304,(Height*230)/286),
                new Point((Width*124)/304,(Height*223)/286),
                new Point((Width*119)/304,(Height*215)/286),
                new Point((Width*112)/304,(Height*206)/286),
                new Point((Width*98)/304,(Height*190)/286),
                new Point((Width*170)/304,(Height*122)/286)
            };

            Point[] Poly7 = {
                new Point((Width*96)/304,(Height*188)/286),
                new Point((Width*83)/304,(Height*177)/286),
                new Point((Width*74)/304,(Height*170)/286),
                new Point((Width*67)/304,(Height*165)/286),
                new Point((Width*59)/304,(Height*160)/286),
                new Point((Width*51)/304,(Height*155)/286),
                new Point((Width*43)/304,(Height*151)/286),
                new Point((Width*33)/304,(Height*146)/286),
                new Point((Width*16)/304,(Height*139)/286),
                new Point((Width*42)/304,(Height*113)/286),
                new Point((Width*164)/304,(Height*115)/286)
            };

            Point[] Poly8 = {
                new Point((Width*108)/304,(Height*48)/286),
                new Point((Width*164)/304,(Height*107)/286),
                new Point((Width*45)/304,(Height*111)/286),
            };

            Brush brush = new SolidBrush(Color.FromArgb(13, 98, 177));
            
            g.FillPolygon(brush,Poly1);
            g.FillPolygon(brush,Poly2);
            g.FillPolygon(brush,Poly3);
            g.FillPolygon(brush,Poly4);
            g.FillPolygon(brush,Poly5);
            g.FillPolygon(brush,Poly6);
            g.FillPolygon(brush,Poly7);
            g.FillPolygon(brush,Poly8);

        }
    }
}
