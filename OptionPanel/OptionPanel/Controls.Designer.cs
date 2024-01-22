namespace OptionPanel
{
    partial class Controls
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
            this.recBtn = new System.Windows.Forms.Button();
            this.squareBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.triangleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recBtn
            // 
            this.recBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recBtn.Location = new System.Drawing.Point(-1, -1);
            this.recBtn.Name = "recBtn";
            this.recBtn.Size = new System.Drawing.Size(247, 50);
            this.recBtn.TabIndex = 0;
            this.recBtn.Text = "Rectangle";
            this.recBtn.UseVisualStyleBackColor = true;
            this.recBtn.Click += new System.EventHandler(this.recBtn_Click);
            // 
            // squareBtn
            // 
            this.squareBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareBtn.Location = new System.Drawing.Point(-1, 95);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(247, 50);
            this.squareBtn.TabIndex = 2;
            this.squareBtn.Text = "Square";
            this.squareBtn.UseVisualStyleBackColor = true;
            // 
            // circleBtn
            // 
            this.circleBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleBtn.Location = new System.Drawing.Point(-1, 47);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(247, 50);
            this.circleBtn.TabIndex = 3;
            this.circleBtn.Text = "Circle";
            this.circleBtn.UseVisualStyleBackColor = true;
            // 
            // triangleBtn
            // 
            this.triangleBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangleBtn.Location = new System.Drawing.Point(-1, 143);
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(247, 50);
            this.triangleBtn.TabIndex = 4;
            this.triangleBtn.Text = "Triangle";
            this.triangleBtn.UseVisualStyleBackColor = true;
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 193);
            this.ControlBox = false;
            this.Controls.Add(this.triangleBtn);
            this.Controls.Add(this.circleBtn);
            this.Controls.Add(this.squareBtn);
            this.Controls.Add(this.recBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Controls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Controls";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recBtn;
        private System.Windows.Forms.Button squareBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button triangleBtn;
    }
}