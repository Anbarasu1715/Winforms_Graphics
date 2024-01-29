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
            this.logoUC1 = new LucidLogo.LogoUC();
            this.logoTransUC1 = new LucidLogo.LogoTransUC();
            this.SuspendLayout();
            // 
            // logoUC1
            // 
            this.logoUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(98)))), ((int)(((byte)(177)))));
            this.logoUC1.Location = new System.Drawing.Point(72, 139);
            this.logoUC1.Name = "logoUC1";
            this.logoUC1.Size = new System.Drawing.Size(250, 300);
            this.logoUC1.TabIndex = 0;
            // 
            // logoTransUC1
            // 
            this.logoTransUC1.Location = new System.Drawing.Point(407, 154);
            this.logoTransUC1.Name = "logoTransUC1";
            this.logoTransUC1.Size = new System.Drawing.Size(300, 300);
            this.logoTransUC1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(781, 595);
            this.Controls.Add(this.logoTransUC1);
            this.Controls.Add(this.logoUC1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LogoUC logoUC1;
        private LogoTransUC logoTransUC1;
    }
}

