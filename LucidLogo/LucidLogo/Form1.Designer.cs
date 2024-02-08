namespace LucidLogo
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
            this.logoTransUC1 = new LucidLogo.LogoTransUC();
            this.SuspendLayout();
            // 
            // logoTransUC1
            // 
            this.logoTransUC1.GetDirection = LucidLogo.LogoTransUC.Direction.ClockWise;
            this.logoTransUC1.Location = new System.Drawing.Point(84, 85);
            this.logoTransUC1.Name = "logoTransUC1";
            this.logoTransUC1.Size = new System.Drawing.Size(340, 267);
            this.logoTransUC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1161, 520);
            this.Controls.Add(this.logoTransUC1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LogoTransUC logoTransUC1;
    }
}

