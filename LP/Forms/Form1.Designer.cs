namespace LP
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
            this.btnCoal = new System.Windows.Forms.Button();
            this.btnPart = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCoal
            // 
            this.btnCoal.Location = new System.Drawing.Point(154, 87);
            this.btnCoal.Name = "btnCoal";
            this.btnCoal.Size = new System.Drawing.Size(153, 23);
            this.btnCoal.TabIndex = 0;
            this.btnCoal.Text = "Nieuwe Coalitie";
            this.btnCoal.UseVisualStyleBackColor = true;
            this.btnCoal.Click += new System.EventHandler(this.btnCoal_Click);
            // 
            // btnPart
            // 
            this.btnPart.Location = new System.Drawing.Point(154, 239);
            this.btnPart.Name = "btnPart";
            this.btnPart.Size = new System.Drawing.Size(153, 23);
            this.btnPart.TabIndex = 1;
            this.btnPart.Text = "Partij";
            this.btnPart.UseVisualStyleBackColor = true;
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(154, 158);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(153, 23);
            this.btnExp.TabIndex = 2;
            this.btnExp.Text = "Exporteer Bestaande Coalitie";
            this.btnExp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 393);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnPart);
            this.Controls.Add(this.btnCoal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCoal;
        private System.Windows.Forms.Button btnPart;
        private System.Windows.Forms.Button btnExp;
    }
}

