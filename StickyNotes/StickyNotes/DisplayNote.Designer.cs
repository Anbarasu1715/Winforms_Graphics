namespace StickyNotes
{
    partial class DisplayNote
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisplayTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.DisplayTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 55);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.DisplayTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTextBox.ForeColor = System.Drawing.Color.White;
            this.DisplayTextBox.Location = new System.Drawing.Point(0, 16);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.ReadOnly = true;
            this.DisplayTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.DisplayTextBox.Size = new System.Drawing.Size(295, 36);
            this.DisplayTextBox.TabIndex = 2;
            this.DisplayTextBox.Text = "";
            this.DisplayTextBox.TextChanged += new System.EventHandler(this.DisplayTextBox_TextChanged);
            this.DisplayTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DisplayTextBox_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(271, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 9);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(241, 1);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(28, 12);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "12.12";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // DisplayNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DisplayNote";
            this.Size = new System.Drawing.Size(295, 55);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.RichTextBox DisplayTextBox;
    }
}
