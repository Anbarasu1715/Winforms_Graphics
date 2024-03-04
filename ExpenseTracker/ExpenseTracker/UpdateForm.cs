using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExpenseTracker
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        public EventHandler<string> OnUpdateData;
        public EventHandler<string> OnFilterClick;

        public void SetData(int Id,string category,decimal Amount,DateTime date)
        {
            IDLbl.Text = Id+"";
            UpdateCategoryTB.Text = category;
            UpdateLimitNB.Value = Amount;
            UpdateDateDTP.Value = date;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(IDLbl.Text);

            string query = $"UPDATE expense SET Category='{UpdateCategoryTB.Text}', Amount={UpdateLimitNB.Value}, Date='{UpdateDateDTP.Value.ToString("yyyy-MM-dd")}' WHERE Id={Id}";
            MySqlCommand command = new MySqlCommand(query,Form1.con);
            command.ExecuteNonQuery();

            OnFilterClick?.Invoke(sender,Form1.CurrentQuery);
            OnUpdateData?.Invoke(sender,"Updated Successfully");
            
            this.Dispose();
        }
    }
}
