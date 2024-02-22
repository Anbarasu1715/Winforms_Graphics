using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class DisplayNote : UserControl
    {
        public DisplayNote()
        {
            InitializeComponent();
            TemplateColor = "#E6B905";
        }

        private Graphics graphics;
        private Brush brush;
        private string TemplateColor;
        private OptionForm optionForm;

        public EventHandler OnDoubleClick;
        public EventHandler<Point> OnOptionPanel;

        public void SetTime(string time)
        {
            TimeLabel.Text = time;
        }

        public void SetText(String Text)
        {
            DisplayTextBox.Text = Text;
        }

        public void SetHeight(int height)
        {
            this.Height += height;
            DisplayTextBox.Height += height;
        }

        private Color AdjustColorContrast(Color color, float contrastFactor)
        {
            float r = color.R / 255.0f;
            float g = color.G / 255.0f;
            float b = color.B / 255.0f;

            r = (r - 0.5f) * contrastFactor + 0.5f;
            g = (g - 0.5f) * contrastFactor + 0.5f;
            b = (b - 0.5f) * contrastFactor + 0.5f;

            r = Math.Max(0, Math.Min(1, r));
            g = Math.Max(0, Math.Min(1, g));
            b = Math.Max(0, Math.Min(1, b));

            return Color.FromArgb(color.A, (int)(r * 255), (int)(g * 255), (int)(b * 255));
        }

        public void setBrushColor(string color)
        {
            brush = new SolidBrush(ColorTranslator.FromHtml(color));
            TemplateColor = color;
            Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            graphics =e.Graphics;
            brush = new SolidBrush(ColorTranslator.FromHtml(TemplateColor));
            graphics.FillRectangle(brush, 0, 0, Width, 2);

            TimeLabel.BackColor = Color.Transparent;
            panel1.BackColor = AdjustColorContrast(ColorTranslator.FromHtml(TemplateColor),0.2f);
            DisplayTextBox.BackColor = panel1.BackColor;
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;

            Rectangle rect1 = new Rectangle(0,0,5,5);
            Rectangle rect2 = new Rectangle(9,0,5,5);
            Rectangle rect3 = new Rectangle(17,0,5,5);

            graphics.FillEllipse(new SolidBrush(Color.White),rect1);
            graphics.FillEllipse(new SolidBrush(Color.White),rect2);
            graphics.FillEllipse(new SolidBrush(Color.White),rect3);
        }

        private bool LimitExceed = false;
        internal void SetTextAndHeight(object sender, RichTextBox textBox)
        {
            //if (LimitExceed)
            //    return;


            DisplayTextBox.Text = textBox.Text;
            int visibleLines = textBox.GetLineFromCharIndex(textBox.GetCharIndexFromPosition(new Point(0, textBox.ClientRectangle.Bottom - 1))) + 1;

            if (visibleLines > 5)
            {
                //DisplayTextBox.Text = DisplayTextBox.Text.Substring(0,DisplayTextBox.Text.Length-20)+" seemore...";
                //LimitExceed = true;
                DisplayTextBox.Height = 130;
                this.Height = 130;
                Form1.ReLocate();
                return;
            }

            LimitExceed = true;

            int lineHeight = textBox.GetPositionFromCharIndex(textBox.GetFirstCharIndexFromLine(1)).Y;
            int maxVisibleHeight = lineHeight * 4;

            this.Height = Math.Min(textBox.GetPositionFromCharIndex(textBox.TextLength).Y, maxVisibleHeight) + 49;
            DisplayTextBox.Height = Math.Min(textBox.GetPositionFromCharIndex(textBox.TextLength).Y, maxVisibleHeight) + 49;

            Form1.ReLocate();
        }

        internal void ColorChange(object sender, ColorContrast colors)
        {
            TemplateColor = colors.OriginalColor+"";
            panel1.Invalidate();
        }

        private void DisplayTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OnDoubleClick?.Invoke(this,e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Point Loc = label1.PointToScreen(new Point(0,0));
            OnOptionPanel?.Invoke(optionForm, Loc);
        }

        private void DisplayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
