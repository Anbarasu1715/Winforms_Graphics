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
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
            SearchBox_TB.BackColor= ColorTranslator.FromHtml("#404040");
        }

        private string placeholderText = "Search...";

        private void SearchBox_TB_Enter(object sender, EventArgs e)
        {
            if (SearchBox_TB.Text == placeholderText)
            {
                SearchBox_TB.Text = "";
                SearchBox_TB.ForeColor = SystemColors.ControlText; 
            }

        }

        private void SearchBox_TB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBox_TB.Text))
            {
                SearchBox_TB.Text = placeholderText;
                SearchBox_TB.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
