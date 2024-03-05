using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation2._1
{
    public partial class DateAndTimeUC : UserControl
    {
        public DateAndTimeUC()
        {
            InitializeComponent();

            GenerateToday();
        }

        private bool isToday = true;

        private int Getday(string day)
        {
            switch (day) {
                case "Monday":
                    return 1;
                case "Tuesday":
                    return 2;
                case "Wednesday":
                    return 3;
                case "Thursday":
                    return 4;
                case "Friday":
                    return 5;
                case "Saturday":
                    return 6;
                case "Sunday":
                    return 7;
                default:
                    return 0;
            }
        }
        

        private void setToday(int curMonth, int curYear, DayOfWeek Day) {

            int startIndexY = Getday(Day+"");

            int FirstDay = 1;

            for (int i=0;i<7;i++) {
                for (int j=startIndexY-1;j<7;j++) {
                    try
                    {

                        DateTime checkDay = new DateTime(curYear, curMonth, FirstDay);

                        Label newLbl = new Label();
                        newLbl.AutoSize = false;
                        newLbl.Dock = DockStyle.Fill;
                        newLbl.Text = FirstDay + "";
                        newLbl.BackColor = Color.White;
                        newLbl.TextAlign = ContentAlignment.MiddleCenter;


                        if (isToday && FirstDay == (DateTime.Today).Day)
                        {
                            newLbl.BackColor = Color.Blue;
                            newLbl.ForeColor = Color.White;
                        }
                        else {
                            newLbl.MouseEnter += MouseEnter;
                            newLbl.MouseLeave += MouseLeave;
                        }

                        DatePanel.Controls.Add(newLbl,j,i);
                        FirstDay++;
                    }
                    catch (Exception e)
                    {
                        break;
                    }
                }
                startIndexY = 1;
            }

        }

        private void MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).BackColor = ColorTranslator.FromHtml("#D7AC6A");
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).BackColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Remove() {
            for (int i=0;i<7;i++)
            {
                for (int j=0;j<7;j++) {
                    DatePanel.Controls.Remove(DatePanel.GetControlFromPosition(i,j));
                }
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Remove();
            isToday = false;
            int Month =int.Parse( MonthCB.Text);
            int Year = int.Parse(YearTB.Text);

            DateTime d = new DateTime(Year,Month,1);

            setToday(d.Month,d.Year,d.DayOfWeek);
        }

        private void GenerateToday(){
            Remove();
            isToday = true;
            DateTime CurrentDate = DateTime.Today;
            int curMonth = CurrentDate.Month;
            int curYear = CurrentDate.Year;
            int curDay = CurrentDate.Day;
            DayOfWeek Day = (new DateTime(curYear, curMonth, 1)).DayOfWeek;

            setToday(curMonth, curYear, Day);
            
        }

        private void CurDay_Click(object sender, EventArgs e)
        {
            GenerateToday();
        }
    }
}
