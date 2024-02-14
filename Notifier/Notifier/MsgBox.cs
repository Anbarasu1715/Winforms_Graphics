using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notifier
{
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
            OpacityTimer = new Timer();
            OpacityTimer.Interval = 50;
            OpacityTimer.Tick += ReduceOpacity;
        }

        public void SetText(string text)
        {
            richTextBox1.Text = text;
        }

        private void MsgBox_Load(object sender, EventArgs e)
        {

        }

        private void MsgBox_Click(object sender, EventArgs e)
        {
            if (this != Form.ActiveForm)
            {
                this.Close();
            }
        }


        private double OpacityIncrement = 0.1;
        private double TargetOpacity = 0.01;
        private Timer OpacityTimer;

        private void ReduceOpacity(object sender, EventArgs e)
        {
            if (this.Opacity > TargetOpacity)
            {
                this.Opacity -= OpacityIncrement;
            }
            else
            {
                OpacityTimer.Stop();
                this.Close();
            }
        }

        private void MsgBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            OpacityTimer.Start();
        }
    }
}
