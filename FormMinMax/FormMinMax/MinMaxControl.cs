using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMinMax
{
    public partial class MinMaxControl : Form
    {
        public MinMaxControl(string text)
        {
            InitializeComponent();
            button.Text = text;
        }

        private string BtnText = "Maximize";

        public event EventHandler<EventArgs> OnBtnClick;

        private void button_Click(object sender, EventArgs e)
        {
            OnBtnClick?.Invoke(sender,e);
            //if ((sender as Button).Text == "Minimize")
            //    BtnText = "Maximize";
            //else
            //    BtnText = "Minimize";
        }
    }
}
