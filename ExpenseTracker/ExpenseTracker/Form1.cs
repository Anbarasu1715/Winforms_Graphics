using System;
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

<<<<<<< HEAD

//Original Copy
=======
//GIT CHANGED
>>>>>>> 1d04d25cffa40420a38e02d5be08efef2632fb8d
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
            //string address = "server=192.168.3.55;port=3306;uid=user2;pwd=user2;database=practice";
            con.ConnectionString = address;

            try
            {
                con.Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                
            }

            FillComboBox(CategoryCB);
        }

        public static MySqlConnection con;
        private MySqlCommand Command;

        private int RowIndex;
        private int ID=1050;
        public static string CurrentQuery = "Select * from expense";

        public static void FillComboBox(Control cb)
        {
            //Retrive category from Database
            string RetriveCategory = "select distinct Type from Categories";
            MySqlCommand RetriveCmd = new MySqlCommand(RetriveCategory, con);
            try
            {
                MySqlDataReader reader = RetriveCmd.ExecuteReader();
                while (reader.Read())
                {
                    string cate = reader.GetString(0);
                    (cb as ComboBox).Items.Add(cate);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
            else
            {
                //Insert Category into table
                string InsertCate = $"Insert into categories values('{CateName}',{Limit})";
                Command = new MySqlCommand(InsertCate,con);
                try
                {
                    Command.ExecuteNonQuery();
                    CategoryCB.Items.Add(CateName);
                    WarningLabel.Text = "Added Successfully";
                }
                catch (Exception ex)
                {
                    WarningLabel.Text = "Category Available";
                }
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

            string date = Date.Date.ToString("yyyy-MM-dd");

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

            decimal LimitAmt=0;
            decimal totalAmount=Amount;

            DateTime StartDate = new DateTime(Year,Month,1);
            DateTime EndDate = StartDate.AddMonths(1).AddDays(-1);

            string query = $"SELECT SUM(Amount) AS TotalAmount FROM expense WHERE Category = '{CateName}' AND Date >= '{StartDate:yyyy-MM-dd}' And Date <='{EndDate:yyyy-MM-dd}'";
            Command = new MySqlCommand(query,con);

            string CheckQuery = $"select CateGory_Limit from categories where Type='{CateName}'";
            MySqlCommand newCmd = new MySqlCommand(CheckQuery,con);
            try
            {
                object result = Command.ExecuteScalar();
                LimitAmt = Convert.ToDecimal(newCmd.ExecuteScalar());

                if (result != null && result != DBNull.Value)
                {
                    totalAmount += Convert.ToDecimal(result);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            if (totalAmount > LimitAmt)
                return true;
            else
                return false;
        }

        private void ViewExpenses_Click(object sender, EventArgs e)
        {
            HideAndShow(DataView);
            DataView.Rows.Clear();

            DataView.Dock = DockStyle.Fill;
            DataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataView.DefaultCellStyle.Font = new Font("Segoe UI semibold",9);
            DataView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 12);
            DataView.ReadOnly = true;

            string Query = "select * from expense";
            DisplayContent(Query);
        }

        private void DisplayContent(string Query)
        {
            DataView.Rows.Clear();
            decimal TotalAmount = 0;
            CurrentQuery = Query;

            Command = new MySqlCommand(Query,con);
            MySqlDataReader reader=null;
            try
            {
                reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    RowIndex = DataView.Rows.Add();
                    DataView.Rows[RowIndex].Cells[0].Value = reader.GetString(1);
                    DataView.Rows[RowIndex].Cells[1].Value = reader.GetDecimal(2);
                    DataView.Rows[RowIndex].Cells[2].Value = reader.GetDateTime(3).ToShortDateString();
                    DataView.Rows[RowIndex].Cells[3].Value = reader.GetInt32(0);


                    //RowIndex = DataView.Rows.Add();
                    //DataView.Rows[RowIndex].Cells[2].Value = reader.GetInt32(1);
                    //DataView.Rows[RowIndex].Cells[1].Value = reader.GetDouble(2);
                    ////DataView.Rows[RowIndex].Cells[2].Value = reader.GetString(3);
                    //DataView.Rows[RowIndex].Cells[0].Value = reader.GetDateTime(4).ToShortDateString(); ;
                    //DataView.Rows[RowIndex].Cells[3].Value = reader.GetInt32(0);

                    TotalAmount += Convert.ToDecimal(reader.GetDecimal(2));
                }

                ResultLbl.Text = "" + TotalAmount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader?.Close();
            }
        }

        public void DisplayUpadatedList(object sender,string e)
        {
            HideAndShow(DataView);

            DataView.Dock = DockStyle.Fill;
            DataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataView.DefaultCellStyle.Font = new Font("Segoe UI semibold", 9);
            DataView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 12);
            DataView.ReadOnly = true;

            DisplayContent(e);
        }

        private UpdateForm updateForm;
        private int SelectedRowIndex;

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
             if (DataView.SelectedCells.Count>0 && DataView.SelectedCells.Count < 2 && DataView.Visible == true)
            {
                updateForm?.Dispose();
                updateForm = new UpdateForm();
                updateForm.Show();
                updateForm.OnUpdateData += SetWarning;
                updateForm.OnFilterClick += DisplayUpadatedList;

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
            if (DataView.SelectedCells.Count > 0 && DataView.Visible==true)
            {
                DataGridViewCell SelectedCell = DataView.SelectedCells[0];
                SelectedRowIndex = SelectedCell.RowIndex;

                int id =int.Parse(DataView.Rows[SelectedRowIndex].Cells[3].Value+"");

                string DeleteQuery = $"delete from expense where Id={id}";
                Command = new MySqlCommand(DeleteQuery,con);
                Command.ExecuteNonQuery();

                string Query = CurrentQuery;

                DisplayContent(Query);
            }
        } 

        private FilterForm FilterForm;
        private void FilterBtn_Click(object sender, EventArgs e)
        {
            FilterForm?.Dispose();

            //Count the Category table
            string CountQuery = "select count(*) from categories";
            Command = new MySqlCommand(CountQuery,con);
            int CountCateRow = Convert.ToInt32(Command.ExecuteScalar());
           
            if (CountCateRow > 0)
            {
                FilterForm = new FilterForm();
                FilterForm.Show();
                FilterForm.OnFilterClick += DisplayUpadatedList;
            }
            else
                WarningLabel.Text = "List Empty...!";
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
