using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DCar
{
    public partial class Form1 : Form
    {

        private Graphics g;
        private bool isFocused = false;
        private List<Control> ucs = new List<Control>();
        private carUC selectedCar;

        public Form1()
        {
            InitializeComponent();
            BackColor = Color.White;
            foreach (Control c in Controls) {
                if (c is carUC) {
                    c.Click += carClicked;
                }
            }
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            //g.FillRectangle(Brushes.Black, 0, carUC1.Location.Y + carUC1.Height, Width, 15);
        }

        private void carClicked(Object s,EventArgs e) {

            selectedCar = s as carUC;
        }

        
        private void carUC1_Click(object sender, EventArgs e)
        {
            if ((sender as UserControl).Focused)
                isFocused = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (selectedCar!=null) {
                switch (e.KeyChar) {
                    case 'd':
                        if ((selectedCar.Left+10)+selectedCar.Width<Width)
                            selectedCar.Left += 15;
                        break;
                    case 'a':
                        if (selectedCar.Left >= 0)
                            selectedCar.Left -= 15;
                        break;
                }
            }
        }
    }
}
