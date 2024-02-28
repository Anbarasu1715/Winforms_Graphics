namespace ExpenseTracker
{
    partial class UpdateForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateCategoryTB = new System.Windows.Forms.TextBox();
            this.UpdateLimitNB = new System.Windows.Forms.NumericUpDown();
            this.UpdateDateDTP = new System.Windows.Forms.DateTimePicker();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IDLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateLimitNB)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(15, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "Category";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(107, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 34);
            this.label8.TabIndex = 10;
            this.label8.Text = "UPDATE DATA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date";
            // 
            // UpdateCategoryTB
            // 
            this.UpdateCategoryTB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCategoryTB.Location = new System.Drawing.Point(111, 94);
            this.UpdateCategoryTB.Multiline = true;
            this.UpdateCategoryTB.Name = "UpdateCategoryTB";
            this.UpdateCategoryTB.Size = new System.Drawing.Size(210, 27);
            this.UpdateCategoryTB.TabIndex = 13;
            // 
            // UpdateLimitNB
            // 
            this.UpdateLimitNB.AutoSize = true;
            this.UpdateLimitNB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLimitNB.Location = new System.Drawing.Point(111, 138);
            this.UpdateLimitNB.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.UpdateLimitNB.Name = "UpdateLimitNB";
            this.UpdateLimitNB.Size = new System.Drawing.Size(210, 29);
            this.UpdateLimitNB.TabIndex = 14;
            // 
            // UpdateDateDTP
            // 
            this.UpdateDateDTP.CustomFormat = "dd-MM-yyyy";
            this.UpdateDateDTP.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UpdateDateDTP.Location = new System.Drawing.Point(111, 187);
            this.UpdateDateDTP.Name = "UpdateDateDTP";
            this.UpdateDateDTP.Size = new System.Drawing.Size(210, 25);
            this.UpdateDateDTP.TabIndex = 15;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DimGray;
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(95, 229);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(161, 43);
            this.UpdateBtn.TabIndex = 16;
            this.UpdateBtn.Text = "Update Data";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Expense ID";
            // 
            // IDLbl
            // 
            this.IDLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IDLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IDLbl.Location = new System.Drawing.Point(111, 55);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(128, 26);
            this.IDLbl.TabIndex = 18;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 285);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.UpdateDateDTP);
            this.Controls.Add(this.UpdateLimitNB);
            this.Controls.Add(this.UpdateCategoryTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(349, 324);
            this.MinimumSize = new System.Drawing.Size(349, 324);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.UpdateLimitNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UpdateCategoryTB;
        private System.Windows.Forms.NumericUpDown UpdateLimitNB;
        private System.Windows.Forms.DateTimePicker UpdateDateDTP;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDLbl;
    }
}