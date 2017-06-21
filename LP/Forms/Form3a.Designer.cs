namespace LP
{
    partial class Form3a
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
            this.lbData = new System.Windows.Forms.ListBox();
            this.lbUitsl = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.Location = new System.Drawing.Point(12, 12);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(253, 433);
            this.lbData.TabIndex = 0;
            // 
            // lbUitsl
            // 
            this.lbUitsl.FormattingEnabled = true;
            this.lbUitsl.Location = new System.Drawing.Point(310, 12);
            this.lbUitsl.Name = "lbUitsl";
            this.lbUitsl.Size = new System.Drawing.Size(257, 433);
            this.lbUitsl.TabIndex = 1;
            // 
            // Form3a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 475);
            this.Controls.Add(this.lbUitsl);
            this.Controls.Add(this.lbData);
            this.Name = "Form3a";
            this.Text = "Form3a";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.ListBox lbUitsl;
    }
}