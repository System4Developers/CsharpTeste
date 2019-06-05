namespace s4d_biomedicina.Apresentacao
{
    partial class frmPacientesDadosCadastrais
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
            this.gpbPaciente = new System.Windows.Forms.GroupBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbRg = new System.Windows.Forms.TextBox();
            this.txbDtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbProfissao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbGrauInstrucao = new System.Windows.Forms.TextBox();
            this.txbProntuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbInfoAdicional = new System.Windows.Forms.GroupBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txbGrupoSanguineo = new System.Windows.Forms.TextBox();
            this.lblGrupoSanguineo = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpbPaciente.SuspendLayout();
            this.gpbInfoAdicional.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPaciente
            // 
            this.gpbPaciente.Controls.Add(this.txbNome);
            this.gpbPaciente.Controls.Add(this.lblNome);
            this.gpbPaciente.Controls.Add(this.txbRg);
            this.gpbPaciente.Controls.Add(this.txbDtNascimento);
            this.gpbPaciente.Controls.Add(this.lblRg);
            this.gpbPaciente.Controls.Add(this.txbCpf);
            this.gpbPaciente.Controls.Add(this.cmbEstado);
            this.gpbPaciente.Controls.Add(this.lblCpf);
            this.gpbPaciente.Controls.Add(this.lblID);
            this.gpbPaciente.Controls.Add(this.lblDtNascimento);
            this.gpbPaciente.Controls.Add(this.txbID);
            this.gpbPaciente.Controls.Add(this.txbProfissao);
            this.gpbPaciente.Controls.Add(this.label8);
            this.gpbPaciente.Controls.Add(this.lblProfissao);
            this.gpbPaciente.Controls.Add(this.label12);
            this.gpbPaciente.Controls.Add(this.txbGrauInstrucao);
            this.gpbPaciente.Controls.Add(this.txbProntuario);
            this.gpbPaciente.Controls.Add(this.label4);
            this.gpbPaciente.Location = new System.Drawing.Point(23, 31);
            this.gpbPaciente.Name = "gpbPaciente";
            this.gpbPaciente.Size = new System.Drawing.Size(671, 179);
            this.gpbPaciente.TabIndex = 56;
            this.gpbPaciente.TabStop = false;
            this.gpbPaciente.Text = "Paciente";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(52, 62);
            this.txbNome.Margin = new System.Windows.Forms.Padding(2);
            this.txbNome.Name = "txbNome";
            this.txbNome.ReadOnly = true;
            this.txbNome.Size = new System.Drawing.Size(596, 20);
            this.txbNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 62);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome";
            // 
            // txbRg
            // 
            this.txbRg.Location = new System.Drawing.Point(52, 97);
            this.txbRg.Margin = new System.Windows.Forms.Padding(2);
            this.txbRg.Name = "txbRg";
            this.txbRg.ReadOnly = true;
            this.txbRg.Size = new System.Drawing.Size(151, 20);
            this.txbRg.TabIndex = 4;
            // 
            // txbDtNascimento
            // 
            this.txbDtNascimento.Location = new System.Drawing.Point(528, 95);
            this.txbDtNascimento.Mask = "00/00/0000";
            this.txbDtNascimento.Name = "txbDtNascimento";
            this.txbDtNascimento.ReadOnly = true;
            this.txbDtNascimento.Size = new System.Drawing.Size(120, 20);
            this.txbDtNascimento.TabIndex = 6;
            this.txbDtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(13, 98);
            this.lblRg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(23, 13);
            this.lblRg.TabIndex = 17;
            this.lblRg.Text = "RG";
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(238, 95);
            this.txbCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.ReadOnly = true;
            this.txbCpf.Size = new System.Drawing.Size(188, 20);
            this.txbCpf.TabIndex = 5;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "ATIVADO",
            "DESATIVADO"});
            this.cmbEstado.Location = new System.Drawing.Point(519, 134);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(129, 21);
            this.cmbEstado.TabIndex = 9;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(207, 98);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 19;
            this.lblCpf.Text = "CPF";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 30);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "ID";
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Location = new System.Drawing.Point(437, 98);
            this.lblDtNascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(86, 13);
            this.lblDtNascimento.TabIndex = 21;
            this.lblDtNascimento.Text = "Dat. Nascimento";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(52, 27);
            this.txbID.Margin = new System.Windows.Forms.Padding(2);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(68, 20);
            this.txbID.TabIndex = 1;
            // 
            // txbProfissao
            // 
            this.txbProfissao.Location = new System.Drawing.Point(306, 133);
            this.txbProfissao.Margin = new System.Windows.Forms.Padding(2);
            this.txbProfissao.Name = "txbProfissao";
            this.txbProfissao.ReadOnly = true;
            this.txbProfissao.Size = new System.Drawing.Size(120, 20);
            this.txbProfissao.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Estado";
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(252, 136);
            this.lblProfissao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(50, 13);
            this.lblProfissao.TabIndex = 23;
            this.lblProfissao.Text = "Profissao";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Pronturario";
            // 
            // txbGrauInstrucao
            // 
            this.txbGrauInstrucao.Location = new System.Drawing.Point(115, 134);
            this.txbGrauInstrucao.Margin = new System.Windows.Forms.Padding(2);
            this.txbGrauInstrucao.Name = "txbGrauInstrucao";
            this.txbGrauInstrucao.ReadOnly = true;
            this.txbGrauInstrucao.Size = new System.Drawing.Size(119, 20);
            this.txbGrauInstrucao.TabIndex = 7;
            // 
            // txbProntuario
            // 
            this.txbProntuario.Location = new System.Drawing.Point(188, 27);
            this.txbProntuario.Margin = new System.Windows.Forms.Padding(2);
            this.txbProntuario.Name = "txbProntuario";
            this.txbProntuario.ReadOnly = true;
            this.txbProntuario.Size = new System.Drawing.Size(460, 20);
            this.txbProntuario.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Grau de Instrucao";
            // 
            // gpbInfoAdicional
            // 
            this.gpbInfoAdicional.Controls.Add(this.lblPeso);
            this.gpbInfoAdicional.Controls.Add(this.txbPeso);
            this.gpbInfoAdicional.Controls.Add(this.txbAltura);
            this.gpbInfoAdicional.Controls.Add(this.lblAltura);
            this.gpbInfoAdicional.Controls.Add(this.txbGrupoSanguineo);
            this.gpbInfoAdicional.Controls.Add(this.lblGrupoSanguineo);
            this.gpbInfoAdicional.Location = new System.Drawing.Point(23, 234);
            this.gpbInfoAdicional.Name = "gpbInfoAdicional";
            this.gpbInfoAdicional.Size = new System.Drawing.Size(671, 71);
            this.gpbInfoAdicional.TabIndex = 55;
            this.gpbInfoAdicional.TabStop = false;
            this.gpbInfoAdicional.Text = "Informacoes Adicionais";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(13, 33);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 29;
            this.lblPeso.Text = "Peso";
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(52, 29);
            this.txbPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.ReadOnly = true;
            this.txbPeso.Size = new System.Drawing.Size(69, 20);
            this.txbPeso.TabIndex = 16;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(262, 30);
            this.txbAltura.Margin = new System.Windows.Forms.Padding(2);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.ReadOnly = true;
            this.txbAltura.Size = new System.Drawing.Size(83, 20);
            this.txbAltura.TabIndex = 17;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(224, 33);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 31;
            this.lblAltura.Text = "Altura";
            // 
            // txbGrupoSanguineo
            // 
            this.txbGrupoSanguineo.Location = new System.Drawing.Point(519, 29);
            this.txbGrupoSanguineo.Margin = new System.Windows.Forms.Padding(2);
            this.txbGrupoSanguineo.Name = "txbGrupoSanguineo";
            this.txbGrupoSanguineo.ReadOnly = true;
            this.txbGrupoSanguineo.Size = new System.Drawing.Size(129, 20);
            this.txbGrupoSanguineo.TabIndex = 18;
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.AutoSize = true;
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(417, 31);
            this.lblGrupoSanguineo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(90, 13);
            this.lblGrupoSanguineo.TabIndex = 33;
            this.lblGrupoSanguineo.Text = "Grupo Sanguineo";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.Location = new System.Drawing.Point(546, 325);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 38);
            this.btnEditar.TabIndex = 53;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmPacientesDadosCadastrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 390);
            this.Controls.Add(this.gpbPaciente);
            this.Controls.Add(this.gpbInfoAdicional);
            this.Controls.Add(this.btnEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPacientesDadosCadastrais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPacienteDadosCadastrais";
            this.Load += new System.EventHandler(this.frmPacienteDadosCadastrais_Load);
            this.gpbPaciente.ResumeLayout(false);
            this.gpbPaciente.PerformLayout();
            this.gpbInfoAdicional.ResumeLayout(false);
            this.gpbInfoAdicional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPaciente;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbRg;
        private System.Windows.Forms.MaskedTextBox txbDtNascimento;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbProfissao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbGrauInstrucao;
        private System.Windows.Forms.TextBox txbProntuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbInfoAdicional;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txbGrupoSanguineo;
        private System.Windows.Forms.Label lblGrupoSanguineo;
        private System.Windows.Forms.Button btnEditar;
    }
}