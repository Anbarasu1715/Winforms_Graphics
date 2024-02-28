namespace ExpenseTracker
{
    partial class FilterForm
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
            this.CateFilter = new System.Windows.Forms.Button();
            this.DateFilter = new System.Windows.Forms.Button();
            this.MonthFilter = new System.Windows.Forms.Button();
            this.DailyFilter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.DateRangePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateDTP = new System.Windows.Forms.DateTimePicker();
            this.DateRangePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CateFilter
            // 
            this.CateFilter.BackColor = System.Drawing.Color.DimGray;
            this.CateFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CateFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CateFilter.Location = new System.Drawing.Point(33, 57);
            this.CateFilter.Name = "CateFilter";
            this.CateFilter.Size = new System.Drawing.Size(236, 43);
            this.CateFilter.TabIndex = 17;
            this.CateFilter.Text = "Search by Category";
            this.CateFilter.UseVisualStyleBackColor = false;
            // 
            // DateFilter
            // 
            this.DateFilter.BackColor = System.Drawing.Color.DimGray;
            this.DateFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateFilter.Location = new System.Drawing.Point(33, 115);
            this.DateFilter.Name = "DateFilter";
            this.DateFilter.Size = new System.Drawing.Size(236, 43);
            this.DateFilter.TabIndex = 18;
            this.DateFilter.Text = "Search by Date Range";
            this.DateFilter.UseVisualStyleBackColor = false;
            // 
            // MonthFilter
            // 
            this.MonthFilter.BackColor = System.Drawing.Color.DimGray;
            this.MonthFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MonthFilter.Location = new System.Drawing.Point(33, 172);
            this.MonthFilter.Name = "MonthFilter";
            this.MonthFilter.Size = new System.Drawing.Size(236, 43);
            this.MonthFilter.TabIndex = 19;
            this.MonthFilter.Text = "Month basis";
            this.MonthFilter.UseVisualStyleBackColor = false;
            // 
            // DailyFilter
            // 
            this.DailyFilter.BackColor = System.Drawing.Color.DimGray;
            this.DailyFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DailyFilter.Location = new System.Drawing.Point(33, 225);
            this.DailyFilter.Name = "DailyFilter";
            this.DailyFilter.Size = new System.Drawing.Size(236, 43);
            this.DailyFilter.TabIndex = 20;
            this.DailyFilter.Text = "Daily basis";
            this.DailyFilter.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(58, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 34);
            this.label8.TabIndex = 21;
            this.label8.Text = "Filter Data";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryCB
            // 
            this.CategoryCB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(33, 288);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(236, 29);
            this.CategoryCB.TabIndex = 22;
            // 
            // DateRangePanel
            // 
            this.DateRangePanel.Controls.Add(this.label1);
            this.DateRangePanel.Controls.Add(this.label5);
            this.DateRangePanel.Controls.Add(this.dateTimePicker1);
            this.DateRangePanel.Controls.Add(this.DateDTP);
            this.DateRangePanel.Location = new System.Drawing.Point(33, 334);
            this.DateRangePanel.Name = "DateRangePanel";
            this.DateRangePanel.Size = new System.Drawing.Size(236, 100);
            this.DateRangePanel.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "To";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(0, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "From";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 25);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // DateDTP
            // 
            this.DateDTP.CustomFormat = "dd-MM-yyyy";
            this.DateDTP.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDTP.Location = new System.Drawing.Point(60, 57);
            this.DateDTP.Name = "DateDTP";
            this.DateDTP.Size = new System.Drawing.Size(176, 25);
            this.DateDTP.TabIndex = 27;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 446);
            this.Controls.Add(this.DateRangePanel);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DailyFilter);
            this.Controls.Add(this.MonthFilter);
            this.Controls.Add(this.DateFilter);
            this.Controls.Add(this.CateFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterForm";
            this.DateRangePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CateFilter;
        private System.Windows.Forms.Button DateFilter;
        private System.Windows.Forms.Button MonthFilter;
        private System.Windows.Forms.Button DailyFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Panel DateRangePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker DateDTP;
    }
}