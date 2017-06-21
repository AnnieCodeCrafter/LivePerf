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
            this.txtCoalNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.DtpCoal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStem = new System.Windows.Forms.Button();
            this.NudStem = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dbi364679DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verkiezingenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStem)).BeginInit();
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
            this.DgvRes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRes_CellContentClick);
            // 
            // txtCoalNaam
            // 
            this.txtCoalNaam.Location = new System.Drawing.Point(114, 30);
            this.txtCoalNaam.Name = "txtCoalNaam";
            this.txtCoalNaam.Size = new System.Drawing.Size(193, 20);
            this.txtCoalNaam.TabIndex = 2;
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
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(15, 211);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(129, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Voeg Partij Toe";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(114, 362);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(86, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Exporteren";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // DtpCoal
            // 
            this.DtpCoal.Location = new System.Drawing.Point(114, 78);
            this.DtpCoal.Name = "DtpCoal";
            this.DtpCoal.Size = new System.Drawing.Size(200, 20);
            this.DtpCoal.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datum Coalitie";
            // 
            // btnStem
            // 
            this.btnStem.Location = new System.Drawing.Point(207, 211);
            this.btnStem.Name = "btnStem";
            this.btnStem.Size = new System.Drawing.Size(121, 23);
            this.btnStem.TabIndex = 9;
            this.btnStem.Text = "Verander Stemmen";
            this.btnStem.UseVisualStyleBackColor = true;
            this.btnStem.Click += new System.EventHandler(this.btnStem_Click);
            // 
            // NudStem
            // 
            this.NudStem.Location = new System.Drawing.Point(208, 263);
            this.NudStem.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NudStem.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudStem.Name = "NudStem";
            this.NudStem.Size = new System.Drawing.Size(120, 20);
            this.NudStem.TabIndex = 10;
            this.NudStem.ThousandsSeparator = true;
            this.NudStem.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Coalitie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 441);
            this.Controls.Add(this.NudStem);
            this.Controls.Add(this.btnStem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpCoal);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCoalNaam);
            this.Controls.Add(this.DgvRes);
            this.Name = "Coalitie";
            this.Text = "Coalitie";
            ((System.ComponentModel.ISupportInitialize)(this.dbi364679DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verkiezingenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStem)).EndInit();
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
        private System.Windows.Forms.TextBox txtCoalNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker DtpCoal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStem;
        private System.Windows.Forms.NumericUpDown NudStem;
    }
}