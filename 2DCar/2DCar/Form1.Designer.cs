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
            this.carUC3 = new _2DCar.carUC();
            this.carUC2 = new _2DCar.carUC();
            this.carUC1 = new _2DCar.carUC();
            this.SuspendLayout();
            // 
            // carUC3
            // 
            this.carUC3.Location = new System.Drawing.Point(529, 549);
            this.carUC3.Name = "carUC3";
            this.carUC3.Size = new System.Drawing.Size(210, 112);
            this.carUC3.TabIndex = 2;
            // 
            // carUC2
            // 
            this.carUC2.Location = new System.Drawing.Point(1, 549);
            this.carUC2.Name = "carUC2";
            this.carUC2.Size = new System.Drawing.Size(210, 112);
            this.carUC2.TabIndex = 1;
            // 
            // carUC1
            // 
            this.carUC1.Location = new System.Drawing.Point(241, 549);
            this.carUC1.Name = "carUC1";
            this.carUC1.Size = new System.Drawing.Size(210, 112);
            this.carUC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.carUC3);
            this.Controls.Add(this.carUC2);
            this.Controls.Add(this.carUC1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private carUC carUC1;
        private carUC carUC2;
        private carUC carUC3;
    }
}

