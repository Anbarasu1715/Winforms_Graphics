namespace Evaluation2
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.NewExpensePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.DateTB = new System.Windows.Forms.DateTimePicker();
            this.StoreBtn = new System.Windows.Forms.Button();
            this.ExpenseCB = new System.Windows.Forms.ComboBox();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.CategoryPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CategoryTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LimitTB = new System.Windows.Forms.TextBox();
            this.AddCategory = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.NewExpensePanel.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(174, 39);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(131, 45);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add Expense";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(336, 39);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(131, 45);
            this.ViewBtn.TabIndex = 1;
            this.ViewBtn.Text = "View Expenses";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // NewExpensePanel
            // 
            this.NewExpensePanel.Controls.Add(this.WarningLabel);
            this.NewExpensePanel.Controls.Add(this.ExpenseCB);
            this.NewExpensePanel.Controls.Add(this.StoreBtn);
            this.NewExpensePanel.Controls.Add(this.DateTB);
            this.NewExpensePanel.Controls.Add(this.AmountTB);
            this.NewExpensePanel.Controls.Add(this.label4);
            this.NewExpensePanel.Controls.Add(this.label3);
            this.NewExpensePanel.Controls.Add(this.label2);
            this.NewExpensePanel.Controls.Add(this.label1);
            this.NewExpensePanel.Location = new System.Drawing.Point(101, 90);
            this.NewExpensePanel.Name = "NewExpensePanel";
            this.NewExpensePanel.Size = new System.Drawing.Size(583, 227);
            this.NewExpensePanel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Add Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense";
            // 
            // AmountTB
            // 
            this.AmountTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTB.Location = new System.Drawing.Point(133, 94);
            this.AmountTB.Multiline = true;
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(186, 28);
            this.AmountTB.TabIndex = 5;
            // 
            // DateTB
            // 
            this.DateTB.Location = new System.Drawing.Point(133, 133);
            this.DateTB.Name = "DateTB";
            this.DateTB.Size = new System.Drawing.Size(186, 20);
            this.DateTB.TabIndex = 6;
            // 
            // StoreBtn
            // 
            this.StoreBtn.Location = new System.Drawing.Point(244, 170);
            this.StoreBtn.Name = "StoreBtn";
            this.StoreBtn.Size = new System.Drawing.Size(131, 45);
            this.StoreBtn.TabIndex = 9;
            this.StoreBtn.Text = "Enter";
            this.StoreBtn.UseVisualStyleBackColor = true;
            this.StoreBtn.Click += new System.EventHandler(this.StoreBtn_Click);
            // 
            // ExpenseCB
            // 
            this.ExpenseCB.FormattingEnabled = true;
            this.ExpenseCB.Location = new System.Drawing.Point(133, 60);
            this.ExpenseCB.Name = "ExpenseCB";
            this.ExpenseCB.Size = new System.Drawing.Size(186, 21);
            this.ExpenseCB.TabIndex = 10;
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.Location = new System.Drawing.Point(497, 39);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(131, 45);
            this.AddCategoryBtn.TabIndex = 3;
            this.AddCategoryBtn.Text = "Add Category";
            this.AddCategoryBtn.UseVisualStyleBackColor = true;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Controls.Add(this.AddCategory);
            this.CategoryPanel.Controls.Add(this.LimitTB);
            this.CategoryPanel.Controls.Add(this.label8);
            this.CategoryPanel.Controls.Add(this.CategoryTB);
            this.CategoryPanel.Controls.Add(this.label7);
            this.CategoryPanel.Controls.Add(this.label6);
            this.CategoryPanel.Location = new System.Drawing.Point(215, 323);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(413, 173);
            this.CategoryPanel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Add Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Category";
            // 
            // CategoryTB
            // 
            this.CategoryTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTB.Location = new System.Drawing.Point(98, 46);
            this.CategoryTB.Multiline = true;
            this.CategoryTB.Name = "CategoryTB";
            this.CategoryTB.Size = new System.Drawing.Size(189, 28);
            this.CategoryTB.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Limit";
            // 
            // LimitTB
            // 
            this.LimitTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimitTB.Location = new System.Drawing.Point(98, 89);
            this.LimitTB.Multiline = true;
            this.LimitTB.Name = "LimitTB";
            this.LimitTB.Size = new System.Drawing.Size(189, 28);
            this.LimitTB.TabIndex = 8;
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(132, 123);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(131, 45);
            this.AddCategory.TabIndex = 10;
            this.AddCategory.Text = "Enter";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // WarningLabel
            // 
            this.WarningLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WarningLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(378, 60);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(162, 57);
            this.WarningLabel.TabIndex = 11;
            this.WarningLabel.Text = "This Expense Monthly Limit Exceed";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.AddCategoryBtn);
            this.Controls.Add(this.NewExpensePanel);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.NewExpensePanel.ResumeLayout(false);
            this.NewExpensePanel.PerformLayout();
            this.CategoryPanel.ResumeLayout(false);
            this.CategoryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Panel NewExpensePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StoreBtn;
        private System.Windows.Forms.DateTimePicker DateTB;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.ComboBox ExpenseCB;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.Panel CategoryPanel;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.TextBox LimitTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CategoryTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label WarningLabel;
    }
}

