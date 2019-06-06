namespace s4d_biomedicina.Apresentacao
{
    partial class frmPacientesAgendamentosManter
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtpAgendamento = new System.Windows.Forms.DateTimePicker();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txbSolicitante = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpAgendamento
            // 
            this.dtpAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAgendamento.Location = new System.Drawing.Point(74, 60);
            this.dtpAgendamento.Name = "dtpAgendamento";
            this.dtpAgendamento.Size = new System.Drawing.Size(121, 20);
            this.dtpAgendamento.TabIndex = 0;
            // 
            // cmbHorario
            // 
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Items.AddRange(new object[] {
            "08:00",
            "08:45",
            "09:30",
            "10:15",
            "10:45"});
            this.cmbHorario.Location = new System.Drawing.Point(74, 128);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(121, 21);
            this.cmbHorario.TabIndex = 1;
            this.cmbHorario.SelectedIndexChanged += new System.EventHandler(this.cmbHorario_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(74, 322);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pendente",
            "Finalizado"});
            this.cmbStatus.Location = new System.Drawing.Point(74, 265);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 3;
            // 
            // txbSolicitante
            // 
            this.txbSolicitante.Location = new System.Drawing.Point(74, 198);
            this.txbSolicitante.Name = "txbSolicitante";
            this.txbSolicitante.Size = new System.Drawing.Size(121, 20);
            this.txbSolicitante.TabIndex = 4;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(74, 41);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(74, 112);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 6;
            this.lblHorario.Text = "Horário";
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Location = new System.Drawing.Point(74, 182);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(59, 13);
            this.lblSolicitante.TabIndex = 7;
            this.lblSolicitante.Text = "Solicitante:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(74, 249);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(124, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Estado do Agendamento";
            // 
            // frmPacientesAgendamentosManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 370);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSolicitante);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txbSolicitante);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.dtpAgendamento);
            this.Name = "frmPacientesAgendamentosManter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgendamentoManter";
            this.Load += new System.EventHandler(this.frmPacientesAgendamentosManter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpAgendamento;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txbSolicitante;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.Label lblStatus;
    }
}