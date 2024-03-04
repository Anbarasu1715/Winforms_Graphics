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

            Form1.FillComboBox(CategoryCB);
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

            if (CheckCategory())
            { 
                string Query = $"select * from expense where Category='{CategoryCB.Text}'";

                OnFilterClick?.Invoke(sender, Query);
                this.Dispose();
            }
            else
            {

            }
        }

        private void DateFilter_Click(object sender, EventArgs e)
        {
            Filter(StartDate.Value, EndDate.Value);
        }

        private void Filter(DateTime Start,DateTime End)
        {
            string query = $"select * from expense where Date >= '{Start:yyyy-MM-dd}' AND Date <= '{End:yyyy-MM-dd}'";

            if (CheckCategory())
            {
                query = $"select * from expense where Category='{CategoryCB.Text}' AND Date >= '{Start:yyyy-MM-dd}' AND Date <= '{End:yyyy-MM-dd}'";
            }

            OnFilterClick?.Invoke(this, query);
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
