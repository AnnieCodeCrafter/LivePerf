namespace LP
{
    partial class btnCoalRtrn
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnPart.Location = new System.Drawing.Point(154, 179);
            this.btnPart.Name = "btnPart";
            this.btnPart.Size = new System.Drawing.Size(153, 23);
            this.btnPart.TabIndex = 1;
            this.btnPart.Text = "Partij";
            this.btnPart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Coalitie Ophalen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCoalRtrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPart);
            this.Controls.Add(this.btnCoal);
            this.Name = "btnCoalRtrn";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCoal;
        private System.Windows.Forms.Button btnPart;
        private System.Windows.Forms.Button button1;
    }
}

