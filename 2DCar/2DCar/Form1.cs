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
        private bool isOverLapped = false;
        private List<Control> ucs = new List<Control>();
        private carUC selectedCar;

        public Form1()
        {
            InitializeComponent();
            BackColor = Color.White;
            foreach (Control c in Controls) {
                if (c is carUC) {
                    c.Click += carClicked;
                    ucs.Add(c);
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
            //if ((sender as UserControl).Focused)
            //    isFocused = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textBox1.Text = "" +e.KeyChar;
            if (selectedCar!=null) {
                switch (e.KeyChar) {
                    case 'd':
                        if ((selectedCar.Left + 15) + selectedCar.Width < Width)
                        {
                            foreach (carUC car in ucs)
                            {

                                if (doOverLap(selectedCar, car, 15, 0) && selectedCar.Name!=car.Name)
                                {
                                    isOverLapped = true;
                                    break;
                                }
                            }
                            if(!isOverLapped)
                                selectedCar.Left += 15;

                            isOverLapped = false;
                        }
                        isOverLapped = false;
                        break;
                    case 'a':
                        if (selectedCar.Left - 15 >= 0)
                        {
                            foreach (carUC car in ucs)
                            {


                                if (doOverLap(selectedCar, car, -15, 0) && selectedCar.Name != car.Name)
                                {
                                    isOverLapped = true;
                                    break;
                                }
                            }
                            if (!isOverLapped)
                                selectedCar.Left -= 15;

                            isOverLapped = false;
                        }
                        isOverLapped = false;
                        break;
                    case 'w':
                        if (selectedCar.Top-15>=0) {
                            foreach (carUC car in ucs)
                            {
                                if (doOverLap(selectedCar, car, 0, -15) && selectedCar.Name != car.Name)
                                {
                                    isOverLapped = true;
                                    break;
                                }
                            }
                            if (!isOverLapped)
                                selectedCar.Top -= 15;
                        }
                        isOverLapped = false;
                        break;
                    case 's':
                        if ((selectedCar.Top+40)+selectedCar.Height<=Height) {
                            foreach (carUC car in ucs)
                            {
                                if (doOverLap(selectedCar, car, 0, 15) && selectedCar.Name != car.Name)
                                {
                                    isOverLapped = true;
                                    break;
                                }
                            }
                            if (!isOverLapped)
                                selectedCar.Top += 15;

                            isOverLapped = false;
                        }
                        isOverLapped = false;
                        break;
                }
            }
        }

        private bool doOverLap(carUC car1, carUC car2, int X, int Y)
        {
            if (car1.Location.X+X >= car2.Location.X && car1.Location.X+X <= (car2.Location.X + car2.Width) && car1.Location.Y+Y >= car2.Location.Y && car1.Location.Y+Y <= (car2.Location.Y + car2.Height))
            {
                return true;
            }
            else if ((car1.Location.X+X + car1.Width) >= car2.Location.X && (car1.Location.X+X + car1.Width) <= (car2.Location.X + car2.Width) && car1.Location.Y+Y >= car2.Location.Y && car1.Location.Y+Y <= (car2.Location.Y + car2.Height))
            {
                return true;
            }
            else if (car1.Location.X+X >= car2.Location.X && car1.Location.X+X <= (car2.Location.X + car2.Width) && (car1.Location.Y+Y + car1.Height) >= car2.Location.Y && (car1.Location.Y+Y + car1.Height) <= (car2.Location.Y + car2.Height))
            {
                return true;
            }
            else if ((car1.Location.X+X + car1.Width) >= car2.Location.X && (car1.Location.X+X + car1.Width) <= (car2.Location.X + car2.Width) && (car1.Location.Y+Y + car1.Height) >= car2.Location.Y && (car1.Location.Y+Y + car1.Height) <= (car2.Location.Y + car2.Height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (selectedCar != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        if ((selectedCar.Left + 10) + selectedCar.Width < Width)
                            selectedCar.Left += 15;
                        break;
                    case Keys.Left:
                        if (selectedCar.Left >= 0)
                            selectedCar.Left -= 15;
                        break;
                }
            }
        }
    }
}
