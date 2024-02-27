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
    public partial class ViewData : Form
    {
        public ViewData()
        {
            InitializeComponent();
            OnDataReceive += SetData;
        }

        public EventHandler<List<Expense>> OnDataReceive;

        private void SetData(object sender, List<Expense> expenses)
        {
            int RowIndex;
            int TotalExpense=0;
            foreach (var e in expenses)
            {
                RowIndex = DataView.Rows.Add();
                DataView.Rows[RowIndex].Cells[0].Value = e.Category;
                DataView.Rows[RowIndex].Cells[1].Value = e.Amount;
                DataView.Rows[RowIndex].Cells[2].Value = e.Date;

                TotalExpense += e.Amount;
            }
            RowIndex = DataView.Rows.Add();
            RowIndex = DataView.Rows.Add();
            DataView.Rows[RowIndex].Cells[0].Value = "     Total";
            DataView.Rows[RowIndex].Cells[1].Value = TotalExpense;
        }

    }
}
