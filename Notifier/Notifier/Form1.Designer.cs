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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.page2Btn2 = new System.Windows.Forms.Button();
            this.page1Btn1 = new System.Windows.Forms.Button();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.Page3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.manager1 = new Notifier.Manager();
            this.tabControl.SuspendLayout();
            this.Page1.SuspendLayout();
            this.Page2.SuspendLayout();
            this.Page3.SuspendLayout();
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
            this.Page1.Controls.Add(this.button1);
            this.Page1.Controls.Add(this.button2);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(429, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "covai";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(175, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "Good Morning";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 263);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 114);
            this.textBox1.TabIndex = 2;
            // 
            // page2Btn2
            // 
            this.page2Btn2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page2Btn2.Location = new System.Drawing.Point(429, 62);
            this.page2Btn2.Name = "page2Btn2";
            this.page2Btn2.Size = new System.Drawing.Size(147, 59);
            this.page2Btn2.TabIndex = 1;
            this.page2Btn2.Text = "Welcome";
            this.page2Btn2.UseVisualStyleBackColor = true;
            this.page2Btn2.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // page1Btn1
            // 
            this.page1Btn1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page1Btn1.Location = new System.Drawing.Point(175, 62);
            this.page1Btn1.Name = "page1Btn1";
            this.page1Btn1.Size = new System.Drawing.Size(147, 59);
            this.page1Btn1.TabIndex = 0;
            this.page1Btn1.Text = "Alert";
            this.page1Btn1.UseVisualStyleBackColor = true;
            this.page1Btn1.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.button3);
            this.Page2.Controls.Add(this.button4);
            this.Page2.Controls.Add(this.button5);
            this.Page2.Controls.Add(this.button6);
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
            this.Page3.Controls.Add(this.button7);
            this.Page3.Controls.Add(this.button8);
            this.Page3.Controls.Add(this.button9);
            this.Page3.Controls.Add(this.button10);
            this.Page3.Location = new System.Drawing.Point(4, 22);
            this.Page3.Name = "Page3";
            this.Page3.Padding = new System.Windows.Forms.Padding(3);
            this.Page3.Size = new System.Drawing.Size(792, 424);
            this.Page3.TabIndex = 2;
            this.Page3.Text = "Page3";
            this.Page3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(420, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 59);
            this.button3.TabIndex = 8;
            this.button3.Text = "covai";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(166, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 59);
            this.button4.TabIndex = 7;
            this.button4.Text = "Good Morning";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(420, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 59);
            this.button5.TabIndex = 6;
            this.button5.Text = "Welcome";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(166, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 59);
            this.button6.TabIndex = 5;
            this.button6.Text = "Alert";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(425, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 59);
            this.button7.TabIndex = 12;
            this.button7.Text = "covai";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(171, 237);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 59);
            this.button8.TabIndex = 11;
            this.button8.Text = "Good Morning";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(425, 128);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(147, 59);
            this.button9.TabIndex = 10;
            this.button9.Text = "Welcome";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(171, 128);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(147, 59);
            this.button10.TabIndex = 9;
            this.button10.Text = "Alert";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.GenerateNotification);
            // 
            // manager1
            // 
            this.manager1.CornerRadius = 20;
            this.manager1.GetPosition = Notifier.Manager.Position.Left;
            this.manager1.Location = new System.Drawing.Point(0, 0);
            this.manager1.Msg = null;
            this.manager1.TimeStamp = new System.DateTime(((long)(0)));
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
            this.Page2.ResumeLayout(false);
            this.Page3.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Manager manager1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

