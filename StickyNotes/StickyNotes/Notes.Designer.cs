namespace StickyNotes
{
    partial class Notes
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
            this.HomePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_Lbl = new System.Windows.Forms.Label();
            this.EditorPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Color6 = new System.Windows.Forms.Label();
            this.Color4 = new System.Windows.Forms.Label();
            this.Color3 = new System.Windows.Forms.Label();
            this.Color2 = new System.Windows.Forms.Label();
            this.Color1 = new System.Windows.Forms.Label();
            this.Color5 = new System.Windows.Forms.Label();
            this.Editor_TextBox = new System.Windows.Forms.RichTextBox();
            this.Option_Panel = new System.Windows.Forms.Panel();
            this.Image_PB = new System.Windows.Forms.PictureBox();
            this.Points_pB = new System.Windows.Forms.PictureBox();
            this.Line_PB = new System.Windows.Forms.PictureBox();
            this.Underline_PB = new System.Windows.Forms.PictureBox();
            this.Italic_PB = new System.Windows.Forms.PictureBox();
            this.Bold_PB = new System.Windows.Forms.PictureBox();
            this.ImageBox = new System.Windows.Forms.Panel();
            this.HomePanel.SuspendLayout();
            this.EditorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Option_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Points_pB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Underline_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Italic_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bold_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HomePanel.Controls.Add(this.label2);
            this.HomePanel.Controls.Add(this.label1);
            this.HomePanel.Controls.Add(this.Exit_Lbl);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(305, 35);
            this.HomePanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // Exit_Lbl
            // 
            this.Exit_Lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Lbl.Location = new System.Drawing.Point(271, 0);
            this.Exit_Lbl.Name = "Exit_Lbl";
            this.Exit_Lbl.Size = new System.Drawing.Size(34, 35);
            this.Exit_Lbl.TabIndex = 5;
            this.Exit_Lbl.Text = "X";
            this.Exit_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_Lbl.Click += new System.EventHandler(this.Exit_Lbl_Click);
            this.Exit_Lbl.MouseEnter += new System.EventHandler(this.Exit_Lbl_MouseEnter);
            this.Exit_Lbl.MouseLeave += new System.EventHandler(this.Exit_Lbl_MouseLeave);
            // 
            // EditorPanel
            // 
            this.EditorPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EditorPanel.Controls.Add(this.label5);
            this.EditorPanel.Controls.Add(this.label4);
            this.EditorPanel.Controls.Add(this.pictureBox2);
            this.EditorPanel.Controls.Add(this.pictureBox1);
            this.EditorPanel.Controls.Add(this.Color6);
            this.EditorPanel.Controls.Add(this.Color4);
            this.EditorPanel.Controls.Add(this.Color3);
            this.EditorPanel.Controls.Add(this.Color2);
            this.EditorPanel.Controls.Add(this.Color1);
            this.EditorPanel.Controls.Add(this.Color5);
            this.EditorPanel.Location = new System.Drawing.Point(0, 54);
            this.EditorPanel.Name = "EditorPanel";
            this.EditorPanel.Size = new System.Drawing.Size(305, 150);
            this.EditorPanel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(42, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 45);
            this.label5.TabIndex = 12;
            this.label5.Text = "Delete Note";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(42, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Notes List";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StickyNotes.Images.delete;
            this.pictureBox2.Location = new System.Drawing.Point(0, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.label5_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StickyNotes.Images.notesList;
            this.pictureBox1.Location = new System.Drawing.Point(0, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.label4_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // Color6
            // 
            this.Color6.BackColor = System.Drawing.Color.DarkGray;
            this.Color6.Location = new System.Drawing.Point(254, 0);
            this.Color6.Name = "Color6";
            this.Color6.Size = new System.Drawing.Size(50, 61);
            this.Color6.TabIndex = 8;
            this.Color6.Click += new System.EventHandler(this.Color1_Click);
            this.Color6.MouseEnter += new System.EventHandler(this.Color1_MouseEnter);
            this.Color6.MouseLeave += new System.EventHandler(this.Color1_MouseLeave);
            // 
            // Color4
            // 
            this.Color4.BackColor = System.Drawing.Color.BlueViolet;
            this.Color4.Location = new System.Drawing.Point(152, 0);
            this.Color4.Name = "Color4";
            this.Color4.Size = new System.Drawing.Size(50, 61);
            this.Color4.TabIndex = 6;
            this.Color4.Click += new System.EventHandler(this.Color1_Click);
            this.Color4.MouseEnter += new System.EventHandler(this.Color1_MouseEnter);
            this.Color4.MouseLeave += new System.EventHandler(this.Color1_MouseLeave);
            // 
            // Color3
            // 
            this.Color3.BackColor = System.Drawing.Color.Orchid;
            this.Color3.Location = new System.Drawing.Point(102, 0);
            this.Color3.Name = "Color3";
            this.Color3.Size = new System.Drawing.Size(50, 61);
            this.Color3.TabIndex = 5;
            this.Color3.Click += new System.EventHandler(this.Color1_Click);
            this.Color3.MouseEnter += new System.EventHandler(this.Color1_MouseEnter);
            this.Color3.MouseLeave += new System.EventHandler(this.Color1_MouseLeave);
            // 
            // Color2
            // 
            this.Color2.BackColor = System.Drawing.Color.LimeGreen;
            this.Color2.Location = new System.Drawing.Point(52, 0);
            this.Color2.Name = "Color2";
            this.Color2.Size = new System.Drawing.Size(50, 61);
            this.Color2.TabIndex = 5;
            this.Color2.Click += new System.EventHandler(this.Color1_Click);
            this.Color2.MouseEnter += new System.EventHandler(this.Color1_MouseEnter);
            this.Color2.MouseLeave += new System.EventHandler(this.Color1_MouseLeave);
            // 
            // Color1
            // 
            this.Color1.BackColor = System.Drawing.Color.Gold;
            this.Color1.Location = new System.Drawing.Point(2, 0);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(50, 61);
            this.Color1.TabIndex = 4;
            this.Color1.Click += new System.EventHandler(this.Color1_Click);
            this.Color1.MouseEnter += new System.EventHandler(this.Color1_MouseEnter);
            this.Color1.MouseLeave += new System.EventHandler(this.Color1_MouseLeave);
            // 
            // Color5
            // 
            this.Color5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Color5.Location = new System.Drawing.Point(202, 0);
            this.Color5.Name = "Color5";
            this.Color5.Size = new System.Drawing.Size(52, 61);
            this.Color5.TabIndex = 7;
            this.Color5.Click += new System.EventHandler(this.Color1_Click);
            this.Color5.MouseEnter += new System.EventHandler(this.Color1_MouseEnter);
            this.Color5.MouseLeave += new System.EventHandler(this.Color1_MouseLeave);
            // 
            // Editor_TextBox
            // 
            this.Editor_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Editor_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editor_TextBox.ForeColor = System.Drawing.Color.White;
            this.Editor_TextBox.Location = new System.Drawing.Point(32, 215);
            this.Editor_TextBox.Name = "Editor_TextBox";
            this.Editor_TextBox.Size = new System.Drawing.Size(178, 55);
            this.Editor_TextBox.TabIndex = 2;
            this.Editor_TextBox.Text = "";
            this.Editor_TextBox.Click += new System.EventHandler(this.Editor_TextBox_Click);
            this.Editor_TextBox.TextChanged += new System.EventHandler(this.Editor_TextBox_TextChanged);
            // 
            // Option_Panel
            // 
            this.Option_Panel.Controls.Add(this.Image_PB);
            this.Option_Panel.Controls.Add(this.Points_pB);
            this.Option_Panel.Controls.Add(this.Line_PB);
            this.Option_Panel.Controls.Add(this.Underline_PB);
            this.Option_Panel.Controls.Add(this.Italic_PB);
            this.Option_Panel.Controls.Add(this.Bold_PB);
            this.Option_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Option_Panel.Location = new System.Drawing.Point(0, 276);
            this.Option_Panel.Name = "Option_Panel";
            this.Option_Panel.Size = new System.Drawing.Size(305, 39);
            this.Option_Panel.TabIndex = 2;
            // 
            // Image_PB
            // 
            this.Image_PB.Dock = System.Windows.Forms.DockStyle.Left;
            this.Image_PB.Image = global::StickyNotes.Images.image;
            this.Image_PB.Location = new System.Drawing.Point(210, 0);
            this.Image_PB.Name = "Image_PB";
            this.Image_PB.Size = new System.Drawing.Size(42, 39);
            this.Image_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Image_PB.TabIndex = 5;
            this.Image_PB.TabStop = false;
            this.Image_PB.Click += new System.EventHandler(this.Bold_PB_Click);
            this.Image_PB.MouseEnter += new System.EventHandler(this.Image_PB_MouseEnter);
            this.Image_PB.MouseLeave += new System.EventHandler(this.Image_PB_MouseLeave);
            // 
            // Points_pB
            // 
            this.Points_pB.Dock = System.Windows.Forms.DockStyle.Left;
            this.Points_pB.Image = global::StickyNotes.Images.OrderedList;
            this.Points_pB.Location = new System.Drawing.Point(168, 0);
            this.Points_pB.Name = "Points_pB";
            this.Points_pB.Size = new System.Drawing.Size(42, 39);
            this.Points_pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Points_pB.TabIndex = 4;
            this.Points_pB.TabStop = false;
            this.Points_pB.Click += new System.EventHandler(this.Bold_PB_Click);
            this.Points_pB.MouseEnter += new System.EventHandler(this.Image_PB_MouseEnter);
            this.Points_pB.MouseLeave += new System.EventHandler(this.Image_PB_MouseLeave);
            // 
            // Line_PB
            // 
            this.Line_PB.Dock = System.Windows.Forms.DockStyle.Left;
            this.Line_PB.Image = global::StickyNotes.Images.strikeOut;
            this.Line_PB.Location = new System.Drawing.Point(126, 0);
            this.Line_PB.Name = "Line_PB";
            this.Line_PB.Size = new System.Drawing.Size(42, 39);
            this.Line_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Line_PB.TabIndex = 3;
            this.Line_PB.TabStop = false;
            this.Line_PB.Click += new System.EventHandler(this.Bold_PB_Click);
            this.Line_PB.MouseEnter += new System.EventHandler(this.Image_PB_MouseEnter);
            this.Line_PB.MouseLeave += new System.EventHandler(this.Image_PB_MouseLeave);
            // 
            // Underline_PB
            // 
            this.Underline_PB.Dock = System.Windows.Forms.DockStyle.Left;
            this.Underline_PB.Image = global::StickyNotes.Images.UnderLine;
            this.Underline_PB.Location = new System.Drawing.Point(84, 0);
            this.Underline_PB.Name = "Underline_PB";
            this.Underline_PB.Size = new System.Drawing.Size(42, 39);
            this.Underline_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Underline_PB.TabIndex = 2;
            this.Underline_PB.TabStop = false;
            this.Underline_PB.Click += new System.EventHandler(this.Bold_PB_Click);
            this.Underline_PB.MouseEnter += new System.EventHandler(this.Image_PB_MouseEnter);
            this.Underline_PB.MouseLeave += new System.EventHandler(this.Image_PB_MouseLeave);
            // 
            // Italic_PB
            // 
            this.Italic_PB.Dock = System.Windows.Forms.DockStyle.Left;
            this.Italic_PB.Image = global::StickyNotes.Images.Italic;
            this.Italic_PB.Location = new System.Drawing.Point(42, 0);
            this.Italic_PB.Name = "Italic_PB";
            this.Italic_PB.Size = new System.Drawing.Size(42, 39);
            this.Italic_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Italic_PB.TabIndex = 1;
            this.Italic_PB.TabStop = false;
            this.Italic_PB.Click += new System.EventHandler(this.Bold_PB_Click);
            this.Italic_PB.MouseEnter += new System.EventHandler(this.Image_PB_MouseEnter);
            this.Italic_PB.MouseLeave += new System.EventHandler(this.Image_PB_MouseLeave);
            // 
            // Bold_PB
            // 
            this.Bold_PB.Dock = System.Windows.Forms.DockStyle.Left;
            this.Bold_PB.Image = global::StickyNotes.Images.Bold;
            this.Bold_PB.Location = new System.Drawing.Point(0, 0);
            this.Bold_PB.Name = "Bold_PB";
            this.Bold_PB.Size = new System.Drawing.Size(42, 39);
            this.Bold_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Bold_PB.TabIndex = 0;
            this.Bold_PB.TabStop = false;
            this.Bold_PB.Click += new System.EventHandler(this.Bold_PB_Click);
            this.Bold_PB.MouseEnter += new System.EventHandler(this.Image_PB_MouseEnter);
            this.Bold_PB.MouseLeave += new System.EventHandler(this.Image_PB_MouseLeave);
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(242, 234);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(51, 23);
            this.ImageBox.TabIndex = 3;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 315);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.Editor_TextBox);
            this.Controls.Add(this.Option_Panel);
            this.Controls.Add(this.EditorPanel);
            this.Controls.Add(this.HomePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notes";
            this.Click += new System.EventHandler(this.Notes_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Notes_Paint);
            this.HomePanel.ResumeLayout(false);
            this.EditorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Option_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Points_pB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Underline_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Italic_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bold_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel EditorPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Exit_Lbl;
        private System.Windows.Forms.Label Color6;
        private System.Windows.Forms.Label Color5;
        private System.Windows.Forms.Label Color4;
        private System.Windows.Forms.Label Color3;
        private System.Windows.Forms.Label Color2;
        private System.Windows.Forms.Label Color1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Editor_TextBox;
        private System.Windows.Forms.Panel Option_Panel;
        private System.Windows.Forms.PictureBox Image_PB;
        private System.Windows.Forms.PictureBox Points_pB;
        private System.Windows.Forms.PictureBox Line_PB;
        private System.Windows.Forms.PictureBox Underline_PB;
        private System.Windows.Forms.PictureBox Italic_PB;
        private System.Windows.Forms.PictureBox Bold_PB;
        private System.Windows.Forms.Panel ImageBox;
    }
}