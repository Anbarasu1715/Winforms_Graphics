using MySql.Data.MySqlClient;
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

        private static int SearchBarHeight;
        private Random rnd = new Random();
        private Notes note;
        private DisplayNote displayNote;
        private OptionForm optionForm;
        static private List<KeyValuePair<Notes, DisplayNote>> pairs = new List<KeyValuePair<Notes, DisplayNote>>();
        //private List<Panel> StickyNotes = new List<Panel>();
        //private List<Notes> Notes = new List<Notes>();

        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = ColorTranslator.FromHtml("#212121");
            panel2.BackColor = ColorTranslator.FromHtml("#212121");
            panel3.BackColor = ColorTranslator.FromHtml("#212121");

            Add_Lbl.ForeColor = ColorTranslator.FromHtml("#6A6A6A"); 
            Exit_Lbl.ForeColor = ColorTranslator.FromHtml("#6A6A6A");

            SearchBarHeight = searchBar.Height;
            
        }

        private void EstablishDB(Object sender,EventArgs e)
        {
            string address = "server=localhost;port=3306;uid=root;pwd=lucid;database=stickynotes";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = address;
            try
            {
                con.Open();
                string query = "select * from persons";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                string result = "";
                while (reader.Read())
                {
                    result += "Id=" + reader["PersonID"] + "  Name=" + reader["FirstName"] + "  City=" + reader["City"] + "\n";
                }
                MessageBox.Show(result);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        public static void ReLocate()
        {
            Point FirstLocation = new Point(5, SearchBarHeight);

            for (int i=pairs.Count-1;i>=0;i--)
            {
                pairs[i].Value.Location = FirstLocation;
                FirstLocation.Y += pairs[i].Value.Height;
            }
        }

        private void Add_Lbl_Click(object sender, EventArgs e)
        {
            note = new Notes();
            displayNote = new DisplayNote();

            //Display Note
            displayNote.Location = new Point(5, SearchBarHeight);
            displayNote.Padding = new Padding(0,10,0,0);
            displayNote.OnDoubleClick += UpdateContent;
            displayNote.OnOptionPanel += CreateOptionPanel;
            displayNote.SetTime(DateTime.Now.ToString("HH:mm"));

            //Notes
            note.OnTextChange += SetText;
            note.OnTextHeightChange += displayNote.SetTextAndHeight;
            note.OnColorChange += displayNote.ColorChange;
            note.FormClosing += BeforeFormClose;
            note.OnCreateNote += Add_Lbl_Click;
            note.OnDisplayList += VisibleList;
            note.OnDeleteNote += DeleteNote;
            note.Show();

            int count = pairs.Count;
            if (count == 0)
            {
                note.Location = new Point(this.Location.X + Width + 5, this.Location.Y);
            }
            else if (count == 1)
            {
                note.Location = new Point(this.Location.X - note.Width - 5, this.Location.Y);
            }
            else
            {
                note.Location = new Point(rnd.Next(10, 750), rnd.Next(10, 600));
            }

            panel3.Controls.Add(displayNote);

            pairs.Add(new KeyValuePair<Notes, DisplayNote>(note,displayNote));
            ReLocate();

            //Notes newNote = pairs[1].Key;
            //newNote.Show();

            panel3.AutoScrollPosition = new Point(0,30);
        }

        private void CreateOptionPanel(object sender, Point e)
        {
            optionForm?.Dispose();
            optionForm = new OptionForm();
            optionForm.Location = e ;
            optionForm.Show();
        }

        private void DeleteNote(object sender, EventArgs e)
        {
            bool isKey = false;
            if (sender is Notes)
            {
                isKey = true;
            }

            foreach (var kvp in pairs)
            {
                if (isKey)
                {
                    Notes note = (sender as Notes);
                    if (kvp.Key == note)
                    {
                        note.Close();
                        panel3.Controls.Remove(kvp.Value);
                        pairs.RemoveAll(pair => pair.Key == note);
                        ReLocate();
                        break;
                    }
                }
                else
                {
                    DisplayNote displayNote = (sender as DisplayNote);
                    if (kvp.Value==displayNote)
                    {
                        kvp.Key.Close();
                        panel3.Controls.Remove(displayNote);
                        pairs.RemoveAll(pair=>pair.Key==kvp.Key);
                        ReLocate();
                        break;
                    }
                }
            }
        }

        private void VisibleList(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void UpdateContent(object sender, EventArgs e)
        {
            foreach (var kvp in pairs)
            {
                if ((sender as DisplayNote) == kvp.Value)
                {
                    kvp.Key.Visible = true;
                    kvp.Key.BringToFront();
                }
            }
        }

        private void BeforeFormClose(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            (sender as Form).Visible = false;
        }

        private int CountLines(RichTextBox richTextBox)
        {

            Graphics g = CreateGraphics();

            int lineCount = 0;
            string Text = richTextBox.Text;
            string finalText = Text;

            SizeF textSize = g.MeasureString(Text, richTextBox.Font);

            if (textSize.Width > richTextBox.Width)
            {
                finalText = "";
                string line = "";
                string[] words = Text.Split(' ');

                foreach (string word in words)
                {
                    if (g.MeasureString(word, richTextBox.Font).Width > richTextBox.Width)
                    {
                        finalText += word.Trim() + Environment.NewLine;
                        line = "";
                        lineCount =(int) g.MeasureString(word, richTextBox.Font).Width / richTextBox.Width;
                    }
                    else if (g.MeasureString(line + word, richTextBox.Font).Width > richTextBox.Width)
                    {
                        finalText += line.Trim() + Environment.NewLine;
                        line = word + " ";
                        lineCount++;
                    }
                    else
                    {
                        line += word + " ";
                    }
                }
                finalText += line.Trim();
                lineCount++;
            }
            return lineCount;
        }

        private void SetText(object sender, Object TextBox)
        {
            var note = (sender as Notes);
            var textBox= (TextBox as RichTextBox);
            note.ContentText = textBox.Text;
        }
    }
}
