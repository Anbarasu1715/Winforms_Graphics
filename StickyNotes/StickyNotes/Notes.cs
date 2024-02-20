﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            EditorPanel.Visible = false;
            this.TransparencyKey = Color.Magenta;
            this.BackColor = Color.Magenta;
            brush = new SolidBrush(ColorTranslator.FromHtml("#333333"));
            HomePanel.BackColor = ColorTranslator.FromHtml("#E6B905");
            Editor_TextBox.Location = new Point(0,HomePanel.Height);
            Editor_TextBox.Size = new Size(Width,Height-HomePanel.Height-Option_Panel.Height);
            Editor_TextBox.BackColor = ColorTranslator.FromHtml("#333333");
            Option_Panel.BackColor = ColorTranslator.FromHtml("#333333");
            Bold_PB.BackColor = ColorTranslator.FromHtml("#333333");
            Italic_PB.BackColor = ColorTranslator.FromHtml("#333333");
            Underline_PB.BackColor = ColorTranslator.FromHtml("#333333");
            Line_PB.BackColor = ColorTranslator.FromHtml("#333333");
            Points_pB.BackColor = ColorTranslator.FromHtml("#333333");
            Image_PB.BackColor = ColorTranslator.FromHtml("#333333");

            Color1.BackColor = ColorTranslator.FromHtml("#E6B904");
            Color2.BackColor = ColorTranslator.FromHtml("#65BA5A");
            Color3.BackColor = ColorTranslator.FromHtml("#EA86C2");
            Color4.BackColor = ColorTranslator.FromHtml("#B07FE0");
            Color5.BackColor = ColorTranslator.FromHtml("#59C0E7");
            Color6.BackColor = ColorTranslator.FromHtml("#989898");
        }

        private Graphics graphics;
        private Color OriginalColor;
        private Color HeaderColor;
        private Color SelectedColor;
        private Brush brush;

        public EventHandler<string> OnTextChange;

        public string ContentText { get;   set; }

        private void Notes_Paint(object sender, PaintEventArgs e)
        {
            graphics = CreateGraphics();
            GraphicsPath path = new GraphicsPath();

            AddRoundRect(path, 0, 0, Width, Height, 10);
            graphics.FillPath(brush, path);

            EditorPanel.BackColor = ColorTranslator.FromHtml("#3B3B3B");
            label4.BackColor = ColorTranslator.FromHtml("#3B3B3B");
            label5.BackColor = ColorTranslator.FromHtml("#3B3B3B");
            pictureBox1.BackColor = ColorTranslator.FromHtml("#3B3B3B");
            pictureBox2.BackColor = ColorTranslator.FromHtml("#3B3B3B");

            graphics.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#E6B905")),0,0,Width,5);
        }

        private void Editor_TextBox_TextChanged(object sender, EventArgs e)
        {
            OnTextChange?.Invoke(sender, Editor_TextBox.Rtf);
        }

        private void AddRoundRect(GraphicsPath path, int x, int y, int width, int height, int cornerRadius)
        {
            path.Reset();

            RectangleF rect = new RectangleF(x, y, width, height);

            float radius = cornerRadius * 2;

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
        }

        private void ShowPanel1()
        {
            HomePanel.Visible = true;
            EditorPanel.Visible = false;
        }

        private void ShowPanel2()
        {
            HomePanel.Visible = false;
            EditorPanel.Visible = true;
            EditorPanel.Location = new Point(0,0);
            EditorPanel.BringToFront();
            Editor_TextBox.SendToBack();
        }

        private void ChangeColor(Object sender) {
            Label label = (sender as Label);
            label.BackColor = AdjustColorContrast(label.BackColor, 0.2f);
        }

        private void Exit_Lbl_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(sender);
            //Exit_Lbl.BackColor = ColorTranslator.FromHtml("#FFDF66");
        }

        private void Exit_Lbl_MouseLeave(object sender, EventArgs e)
        {
            //Exit_Lbl.BackColor = ColorTranslator.FromHtml("#E6B905");
            Exit_Lbl.BackColor = SelectedColor;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(sender);
            //label2.BackColor = ColorTranslator.FromHtml("#FFDF66");
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            //label2.BackColor = ColorTranslator.FromHtml("#E6B905");
            label2.BackColor = SelectedColor;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(sender);
            //label1.BackColor = ColorTranslator.FromHtml("#FFDF66");
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            //label1.BackColor = ColorTranslator.FromHtml("#E6B905");
            label1.BackColor = SelectedColor;
        }

        private void Exit_Lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = ColorTranslator.FromHtml("#414141");
            label4.BackColor = ColorTranslator.FromHtml("#414141");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = ColorTranslator.FromHtml("#414141");
            label5.BackColor = ColorTranslator.FromHtml("#414141");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = ColorTranslator.FromHtml("#3B3B3B");
            pictureBox2.BackColor = ColorTranslator.FromHtml("#3B3B3B");
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = ColorTranslator.FromHtml("#3B3B3B");
            pictureBox1.BackColor = ColorTranslator.FromHtml("#3B3B3B");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ShowPanel2();
        }

        private void Notes_Click(object sender, EventArgs e)
        {
            ShowPanel1();
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

        private void Color1_MouseEnter(object sender, EventArgs e)
        {
            Label label = (sender as Label);
            OriginalColor = label.BackColor;
            label.BackColor = AdjustColorContrast(label.BackColor, 0.2f);
        }

        private void Color1_MouseLeave(object sender, EventArgs e)
        {
            if (OriginalColor != null)
                (sender as Label).BackColor = OriginalColor;
        }

        private void Color1_Click(object sender, EventArgs e)
        {
            HeaderColor = (sender as Label).BackColor;
            brush = new SolidBrush(HeaderColor);
            Editor_TextBox.BackColor = HeaderColor;
            HomePanel.BackColor = OriginalColor;
            Exit_Lbl.BackColor = OriginalColor;
            label1.BackColor = OriginalColor;
            label2.BackColor = OriginalColor;
            SelectedColor = OriginalColor;
            Invalidate();
        }

        private void Editor_TextBox_Click(object sender, EventArgs e)
        {
            ShowPanel1();
        }

        private void Image_PB_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (sender as PictureBox);
            pb.BackColor = AdjustColorContrast(pb.BackColor,0.2f);
        }

        private void Image_PB_MouseLeave(object sender, EventArgs e)
        {
            if (OriginalColor != null)
                (sender as PictureBox).BackColor = ColorTranslator.FromHtml("#333333");
        }

        private void Bold_PB_Click(object sender, EventArgs e)
        {
            switch ((sender as PictureBox).Name)
            {
                case "Bold_PB":
                    ToggleFormatting(FontStyle.Bold);
                    break;
                case "Italic_PB":
                    ToggleFormatting(FontStyle.Italic);
                    break;
                case "Underline_PB":
                    ToggleFormatting(FontStyle.Underline);
                    break;
                case "Line_PB":
                    ToggleFormatting(FontStyle.Strikeout);
                    break;
                case "Points_pB":
                    ToggleBulletPoint();
                    break;
                case "Image_PB":
                    
                    break;
            }
        }

        private void ToggleFormatting(FontStyle fontStyle)
        {
            Editor_TextBox.SelectionFont = new Font(Editor_TextBox.Font, Editor_TextBox.SelectionFont.Style ^ fontStyle);
        }

        private void ToggleBulletPoint()
        {
            int selectionStart = Editor_TextBox.SelectionStart;

            Editor_TextBox.SelectionBullet = !Editor_TextBox.SelectionBullet;

            Editor_TextBox.SelectionStart = selectionStart;
            Editor_TextBox.Focus();
        }
    }
}

