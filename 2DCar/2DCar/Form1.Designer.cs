namespace _2DCar
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
            this.carUC2 = new _2DCar.carUC();
            this.carUC1 = new _2DCar.carUC();
            this.SuspendLayout();
            // 
            // carUC2
            // 
            this.carUC2.Location = new System.Drawing.Point(-1, 117);
            this.carUC2.Name = "carUC2";
            this.carUC2.Size = new System.Drawing.Size(314, 150);
            this.carUC2.TabIndex = 1;
            // 
            // carUC1
            // 
            this.carUC1.Location = new System.Drawing.Point(-1, 304);
            this.carUC1.Name = "carUC1";
            this.carUC1.Size = new System.Drawing.Size(314, 150);
            this.carUC1.TabIndex = 0;
            this.carUC1.Click += new System.EventHandler(this.carUC1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.carUC2);
            this.Controls.Add(this.carUC1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private carUC carUC1;
        private carUC carUC2;
    }
}

