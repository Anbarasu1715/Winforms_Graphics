namespace StickyNotes
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Exit_Lbl = new System.Windows.Forms.Label();
            this.Add_Lbl = new System.Windows.Forms.Label();
            this.Settings_PB = new System.Windows.Forms.PictureBox();
            this.searchBar = new StickyNotes.SearchBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Add_Lbl);
            this.panel1.Controls.Add(this.Settings_PB);
            this.panel1.Controls.Add(this.Exit_Lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 37);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 37);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sticky Notes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 546);
            this.panel3.TabIndex = 2;
            // 
            // Exit_Lbl
            // 
            this.Exit_Lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Lbl.Location = new System.Drawing.Point(279, 0);
            this.Exit_Lbl.Name = "Exit_Lbl";
            this.Exit_Lbl.Size = new System.Drawing.Size(41, 37);
            this.Exit_Lbl.TabIndex = 3;
            this.Exit_Lbl.Text = "X";
            this.Exit_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_Lbl.Click += new System.EventHandler(this.Exit_Lbl_Click);
            this.Exit_Lbl.MouseEnter += new System.EventHandler(this.Exit_Lbl_MouseEnter);
            this.Exit_Lbl.MouseLeave += new System.EventHandler(this.Exit_Lbl_MouseLeave);
            // 
            // Add_Lbl
            // 
            this.Add_Lbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.Add_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Lbl.Location = new System.Drawing.Point(0, 0);
            this.Add_Lbl.Name = "Add_Lbl";
            this.Add_Lbl.Size = new System.Drawing.Size(41, 37);
            this.Add_Lbl.TabIndex = 4;
            this.Add_Lbl.Text = "+";
            this.Add_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Add_Lbl.Click += new System.EventHandler(this.Add_Lbl_Click);
            this.Add_Lbl.MouseEnter += new System.EventHandler(this.Add_Lbl_MouseEnter);
            this.Add_Lbl.MouseLeave += new System.EventHandler(this.Add_Lbl_MouseLeave);
            // 
            // Settings_PB
            // 
            this.Settings_PB.Dock = System.Windows.Forms.DockStyle.Right;
            this.Settings_PB.Image = global::StickyNotes.Images.settings;
            this.Settings_PB.Location = new System.Drawing.Point(235, 0);
            this.Settings_PB.Name = "Settings_PB";
            this.Settings_PB.Size = new System.Drawing.Size(44, 37);
            this.Settings_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Settings_PB.TabIndex = 1;
            this.Settings_PB.TabStop = false;
            this.Settings_PB.Click += new System.EventHandler(this.Settings_PB_Click);
            this.Settings_PB.MouseEnter += new System.EventHandler(this.Settings_PB_MouseEnter);
            this.Settings_PB.MouseLeave += new System.EventHandler(this.Settings_PB_MouseLeave);
            // 
            // searchBar
            // 
            this.searchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBar.Location = new System.Drawing.Point(0, 0);
            this.searchBar.Name = "searchBar";
            this.searchBar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.searchBar.Size = new System.Drawing.Size(320, 32);
            this.searchBar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Settings_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private SearchBar searchBar;
        private System.Windows.Forms.PictureBox Settings_PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Add_Lbl;
        private System.Windows.Forms.Label Exit_Lbl;
    }
}

