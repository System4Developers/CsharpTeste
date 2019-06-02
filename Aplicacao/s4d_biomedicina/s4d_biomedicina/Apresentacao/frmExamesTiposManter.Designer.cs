namespace s4d_biomedicina.Apresentacao
{
    partial class frmExamesTiposManter
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
            this.lblID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.unipBiomedicinaDataSet1 = new s4d_biomedicina.unipBiomedicinaDataSet1();
            this.examesAreasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examesAreasTableAdapter = new s4d_biomedicina.unipBiomedicinaDataSet1TableAdapters.examesAreasTableAdapter();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.unipBiomedicinaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examesAreasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(45, 38);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 45;
            this.lblID.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(192, 32);
            this.txbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(229, 22);
            this.txbID.TabIndex = 44;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(323, 278);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 43;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(45, 100);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(45, 17);
            this.lblArea.TabIndex = 42;
            this.lblArea.Text = "AREA";
            // 
            // txbTipo
            // 
            this.txbTipo.Location = new System.Drawing.Point(192, 153);
            this.txbTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(229, 22);
            this.txbTipo.TabIndex = 46;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(45, 220);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 17);
            this.lblStatus.TabIndex = 48;
            this.lblStatus.Text = "STATUS";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(45, 156);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(114, 17);
            this.lblTipo.TabIndex = 49;
            this.lblTipo.Text = "TIPO DE EXAME";
            // 
            // unipBiomedicinaDataSet1
            // 
            this.unipBiomedicinaDataSet1.DataSetName = "unipBiomedicinaDataSet1";
            this.unipBiomedicinaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examesAreasBindingSource
            // 
            this.examesAreasBindingSource.DataMember = "examesAreas";
            this.examesAreasBindingSource.DataSource = this.unipBiomedicinaDataSet1;
            // 
            // examesAreasTableAdapter
            // 
            this.examesAreasTableAdapter.ClearBeforeFill = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Habilitado",
            "Desabilitado"});
            this.cmbStatus.Location = new System.Drawing.Point(192, 220);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(229, 24);
            this.cmbStatus.TabIndex = 51;
            // 
            // cmbArea
            // 
            this.cmbArea.DataSource = this.examesAreasBindingSource;
            this.cmbArea.DisplayMember = "dsExameArea";
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(192, 100);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(229, 24);
            this.cmbArea.TabIndex = 52;
            this.cmbArea.ValueMember = "idExameArea";
            // 
            // frmExamesTiposManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 335);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txbTipo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblArea);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExamesTiposManter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExamesTiposManter";
            this.Load += new System.EventHandler(this.frmExamesTiposManter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unipBiomedicinaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examesAreasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txbTipo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTipo;
        private unipBiomedicinaDataSet1 unipBiomedicinaDataSet1;
        private System.Windows.Forms.BindingSource examesAreasBindingSource;
        private unipBiomedicinaDataSet1TableAdapters.examesAreasTableAdapter examesAreasTableAdapter;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbArea;
    }
}