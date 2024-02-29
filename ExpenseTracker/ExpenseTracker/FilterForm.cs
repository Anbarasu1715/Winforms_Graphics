using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();

            CategoryCB.Items.Add("NA");
            foreach (var cat in Form1.categories)
            {
                CategoryCB.Items.Add(cat.CategoryName);
            }
        }

        public EventHandler<string> OnFilterClick;

        private bool CheckCategory()
        {
            if (CategoryCB.Text=="" || CategoryCB.Text == "NA")
                return false;
            else
                return true;
        }

        private void CateFilter_Click(object sender, EventArgs e)
        {
            Form1.DisplayExpenses.Clear();
            foreach (var expense in Form1.Expenses)
            {
                if(expense.category==CategoryCB.Text)
                    Form1.DisplayExpenses.Add(expense);
            }

            OnFilterClick?.Invoke(sender,"");
            this.Dispose();
        }

        private void DateFilter_Click(object sender, EventArgs e)
        {
            Filter(StartDate.Value, EndDate.Value);
        }

        private void Filter(DateTime Start,DateTime End)
        {
            Form1.DisplayExpenses.Clear();
            foreach (var expense in Form1.Expenses)
            {
                if (CheckCategory())
                {
                    if (expense.category == CategoryCB.Text && expense.Date >= Start.Date && expense.Date <= End.Date)
                        Form1.DisplayExpenses.Add(expense);
                }
                else
                {
                    if (expense.Date >= Start.Date && expense.Date <= End.Date)
                    {
                        Form1.DisplayExpenses.Add(expense);
                    }
                }
            }
            OnFilterClick?.Invoke(this, "");
            this.Dispose();
        }

        private void MonthFilter_Click(object sender, EventArgs e)
        {
            DateTime CurrentDate = DateTime.Today;
            int curMonth = CurrentDate.Month;
            int curYear = CurrentDate.Year;
            DateTime StartDate = new DateTime(curYear, curMonth, 1);

            Filter(StartDate,CurrentDate);
        }

        private void DailyFilter_Click(object sender, EventArgs e)
        {
            DateTime CurrentDate = DateTime.Today;
            Filter(CurrentDate, CurrentDate);
        }
    }
}
