namespace s4d_biomedicina.Apresentacao
{
    partial class frmPacientesAgendamentos
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvPacientesAgendamentos = new System.Windows.Forms.DataGridView();
            this.btnNovoExame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesAgendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(610, 346);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 28);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar Agendamento";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(268, 346);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(150, 28);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "Novo Agendamento";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvPacientesAgendamentos
            // 
            this.dgvPacientesAgendamentos.AllowUserToAddRows = false;
            this.dgvPacientesAgendamentos.AllowUserToDeleteRows = false;
            this.dgvPacientesAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesAgendamentos.Location = new System.Drawing.Point(55, 58);
            this.dgvPacientesAgendamentos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPacientesAgendamentos.Name = "dgvPacientesAgendamentos";
            this.dgvPacientesAgendamentos.ReadOnly = true;
            this.dgvPacientesAgendamentos.RowTemplate.Height = 24;
            this.dgvPacientesAgendamentos.Size = new System.Drawing.Size(691, 270);
            this.dgvPacientesAgendamentos.TabIndex = 16;
            // 
            // btnNovoExame
            // 
            this.btnNovoExame.Location = new System.Drawing.Point(439, 346);
            this.btnNovoExame.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoExame.Name = "btnNovoExame";
            this.btnNovoExame.Size = new System.Drawing.Size(150, 28);
            this.btnNovoExame.TabIndex = 19;
            this.btnNovoExame.Text = "Atribuir Exames";
            this.btnNovoExame.UseVisualStyleBackColor = true;
            this.btnNovoExame.Click += new System.EventHandler(this.btnNovoExame_Click);
            // 
            // frmPacientesAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 404);
            this.Controls.Add(this.btnNovoExame);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvPacientesAgendamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPacientesAgendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPacientesAgendamentos";
            this.Load += new System.EventHandler(this.frmPacientesAgendamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesAgendamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvPacientesAgendamentos;
        private System.Windows.Forms.Button btnNovoExame;
    }
}