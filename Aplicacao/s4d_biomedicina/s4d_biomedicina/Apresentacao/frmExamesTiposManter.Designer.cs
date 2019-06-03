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
            this.lblID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbDsArea = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(34, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 45;
            this.lblID.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(144, 26);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(173, 20);
            this.txbID.TabIndex = 44;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(242, 226);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 43;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(34, 81);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 13);
            this.lblArea.TabIndex = 42;
            this.lblArea.Text = "AREA";
            // 
            // txbTipo
            // 
            this.txbTipo.Location = new System.Drawing.Point(144, 124);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(173, 20);
            this.txbTipo.TabIndex = 46;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(34, 179);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 13);
            this.lblStatus.TabIndex = 48;
            this.lblStatus.Text = "STATUS";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(34, 127);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(90, 13);
            this.lblTipo.TabIndex = 49;
            this.lblTipo.Text = "TIPO DE EXAME";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "HABILITADO",
            "DESABILITADO"});
            this.cmbStatus.Location = new System.Drawing.Point(144, 179);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(173, 21);
            this.cmbStatus.TabIndex = 51;
            // 
            // cmbDsArea
            // 
            this.cmbDsArea.FormattingEnabled = true;
            this.cmbDsArea.Location = new System.Drawing.Point(144, 78);
            this.cmbDsArea.Name = "cmbDsArea";
            this.cmbDsArea.Size = new System.Drawing.Size(173, 21);
            this.cmbDsArea.TabIndex = 52;
            // 
            // frmExamesTiposManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 353);
            this.Controls.Add(this.cmbDsArea);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txbTipo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblArea);
            this.Name = "frmExamesTiposManter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExamesTiposManter";
            this.Load += new System.EventHandler(this.frmExamesTiposManter_Load);
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
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbDsArea;
    }
}