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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (Control control in ControlsPanel.Controls)
            {
                control.Hide();
            }
            WarningLabel.Text="";
        }

        public static List<Category> categories = new List<Category>();
        public static List<Expense> Expenses = new List<Expense>();

        private void HideAndShow(Control sender)
        {
            foreach (Control control in ControlsPanel.Controls)
            {
                if (control.Name != sender.Name)
                {
                    control.Hide();
                }
                else
                {
                    control.Show();
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            HideAndShow(AddExpensePanel);

            AddExpensePanel.Height = 350;
            AddExpensePanel.Width = 550;
            int X = (ControlsPanel.Width / 2) - (int)(AddExpensePanel.Width/3.2) ;
            int Y = (ControlsPanel.Height / 2) - AddExpensePanel.Height / 2;
            AddExpensePanel.Location = new Point(X,Y);
        }

        private void StoreCategory_Click(object sender, EventArgs e)
        {
            string CateName = CategoryTB.Text;
            Decimal Limit = LimitNB.Value;
            if (CateName == "" || LimitNB.Value == LimitNB.Minimum)
            {
                WarningLabel.Text = "Fields are Empty";
            }
            else if (categories.Any(item => item.CategoryName == CateName))
            {
                WarningLabel.Text = "Category Availble";
            }
            else
            {
                categories.Add(new Category() {CategoryName=CateName,Limit=Limit });
                CategoryCB.Items.Add(CateName);
                WarningLabel.Text = "Added Successfully";
            }
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            HideAndShow(AddCategoryPanel);

            AddCategoryPanel.Height = 250;
            AddCategoryPanel.Width = 500;
            int X = (ControlsPanel.Width / 2) - AddCategoryPanel.Width / 2;
            int Y = (ControlsPanel.Height / 2) - AddCategoryPanel.Height / 2;
            AddCategoryPanel.Location = new Point(X+50, Y);
        }

        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            string CateName = CategoryCB.Text;
            Decimal Amount = AmountNB.Value;
            DateTime Date = DateDTP.Value.Date;
            if (CateName == "" || AmountNB.Value == AmountNB.Minimum)
            {
                WarningLabel.Text = "Fields are Empty";
                return;
            }

            if (CheckLimit(CateName,Amount,Date))
            {
                WarningLabel.Text = "Limit Exceed...!";
            }
            else
                WarningLabel.Text = "Expense Added Successfully";

            Expenses.Add(new Expense() {category=CateName,Amount=Amount,Date=Date});
        }

        private bool CheckLimit(string CateName,Decimal Amount, DateTime Date)
        {
            int Month = Date.Month;
            int Year = Date.Year;

            Decimal ExpenseLimit = 0;
            Decimal CurrentLimit = Amount;

            foreach (var cate in categories)
            {
                if (cate.CategoryName==CateName)
                {
                    ExpenseLimit = cate.Limit;
                    break;
                }
            }

            foreach (var expense in Expenses)
            {
                if (expense.Date.Month==Month && expense.Date.Year==Year && expense.category==CateName)
                {
                    CurrentLimit += expense.Amount;
                }
            }

            if (CurrentLimit > ExpenseLimit)
                return true;
            else
                return false;
        }

        private void ViewExpenses_Click(object sender, EventArgs e)
        {
            HideAndShow(DataView);

            DataView.Dock = DockStyle.Fill;
        }
    }
}
