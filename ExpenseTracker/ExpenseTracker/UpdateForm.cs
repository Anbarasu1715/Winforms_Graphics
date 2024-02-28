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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        public EventHandler<string> OnUpdateData;

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

            foreach (var exp in Form1.Expenses)
            {
                if (Id==exp.ID)
                {
                    exp.Update(UpdateCategoryTB.Text, UpdateLimitNB.Value, UpdateDateDTP.Value.Date);
                }
            }

            OnUpdateData?.Invoke(sender,"Updated Successfully");
            
            this.Dispose();
        }
    }
}
