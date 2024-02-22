using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
            label1.BackColor = ColorTranslator.FromHtml("#212121");
            label2.BackColor = ColorTranslator.FromHtml("#212121");

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).BackColor = ColorTranslator.FromHtml("#414141");
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).BackColor = ColorTranslator.FromHtml("#212121");
        }
    }
}
