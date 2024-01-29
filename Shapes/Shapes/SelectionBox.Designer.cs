namespace Shapes
{
    partial class SelectionBox
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Window;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 15);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(116, 37);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Circle";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Window;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(12, 63);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(116, 37);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Rectangle";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Window;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(12, 113);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(116, 37);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Triangle";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // SelectionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(140, 170);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectionBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SelectionBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}