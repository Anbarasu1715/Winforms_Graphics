namespace ExpenseTracker
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
            this.ViewExpenses = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddExpensePanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.AddExpenseBtn = new System.Windows.Forms.Button();
            this.DateDTP = new System.Windows.Forms.DateTimePicker();
            this.AmountNB = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.AddCategoryPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.StoreCategory = new System.Windows.Forms.Button();
            this.LimitNB = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.CategoryTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AddExpensePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.ControlsPanel.SuspendLayout();
            this.AddCategoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimitNB)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ViewExpenses);
            this.panel1.Controls.Add(this.WarningLabel);
            this.panel1.Controls.Add(this.AddCategoryBtn);
            this.panel1.Controls.Add(this.FilterBtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 595);
            this.panel1.TabIndex = 0;
            // 
            // ViewExpenses
            // 
            this.ViewExpenses.BackColor = System.Drawing.Color.DimGray;
            this.ViewExpenses.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewExpenses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewExpenses.Location = new System.Drawing.Point(19, 464);
            this.ViewExpenses.Name = "ViewExpenses";
            this.ViewExpenses.Size = new System.Drawing.Size(128, 43);
            this.ViewExpenses.TabIndex = 9;
            this.ViewExpenses.Text = "View All";
            this.ViewExpenses.UseVisualStyleBackColor = false;
            this.ViewExpenses.Click += new System.EventHandler(this.ViewExpenses_Click);
            // 
            // WarningLabel
            // 
            this.WarningLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WarningLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(0, 535);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(173, 60);
            this.WarningLabel.TabIndex = 8;
            this.WarningLabel.Text = "Warning";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.BackColor = System.Drawing.Color.DimGray;
            this.AddCategoryBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCategoryBtn.Location = new System.Drawing.Point(19, 382);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(128, 65);
            this.AddCategoryBtn.TabIndex = 7;
            this.AddCategoryBtn.Text = "Add Category";
            this.AddCategoryBtn.UseVisualStyleBackColor = false;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // FilterBtn
            // 
            this.FilterBtn.BackColor = System.Drawing.Color.DimGray;
            this.FilterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FilterBtn.Location = new System.Drawing.Point(19, 321);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(128, 43);
            this.FilterBtn.TabIndex = 6;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = false;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DimGray;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.Location = new System.Drawing.Point(19, 263);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(128, 43);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DimGray;
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(19, 200);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(128, 43);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DimGray;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Location = new System.Drawing.Point(19, 136);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(128, 43);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExpenseTracker.Properties.Resources.ExpenseTracker;
            this.pictureBox1.Location = new System.Drawing.Point(7, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(103, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tracker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(63, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense ";
            // 
            // AddExpensePanel
            // 
            this.AddExpensePanel.Controls.Add(this.label9);
            this.AddExpensePanel.Controls.Add(this.AddExpenseBtn);
            this.AddExpensePanel.Controls.Add(this.DateDTP);
            this.AddExpensePanel.Controls.Add(this.AmountNB);
            this.AddExpensePanel.Controls.Add(this.label5);
            this.AddExpensePanel.Controls.Add(this.label4);
            this.AddExpensePanel.Controls.Add(this.CategoryCB);
            this.AddExpensePanel.Controls.Add(this.label3);
            this.AddExpensePanel.Location = new System.Drawing.Point(403, 50);
            this.AddExpensePanel.Name = "AddExpensePanel";
            this.AddExpensePanel.Size = new System.Drawing.Size(58, 159);
            this.AddExpensePanel.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(149, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "Add Category";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddExpenseBtn
            // 
            this.AddExpenseBtn.BackColor = System.Drawing.Color.DimGray;
            this.AddExpenseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpenseBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddExpenseBtn.Location = new System.Drawing.Point(175, 260);
            this.AddExpenseBtn.Name = "AddExpenseBtn";
            this.AddExpenseBtn.Size = new System.Drawing.Size(161, 43);
            this.AddExpenseBtn.TabIndex = 7;
            this.AddExpenseBtn.Text = "Add Expense";
            this.AddExpenseBtn.UseVisualStyleBackColor = false;
            this.AddExpenseBtn.Click += new System.EventHandler(this.AddExpenseBtn_Click);
            // 
            // DateDTP
            // 
            this.DateDTP.CustomFormat = "yyyy-mm-dd";
            this.DateDTP.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDTP.Location = new System.Drawing.Point(175, 176);
            this.DateDTP.Name = "DateDTP";
            this.DateDTP.Size = new System.Drawing.Size(176, 25);
            this.DateDTP.TabIndex = 6;
            // 
            // AmountNB
            // 
            this.AmountNB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountNB.Location = new System.Drawing.Point(175, 123);
            this.AmountNB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.AmountNB.Name = "AmountNB";
            this.AmountNB.Size = new System.Drawing.Size(176, 29);
            this.AmountNB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(67, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(67, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount";
            // 
            // CategoryCB
            // 
            this.CategoryCB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(175, 77);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(176, 29);
            this.CategoryCB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(67, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category";
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DataView.Location = new System.Drawing.Point(16, 50);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(301, 221);
            this.DataView.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Category";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Expense ID";
            this.Column4.Name = "Column4";
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ControlsPanel.Controls.Add(this.DataView);
            this.ControlsPanel.Controls.Add(this.AddCategoryPanel);
            this.ControlsPanel.Controls.Add(this.AddExpensePanel);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsPanel.Location = new System.Drawing.Point(173, 0);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(769, 515);
            this.ControlsPanel.TabIndex = 3;
            // 
            // AddCategoryPanel
            // 
            this.AddCategoryPanel.Controls.Add(this.label8);
            this.AddCategoryPanel.Controls.Add(this.StoreCategory);
            this.AddCategoryPanel.Controls.Add(this.LimitNB);
            this.AddCategoryPanel.Controls.Add(this.label7);
            this.AddCategoryPanel.Controls.Add(this.CategoryTB);
            this.AddCategoryPanel.Controls.Add(this.label6);
            this.AddCategoryPanel.Location = new System.Drawing.Point(496, 50);
            this.AddCategoryPanel.Name = "AddCategoryPanel";
            this.AddCategoryPanel.Size = new System.Drawing.Size(95, 46);
            this.AddCategoryPanel.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(166, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "Add Category";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoreCategory
            // 
            this.StoreCategory.BackColor = System.Drawing.Color.DimGray;
            this.StoreCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StoreCategory.Location = new System.Drawing.Point(156, 169);
            this.StoreCategory.Name = "StoreCategory";
            this.StoreCategory.Size = new System.Drawing.Size(207, 43);
            this.StoreCategory.TabIndex = 8;
            this.StoreCategory.Text = "Add Category";
            this.StoreCategory.UseVisualStyleBackColor = false;
            this.StoreCategory.Click += new System.EventHandler(this.StoreCategory_Click);
            // 
            // LimitNB
            // 
            this.LimitNB.AutoSize = true;
            this.LimitNB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimitNB.Location = new System.Drawing.Point(196, 105);
            this.LimitNB.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.LimitNB.Name = "LimitNB";
            this.LimitNB.Size = new System.Drawing.Size(222, 29);
            this.LimitNB.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(87, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "Limit";
            // 
            // CategoryTB
            // 
            this.CategoryTB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTB.Location = new System.Drawing.Point(196, 58);
            this.CategoryTB.Multiline = true;
            this.CategoryTB.Name = "CategoryTB";
            this.CategoryTB.Size = new System.Drawing.Size(222, 27);
            this.CategoryTB.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(87, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Category";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ResultLbl);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(173, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 80);
            this.panel2.TabIndex = 5;
            // 
            // ResultLbl
            // 
            this.ResultLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResultLbl.Location = new System.Drawing.Point(614, 31);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(112, 27);
            this.ResultLbl.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(496, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 27);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 595);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(958, 634);
            this.MinimumSize = new System.Drawing.Size(958, 634);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Move += new System.EventHandler(this.Form1_Move);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AddExpensePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmountNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ControlsPanel.ResumeLayout(false);
            this.AddCategoryPanel.ResumeLayout(false);
            this.AddCategoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimitNB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.Panel AddExpensePanel;
        private System.Windows.Forms.Button AddExpenseBtn;
        private System.Windows.Forms.DateTimePicker DateDTP;
        private System.Windows.Forms.NumericUpDown AmountNB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ViewExpenses;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Panel AddCategoryPanel;
        private System.Windows.Forms.Button StoreCategory;
        private System.Windows.Forms.NumericUpDown LimitNB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CategoryTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

