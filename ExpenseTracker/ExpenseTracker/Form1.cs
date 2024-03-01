﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

            //DataBase Connection
            con = new MySqlConnection();
            string address = "server=localhost;port=3306;uid=root;pwd=lucid;database=expensetracker";
            con.ConnectionString = address;

            try
            {
                con.Open();
                //string query = "create table Expense(Id int,Category varchar(250),Amount Decimal(10,4),Date varchar(100))";
                //MySqlCommand cmd = new MySqlCommand(query,con);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            //Retrive category from Database
            string RetriveCategory = "select distinct Type from Categories";
            MySqlCommand RetriveCmd = new MySqlCommand(RetriveCategory, con);
            try
            {
                MySqlDataReader reader = RetriveCmd.ExecuteReader();
                while (reader.Read())
                {
                    string cate = reader.GetString(0);
                    CategoryCB.Items.Add(cate);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        MySqlConnection con;
        private MySqlCommand Command;

        private int RowIndex;
        private int ID=1050;

        public static List<Category> categories = new List<Category>();
        public static List<Expense> Expenses = new List<Expense>();
        public static List<Expense> DisplayExpenses = new List<Expense>();

        private void EstablishDB(Object sender, EventArgs e)
        {

            //string address = "server=localhost;uid=root;pwd=lucid;database=stickynotes";
            //MySqlConnection con = new MySqlConnection();
            //con.ConnectionString = address;
            //try
            //{

            //    con.Open();
            //    string query = "select * from persons";
            //    MySqlCommand cmd = new MySqlCommand(query, con);
            //    MySqlDataReader reader = cmd.ExecuteReader();

            //    string result = "";
            //    while (reader.Read())
            //    {
            //        result += "Id=" + reader["PersonID"] + "  Name=" + reader["FirstName"] + "  City=" + reader["City"] + "\n";
            //    }
            //    MessageBox.Show("connected");

            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

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
                WarningLabel.Text = "Category Available";
            }
            else
            {
                categories.Add(new Category() {CategoryName=CateName,Limit=Limit });
                CategoryCB.Items.Add(CateName);

                //Insert Category into table
                string InsertCate = $"Insert into categories values('{CateName}',{Limit})";
                //string InsertCate = $"Insert into categories values('Food',{Limit})";
                Command = new MySqlCommand(InsertCate,con);
                try
                {
                    Command.ExecuteNonQuery();
                    //Command?.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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

            ID++;
            Expenses.Add(new Expense() {ID=ID,category=CateName,Amount=Amount,Date=Date});

            string date = Date.Date.ToShortDateString();

            //Insert values
            string CheckQuery = "select max(Id) from expense";
            MySqlCommand CheckCmd = new MySqlCommand(CheckQuery,con);
            object result = 1;
            try
            {
                result = (CheckCmd.ExecuteScalar());
                ID = int.Parse(result + "");
                ID++;

                string InsertQuery = $"insert into expense values({ID},'{CateName}',{Amount},'{date}');";
                MySqlCommand InsertCmd = new MySqlCommand(InsertQuery, con);
                InsertCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            DataView.Rows.Clear();
            DisplayExpenses.Clear();

            DataView.Dock = DockStyle.Fill;
            DataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataView.DefaultCellStyle.Font = new Font("Segoe UI semibold",9);
            DataView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 12);

            foreach (var expense in Expenses)
            {
                DisplayExpenses.Add(expense);
            }

            DisplayContent();
        }

        private void DisplayContent()
        {
            DataView.Rows.Clear();

            decimal TotalAmount = 0;

            foreach (var expense in DisplayExpenses)
            {
                RowIndex = DataView.Rows.Add();
                DataView.Rows[RowIndex].Cells[0].Value = expense.category;
                DataView.Rows[RowIndex].Cells[1].Value = expense.Amount;
                DataView.Rows[RowIndex].Cells[2].Value = expense.Date.Date.ToString("dd-MM-yyyy");
                DataView.Rows[RowIndex].Cells[3].Value = expense.ID;

                TotalAmount += expense.Amount;
            }

            ResultLbl.Text = "" + TotalAmount;
        }

        public void DisplayUpadatedList(object sender,string e)
        {
            DisplayContent();
        }

        private UpdateForm updateForm;
        private int SelectedRowIndex;

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedCells.Count>0)
            {
                updateForm?.Dispose();
                updateForm = new UpdateForm();
                updateForm.Show();
                updateForm.OnUpdateData += SetWarning;
                updateForm.OnUpdateData += DisplayUpadatedList;

                DataGridViewCell SelectedCell = DataView.SelectedCells[0];
                SelectedRowIndex=SelectedCell.RowIndex;

                string cate = DataView.Rows[SelectedRowIndex].Cells[0].Value.ToString();
                decimal amt=(decimal) DataView.Rows[SelectedRowIndex].Cells[1].Value;
                DateTime DateFormat;
                DateTime FormattedDate = DateTime.MinValue;
                if (DateTime.TryParseExact(DataView.Rows[SelectedRowIndex].Cells[2].Value+"", "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateFormat))
                {
                    FormattedDate = DateFormat;
                }
                int id = (int)DataView.Rows[SelectedRowIndex].Cells[3].Value;

                updateForm.SetData(id,cate,amt, FormattedDate);
            }
        }

        public void SetWarning(object sender,string text)
        {
            WarningLabel.Text = text;
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            updateForm?.Dispose();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedCells.Count > 0)
            {
                DataGridViewCell SelectedCell = DataView.SelectedCells[0];
                SelectedRowIndex = SelectedCell.RowIndex;
                DisplayExpenses.Clear();

                int id =int.Parse(DataView.Rows[SelectedRowIndex].Cells[3].Value+"");
                int ExpenseToRemoveIndex=0;
                int count = 0;

                foreach (var expense in Expenses)
                {
                    if (expense.ID==id)
                    {
                        ExpenseToRemoveIndex = count;
                    }
                    else
                        DisplayExpenses.Add(expense);

                    count++;
                }

                Expenses.RemoveAt(ExpenseToRemoveIndex);

                DisplayContent();
            }
        }

        private FilterForm FilterForm;
        private void FilterBtn_Click(object sender, EventArgs e)
        {
            FilterForm?.Dispose();
            if (Expenses.Count > 0)
            {
                FilterForm = new FilterForm();
                FilterForm.Show();
                FilterForm.OnFilterClick += DisplayUpadatedList;
            }
            else
                WarningLabel.Text = "List Empty...!";
        }
    }
}