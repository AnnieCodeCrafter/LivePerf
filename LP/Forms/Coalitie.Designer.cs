namespace LP
{
    partial class Coalitie
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
            this.verkiezingenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verkiezingenTableAdapter = new LP.dbi364679DataSetTableAdapters.VerkiezingenTableAdapter();
            this.tableAdapterManager = new LP.dbi364679DataSetTableAdapters.TableAdapterManager();
            this.uitslagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uitslagTableAdapter = new LP.dbi364679DataSetTableAdapters.UitslagTableAdapter();
            this.DgvRes = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbi364679DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verkiezingenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRes)).BeginInit();
            this.SuspendLayout();
            // 
            // dbi364679DataSet
            // 
            this.dbi364679DataSet.DataSetName = "dbi364679DataSet";
            this.dbi364679DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verkiezingenBindingSource
            // 
            this.verkiezingenBindingSource.DataMember = "Verkiezingen";
            this.verkiezingenBindingSource.DataSource = this.dbi364679DataSet;
            // 
            // verkiezingenTableAdapter
            // 
            this.verkiezingenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PartijTableAdapter = null;
            this.tableAdapterManager.UitslagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LP.dbi364679DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VerkiezingenTableAdapter = this.verkiezingenTableAdapter;
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
            // DgvRes
            // 
            this.DgvRes.AllowUserToAddRows = false;
            this.DgvRes.AllowUserToDeleteRows = false;
            this.DgvRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRes.Location = new System.Drawing.Point(439, 12);
            this.DgvRes.MultiSelect = false;
            this.DgvRes.Name = "DgvRes";
            this.DgvRes.ReadOnly = true;
            this.DgvRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRes.Size = new System.Drawing.Size(475, 417);
            this.DgvRes.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naam Coalitie";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(54, 251);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Coalitie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 441);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DgvRes);
            this.Name = "Coalitie";
            this.Text = "Coalitie";
            ((System.ComponentModel.ISupportInitialize)(this.dbi364679DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verkiezingenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbi364679DataSet dbi364679DataSet;
        private System.Windows.Forms.BindingSource verkiezingenBindingSource;
        private dbi364679DataSetTableAdapters.VerkiezingenTableAdapter verkiezingenTableAdapter;
        private dbi364679DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource uitslagBindingSource;
        private dbi364679DataSetTableAdapters.UitslagTableAdapter uitslagTableAdapter;
        private System.Windows.Forms.DataGridView DgvRes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOK;
    }
}