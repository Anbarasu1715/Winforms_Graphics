using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class SelectionBox : Form
    {
        public SelectionBox()
        {
            InitializeComponent();
        }

        public EventHandler<string> OnEventclick;


        private void btn_MouseClick(object sender, MouseEventArgs e)
        {
            OnEventclick?.Invoke(sender,(sender as Button).Text);
        }
    }
}
