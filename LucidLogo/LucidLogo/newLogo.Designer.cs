namespace LucidLogo
{
    partial class newLogo
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

        #region Component Designer generated code

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
            this.logoTransUC1.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoTransUC1.Location = new System.Drawing.Point(0, 0);
            this.logoTransUC1.Name = "logoTransUC1";
            this.logoTransUC1.Size = new System.Drawing.Size(304, 286);
            this.logoTransUC1.TabIndex = 0;
            // 
            // newLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logoTransUC1);
            this.Name = "newLogo";
            this.Size = new System.Drawing.Size(960, 286);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.newLogo_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private LogoTransUC logoTransUC1;
    }
}
