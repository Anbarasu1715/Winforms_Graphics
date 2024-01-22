using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionPanel
{
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
            foreach (Control c in Controls) {
                if (c is Button)
                    c.Click += Btnclicked;
            }
        }

        public event EventHandler<string> OnBtnClick;


        private void Btnclicked(Object s,EventArgs e) {
            switch ((s as Button).Name) {
                case "recBtn":
                    OnBtnClick?.Invoke(s,"Rectangle");
                    break;
                case "circleBtn":
                    OnBtnClick?.Invoke(s, "Circle");
                    break;
                case "squareBtn":
                    OnBtnClick?.Invoke(s, "Square");
                    break;
                case "triangleBtn":
                    OnBtnClick?.Invoke(s, "Triangle");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void recBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
