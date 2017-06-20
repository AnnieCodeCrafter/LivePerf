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
            this.uitslagDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbi364679DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verkiezingenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagDataGridView)).BeginInit();
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
            // uitslagDataGridView
            // 
            this.uitslagDataGridView.AutoGenerateColumns = false;
            this.uitslagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uitslagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.uitslagDataGridView.DataSource = this.uitslagBindingSource;
            this.uitslagDataGridView.Location = new System.Drawing.Point(27, 27);
            this.uitslagDataGridView.Name = "uitslagDataGridView";
            this.uitslagDataGridView.Size = new System.Drawing.Size(580, 332);
            this.uitslagDataGridView.TabIndex = 0;
             // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Stemmen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Stemmen";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Percentage";
            this.dataGridViewTextBoxColumn3.HeaderText = "Percentage";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Zetels";
            this.dataGridViewTextBoxColumn4.HeaderText = "Zetels";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PartijID";
            this.dataGridViewTextBoxColumn5.HeaderText = "PartijID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Coalitie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 392);
            this.Controls.Add(this.uitslagDataGridView);
            this.Name = "Coalitie";
            this.Text = "Coalitie";
            ((System.ComponentModel.ISupportInitialize)(this.dbi364679DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verkiezingenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dbi364679DataSet dbi364679DataSet;
        private System.Windows.Forms.BindingSource verkiezingenBindingSource;
        private dbi364679DataSetTableAdapters.VerkiezingenTableAdapter verkiezingenTableAdapter;
        private dbi364679DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource uitslagBindingSource;
        private dbi364679DataSetTableAdapters.UitslagTableAdapter uitslagTableAdapter;
        private System.Windows.Forms.DataGridView uitslagDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}