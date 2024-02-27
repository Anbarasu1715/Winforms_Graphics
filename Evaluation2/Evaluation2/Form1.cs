using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NewExpensePanel.Visible = false;
            CategoryPanel.Visible = false;
            WarningLabel.Visible = false;
        }

        public List<Category> categories = new List<Category>();
        public List<Expense> Expenses = new List<Expense>();
        private ViewData ViewData;
        private OptionForm optionForm;

        public static EventHandler<List<Category>> OnCategorySend;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            NewExpensePanel.Visible = true;
            CategoryPanel.Visible = false;
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            NewExpensePanel.Visible = false;
            CategoryPanel.Visible = true;
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category() {
                ExpenseName = CategoryTB.Text,
                Limit = int.Parse(LimitTB.Text)
            };

            categories.Add(category);

            ExpenseCB.Items.Add(category.ExpenseName);
        }

        private void StoreBtn_Click(object sender, EventArgs e)
        {
            WarningLabel.Visible = false;
            if (ExpenseCB.Items.Count == 0)
            {
                WarningLabel.Text = "Category is Empty...";
                WarningLabel.Visible = true;
            }
            else
            {
                Expense expense = new Expense();

                string cate = ExpenseCB.Text;
                int amt = int.Parse(AmountTB.Text);
                string date = DateTB.Text;

                int CateLimit=0;
                foreach (var Item in categories)
                {
                    if (Item.ExpenseName==cate)
                    {
                        CateLimit = Item.Limit;
                        break;
                    }
                }

                string[] curDate= date.Split(' ');
                int curCateExpense=0;
                foreach (var Item in Expenses)
                {
                    
                    string[] arr= Item.Date.Split(' ');
                    if (arr[1]==curDate[1] && arr[2]==curDate[2])
                    {
                        curCateExpense += Item.Amount;
                    }
                }

                if (curCateExpense + amt > CateLimit)
                {
                    WarningLabel.Text = "This Expense Monthly Limit Exceed";
                }
                else
                {
                    Expenses.Add(expense);
                    expense.AddExpense(cate, amt, date);
                }
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

            optionForm?.Dispose();

            optionForm = new OptionForm();
            optionForm.OnCategoryClick += SendCategory;
            optionForm.OnDisplayAll += DisplayAllData;
            optionForm.OnEnterClick += CheckDataByCategory;
            optionForm.OnSubmitClick += CheckByDate;
            optionForm.Show();

            //ViewData?.Dispose();
            //ViewData = new ViewData();
            //ViewData.OnDataReceive?.Invoke(this,Expenses);
            //ViewData.Show();
        }

        private void CheckByDate(object sender, string e)
        {
            newList.Clear();

            string[] arr = e.Split(' ');
            foreach (var i in Expenses)
            {
                string[] date = i.Date.Split(' ');
                if (int.Parse(date[0])>= int.Parse(arr[0]) && int.Parse(date[2])>= int.Parse(arr[arr.Length-1]))
                {
                    newList.Add(i);
                }
            }
            DisplayData();
        }

        public List<Expense> newList = new List<Expense>();
        private void CheckDataByCategory(object sender, string e)
        {
            newList.Clear();

            foreach (var i in Expenses) {
                if (i.Category == e) {
                    newList.Add(i);
                }
            }
            DisplayData();
        }

        private void DisplayAllData(object sender, EventArgs e)
        {
            ViewData?.Dispose();
            ViewData = new ViewData();
            ViewData.OnDataReceive?.Invoke(this, Expenses);
            ViewData.Show();
        }

        private void DisplayData()
        {
            ViewData?.Dispose();
            ViewData = new ViewData();
            ViewData.OnDataReceive?.Invoke(this, newList);
            ViewData.Show();

        }

        private void SendCategory(object sender, EventArgs e)
        {
            OnCategorySend?.Invoke(this,categories);
        }
    }
}
