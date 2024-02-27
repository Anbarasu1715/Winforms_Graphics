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
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
            panel1.Visible = false;
            Width = 270;
            Form1.OnCategorySend += UpdateComboBox;
        }


        public EventHandler<List<Category>> OnSelectCategory;
        public EventHandler OnCategoryClick;
        public EventHandler OnDisplayAll;
        public EventHandler<string> OnEnterClick;
        public EventHandler<string> OnSubmitClick;


        private void UpdateComboBox(object sender, List<Category> e)
        {
            foreach (var i in e)
            {
                comboBox1.Items.Add(i.ExpenseName);
            }
            panel1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            StartDate.Visible = false;
            EndDate.Visible = false;
            viewBtn.Visible = false;
            DisplayTitleLabel.Text = "Select Category";
            panel1.Location = new Point(0, 0);
            this.Width = 403;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OnCategoryClick?.Invoke(sender,e);
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            OnEnterClick?.Invoke(sender,comboBox1.Text);
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            OnDisplayAll?.Invoke(sender,e);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            string date = StartDate + " " + EndDate;
            OnSubmitClick?.Invoke(sender,date);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            StartDate.Visible = true;
            EndDate.Visible = true;
            viewBtn.Visible = false;

            DisplayTitleLabel.Text = "Select Range";
            panel1.Location = new Point(0, 0);
            this.Width = 403;
        }
    }
}
