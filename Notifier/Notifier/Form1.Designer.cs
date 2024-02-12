namespace Notifier
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.page2Btn2 = new System.Windows.Forms.Button();
            this.page1Btn1 = new System.Windows.Forms.Button();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.Page3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.Page1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Page1);
            this.tabControl.Controls.Add(this.Page2);
            this.tabControl.Controls.Add(this.Page3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.textBox1);
            this.Page1.Controls.Add(this.page2Btn2);
            this.Page1.Controls.Add(this.page1Btn1);
            this.Page1.Location = new System.Drawing.Point(4, 22);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(792, 424);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Page1";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // page2Btn2
            // 
            this.page2Btn2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page2Btn2.Location = new System.Drawing.Point(429, 158);
            this.page2Btn2.Name = "page2Btn2";
            this.page2Btn2.Size = new System.Drawing.Size(147, 59);
            this.page2Btn2.TabIndex = 1;
            this.page2Btn2.Text = "Alert";
            this.page2Btn2.UseVisualStyleBackColor = true;
            // 
            // page1Btn1
            // 
            this.page1Btn1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page1Btn1.Location = new System.Drawing.Point(175, 158);
            this.page1Btn1.Name = "page1Btn1";
            this.page1Btn1.Size = new System.Drawing.Size(147, 59);
            this.page1Btn1.TabIndex = 0;
            this.page1Btn1.Text = "Alert";
            this.page1Btn1.UseVisualStyleBackColor = true;
            this.page1Btn1.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // Page2
            // 
            this.Page2.Location = new System.Drawing.Point(4, 22);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(792, 424);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "Page2";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // Page3
            // 
            this.Page3.Location = new System.Drawing.Point(4, 22);
            this.Page3.Name = "Page3";
            this.Page3.Padding = new System.Windows.Forms.Padding(3);
            this.Page3.Size = new System.Drawing.Size(792, 424);
            this.Page3.TabIndex = 2;
            this.Page3.Text = "Page3";
            this.Page3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.Button page2Btn2;
        private System.Windows.Forms.Button page1Btn1;
        private System.Windows.Forms.TabPage Page3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

