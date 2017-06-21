namespace LP
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dbi364679DataSet = new LP.dbi364679DataSet();
            this.uitslagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uitslagTableAdapter = new LP.dbi364679DataSetTableAdapters.UitslagTableAdapter();
            this.tableAdapterManager = new LP.dbi364679DataSetTableAdapters.TableAdapterManager();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.btnExp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbi364679DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbi364679DataSet
            // 
            this.dbi364679DataSet.DataSetName = "dbi364679DataSet";
            this.dbi364679DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uitslagBindingSource
            // 
            this.uitslagBindingSource.DataMember = "Uitslag";
            this.uitslagBindingSource.DataSource = this.dbi364679DataSet;
            // 
            // uitslagTableAdapter
            // 
            this.uitslagTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PartijTableAdapter = null;
            this.tableAdapterManager.UitslagTableAdapter = this.uitslagTableAdapter;
            this.tableAdapterManager.UpdateOrder = LP.dbi364679DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VerkiezingenTableAdapter = null;
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.White;
            this.pnlDraw.Location = new System.Drawing.Point(49, 28);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(455, 363);
            this.pnlDraw.TabIndex = 0;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(620, 119);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(75, 23);
            this.btnExp.TabIndex = 1;
            this.btnExp.Text = "Export";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 446);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.pnlDraw);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dbi364679DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dbi364679DataSet dbi364679DataSet;
        private System.Windows.Forms.BindingSource uitslagBindingSource;
        private dbi364679DataSetTableAdapters.UitslagTableAdapter uitslagTableAdapter;
        private dbi364679DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Button btnExp;
    }
}