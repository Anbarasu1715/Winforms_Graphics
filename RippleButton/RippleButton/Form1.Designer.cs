namespace RippleButton
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
            this.customBtn1 = new RippleButton.CustomBtn();
            this.SuspendLayout();
            // 
            // customBtn1
            // 
            this.customBtn1.Location = new System.Drawing.Point(198, 148);
            this.customBtn1.Name = "customBtn1";
            this.customBtn1.Size = new System.Drawing.Size(384, 175);
            this.customBtn1.TabIndex = 0;
            this.customBtn1.Text = "customBtn1";
            this.customBtn1.UseVisualStyleBackColor = true;
            this.customBtn1.Click += new System.EventHandler(this.customBtn1_Click);
            this.customBtn1.Paint += new System.Windows.Forms.PaintEventHandler(this.customBtn1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.customBtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomBtn customBtn1;
    }
}

