using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class ExitLbl : UserControl
    {
        public ExitLbl()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label1.ForeColor= ColorTranslator.FromHtml("#6A6A6A");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = ColorTranslator.FromHtml("#414141");
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }
    }
}
