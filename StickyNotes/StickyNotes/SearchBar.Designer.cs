namespace StickyNotes
{
    partial class SearchBar
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
            this.SearchBox_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchBox_TB
            // 
            this.SearchBox_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBox_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox_TB.ForeColor = System.Drawing.Color.White;
            this.SearchBox_TB.Location = new System.Drawing.Point(0, 0);
            this.SearchBox_TB.Multiline = true;
            this.SearchBox_TB.Name = "SearchBox_TB";
            this.SearchBox_TB.Size = new System.Drawing.Size(295, 28);
            this.SearchBox_TB.TabIndex = 0;
            this.SearchBox_TB.Tag = "";
            this.SearchBox_TB.Enter += new System.EventHandler(this.SearchBox_TB_Enter);
            this.SearchBox_TB.Leave += new System.EventHandler(this.SearchBox_TB_Leave);
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchBox_TB);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(295, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox_TB;
    }
}
