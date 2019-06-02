namespace s4d_biomedicina.Apresentacao
{
    partial class frmExamesTipos
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txbDS = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvExamesTipos = new System.Windows.Forms.DataGridView();
            this.idExameTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsExameTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoExameTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkidExameAreaexamesAreasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examesTiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unipBiomedicinaDataSet3 = new s4d_biomedicina.unipBiomedicinaDataSet3();
            this.unipBiomedicinaDataSet1 = new s4d_biomedicina.unipBiomedicinaDataSet1();
            this.unipBiomedicinaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examesTiposTableAdapter = new s4d_biomedicina.unipBiomedicinaDataSet3TableAdapters.examesTiposTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examesTiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unipBiomedicinaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unipBiomedicinaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unipBiomedicinaDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(185, 54);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(102, 17);
            this.lblDescricao.TabIndex = 10;
            this.lblDescricao.Text = "Tipo do Exame";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(72, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID";
            // 
            // txbDS
            // 
            this.txbDS.Location = new System.Drawing.Point(188, 74);
            this.txbDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDS.Name = "txbDS";
            this.txbDS.Size = new System.Drawing.Size(279, 22);
            this.txbDS.TabIndex = 8;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(75, 74);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(100, 22);
            this.txbID.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(491, 68);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 34);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(188, 112);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 34);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(75, 112);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(97, 34);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvExamesTipos
            // 
            this.dgvExamesTipos.AllowUserToAddRows = false;
            this.dgvExamesTipos.AllowUserToDeleteRows = false;
            this.dgvExamesTipos.AutoGenerateColumns = false;
            this.dgvExamesTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamesTipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idExameTipoDataGridViewTextBoxColumn,
            this.dsExameTipoDataGridViewTextBoxColumn,
            this.estadoExameTipoDataGridViewTextBoxColumn,
            this.fkidExameAreaexamesAreasDataGridViewTextBoxColumn});
            this.dgvExamesTipos.DataSource = this.examesTiposBindingSource;
            this.dgvExamesTipos.Location = new System.Drawing.Point(75, 167);
            this.dgvExamesTipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExamesTipos.Name = "dgvExamesTipos";
            this.dgvExamesTipos.ReadOnly = true;
            this.dgvExamesTipos.RowTemplate.Height = 24;
            this.dgvExamesTipos.Size = new System.Drawing.Size(921, 332);
            this.dgvExamesTipos.TabIndex = 4;
            // 
            // idExameTipoDataGridViewTextBoxColumn
            // 
            this.idExameTipoDataGridViewTextBoxColumn.DataPropertyName = "idExameTipo";
            this.idExameTipoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idExameTipoDataGridViewTextBoxColumn.Name = "idExameTipoDataGridViewTextBoxColumn";
            this.idExameTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsExameTipoDataGridViewTextBoxColumn
            // 
            this.dsExameTipoDataGridViewTextBoxColumn.DataPropertyName = "dsExameTipo";
            this.dsExameTipoDataGridViewTextBoxColumn.HeaderText = "Tipo do Exame";
            this.dsExameTipoDataGridViewTextBoxColumn.Name = "dsExameTipoDataGridViewTextBoxColumn";
            this.dsExameTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoExameTipoDataGridViewTextBoxColumn
            // 
            this.estadoExameTipoDataGridViewTextBoxColumn.DataPropertyName = "estadoExameTipo";
            this.estadoExameTipoDataGridViewTextBoxColumn.HeaderText = "Status";
            this.estadoExameTipoDataGridViewTextBoxColumn.Name = "estadoExameTipoDataGridViewTextBoxColumn";
            this.estadoExameTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkidExameAreaexamesAreasDataGridViewTextBoxColumn
            // 
            this.fkidExameAreaexamesAreasDataGridViewTextBoxColumn.DataPropertyName = "fk_idExameArea_examesAreas";
            this.fkidExameAreaexamesAreasDataGridViewTextBoxColumn.HeaderText = "Área da Biomedicina";
            this.fkidExameAreaexamesAreasDataGridViewTextBoxColumn.Name = "fkidExameAreaexamesAreasDataGridViewTextBoxColumn";
            this.fkidExameAreaexamesAreasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // examesTiposBindingSource
            // 
            this.examesTiposBindingSource.DataMember = "examesTipos";
            this.examesTiposBindingSource.DataSource = this.unipBiomedicinaDataSet3;
            // 
            // unipBiomedicinaDataSet3
            // 
            this.unipBiomedicinaDataSet3.DataSetName = "unipBiomedicinaDataSet3";
            this.unipBiomedicinaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unipBiomedicinaDataSet1
            // 
            this.unipBiomedicinaDataSet1.DataSetName = "unipBiomedicinaDataSet1";
            this.unipBiomedicinaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unipBiomedicinaDataSet1BindingSource
            // 
            this.unipBiomedicinaDataSet1BindingSource.DataSource = this.unipBiomedicinaDataSet1;
            this.unipBiomedicinaDataSet1BindingSource.Position = 0;
            // 
            // examesTiposTableAdapter
            // 
            this.examesTiposTableAdapter.ClearBeforeFill = true;
            // 
            // frmExamesTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbDS);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvExamesTipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExamesTipos";
            this.Text = "frmExamesTipos";
            this.Load += new System.EventHandler(this.frmExamesTipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examesTiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unipBiomedicinaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unipBiomedicinaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unipBiomedicinaDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbDS;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvExamesTipos;
        private unipBiomedicinaDataSet1 unipBiomedicinaDataSet1;
        private System.Windows.Forms.BindingSource unipBiomedicinaDataSet1BindingSource;
        private unipBiomedicinaDataSet3 unipBiomedicinaDataSet3;
        private System.Windows.Forms.BindingSource examesTiposBindingSource;
        private unipBiomedicinaDataSet3TableAdapters.examesTiposTableAdapter examesTiposTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExameTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsExameTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoExameTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkidExameAreaexamesAreasDataGridViewTextBoxColumn;
    }
}