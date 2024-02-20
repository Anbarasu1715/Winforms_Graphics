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
    public partial class Form1 : Form
    {

        private Notes note;
        private List<Panel> StickyNotes = new List<Panel>();
        private List<Notes> Notes = new List<Notes>();

        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = ColorTranslator.FromHtml("#212121");
            panel2.BackColor = ColorTranslator.FromHtml("#212121");
            panel3.BackColor = ColorTranslator.FromHtml("#212121");

            Add_Lbl.ForeColor = ColorTranslator.FromHtml("#6A6A6A"); 
            Exit_Lbl.ForeColor = ColorTranslator.FromHtml("#6A6A6A");  
        }

        private void exitLbl1_Load(object sender, EventArgs e)
        {
            
        }

        private void Settings_PB_MouseEnter(object sender, EventArgs e)
        {
           Settings_PB.BackColor = ColorTranslator.FromHtml("#414141");
        }

        private void Settings_PB_MouseLeave(object sender, EventArgs e)
        {
            Settings_PB.BackColor = Color.Transparent;
        }

        private void Settings_PB_Click(object sender, EventArgs e)
        {

        }

        private void Add_Lbl_MouseEnter(object sender, EventArgs e)
        {
            Add_Lbl.BackColor = ColorTranslator.FromHtml("#414141");
        }

        private void Add_Lbl_MouseLeave(object sender, EventArgs e)
        {
            Add_Lbl.BackColor = Color.Transparent;
        }

        private void Exit_Lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Lbl_MouseEnter(object sender, EventArgs e)
        {
            Exit_Lbl.BackColor = ColorTranslator.FromHtml("#414141");
        }

        private void Exit_Lbl_MouseLeave(object sender, EventArgs e)
        {
            Exit_Lbl.BackColor = Color.Transparent;
        }

        private void Add_Lbl_Click(object sender, EventArgs e)
        {
            note = new Notes();
            Panel panel = new Panel();
            Label label = new Label()
            {
                Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold),
                Width = this.Width,
                Height=60,
                Padding = new Padding(10,5,10,5)
            };

            //panel
            panel.Height = label.Height;
            panel.Width = Width;
            panel.Controls.Add(label);
            panel.Padding = new Padding(0,10,0,0);
            panel.Location = new Point(0,searchBar.Height);

            //Notes
            note.OnTextChange += SetText;
            note.Show();

            panel3.Controls.Add(panel);

        }

        private void SetText(object sender, string FormatedText)
        {
            note.ContentText = FormatedText;
            int height = (sender as RichTextBox).Height;
        }
    }
}
