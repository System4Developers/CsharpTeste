namespace s4d_biomedicina.Apresentacao
{
    partial class frmPacientesManter
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
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.txbProfissao = new System.Windows.Forms.TextBox();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGrupoSanguineo = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbProntuario = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.gpbInfoAdicional = new System.Windows.Forms.GroupBox();
            this.txbGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.txbAltura = new System.Windows.Forms.MaskedTextBox();
            this.gpbPaciente = new System.Windows.Forms.GroupBox();
            this.txbRg = new System.Windows.Forms.MaskedTextBox();
            this.txbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txbDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txbGrauInstrucao = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gpbInfoAdicional.SuspendLayout();
            this.gpbPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(69, 76);
            this.txbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(793, 22);
            this.txbNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(17, 121);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(29, 17);
            this.lblRg.TabIndex = 17;
            this.lblRg.Text = "RG";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(276, 124);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 17);
            this.lblCpf.TabIndex = 19;
            this.lblCpf.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Grau de Instrucao";
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(336, 167);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(67, 17);
            this.lblProfissao.TabIndex = 23;
            this.lblProfissao.Text = "Profissao";
            // 
            // txbProfissao
            // 
            this.txbProfissao.Location = new System.Drawing.Point(408, 164);
            this.txbProfissao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbProfissao.Name = "txbProfissao";
            this.txbProfissao.Size = new System.Drawing.Size(159, 22);
            this.txbProfissao.TabIndex = 6;
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Location = new System.Drawing.Point(583, 121);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(112, 17);
            this.lblDtNascimento.TabIndex = 21;
            this.lblDtNascimento.Text = "Dat. Nascimento";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(69, 33);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(89, 22);
            this.txbID.TabIndex = 1;
            this.txbID.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(633, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Estado";
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.AutoSize = true;
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(567, 39);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(120, 17);
            this.lblGrupoSanguineo.TabIndex = 33;
            this.lblGrupoSanguineo.Text = "Grupo Sanguineo";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(303, 39);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(45, 17);
            this.lblAltura.TabIndex = 31;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(17, 39);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 17);
            this.lblPeso.TabIndex = 29;
            this.lblPeso.Text = "Peso";
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(64, 36);
            this.txbPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(91, 22);
            this.txbPeso.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(168, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Pronturario";
            // 
            // txbProntuario
            // 
            this.txbProntuario.Location = new System.Drawing.Point(251, 33);
            this.txbProntuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbProntuario.Name = "txbProntuario";
            this.txbProntuario.Size = new System.Drawing.Size(612, 22);
            this.txbProntuario.TabIndex = 2;
            this.txbProntuario.TabStop = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "ATIVADO",
            "DESATIVADO"});
            this.cmbEstado.Location = new System.Drawing.Point(692, 165);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(171, 24);
            this.cmbEstado.TabIndex = 7;
            // 
            // gpbInfoAdicional
            // 
            this.gpbInfoAdicional.Controls.Add(this.txbGrupoSanguineo);
            this.gpbInfoAdicional.Controls.Add(this.txbAltura);
            this.gpbInfoAdicional.Controls.Add(this.lblPeso);
            this.gpbInfoAdicional.Controls.Add(this.txbPeso);
            this.gpbInfoAdicional.Controls.Add(this.lblAltura);
            this.gpbInfoAdicional.Controls.Add(this.lblGrupoSanguineo);
            this.gpbInfoAdicional.Location = new System.Drawing.Point(16, 267);
            this.gpbInfoAdicional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbInfoAdicional.Name = "gpbInfoAdicional";
            this.gpbInfoAdicional.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbInfoAdicional.Size = new System.Drawing.Size(888, 80);
            this.gpbInfoAdicional.TabIndex = 51;
            this.gpbInfoAdicional.TabStop = false;
            this.gpbInfoAdicional.Text = "Informacoes Adicionais";
            // 
            // txbGrupoSanguineo
            // 
            this.txbGrupoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txbGrupoSanguineo.FormattingEnabled = true;
            this.txbGrupoSanguineo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.txbGrupoSanguineo.Location = new System.Drawing.Point(692, 36);
            this.txbGrupoSanguineo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbGrupoSanguineo.Name = "txbGrupoSanguineo";
            this.txbGrupoSanguineo.Size = new System.Drawing.Size(171, 24);
            this.txbGrupoSanguineo.TabIndex = 10;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(355, 36);
            this.txbAltura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbAltura.Mask = "0,00";
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(123, 22);
            this.txbAltura.TabIndex = 9;
            // 
            // gpbPaciente
            // 
            this.gpbPaciente.Controls.Add(this.txbRg);
            this.gpbPaciente.Controls.Add(this.txbCpf);
            this.gpbPaciente.Controls.Add(this.txbDtNascimento);
            this.gpbPaciente.Controls.Add(this.txbGrauInstrucao);
            this.gpbPaciente.Controls.Add(this.txbNome);
            this.gpbPaciente.Controls.Add(this.lblNome);
            this.gpbPaciente.Controls.Add(this.lblRg);
            this.gpbPaciente.Controls.Add(this.cmbEstado);
            this.gpbPaciente.Controls.Add(this.lblCpf);
            this.gpbPaciente.Controls.Add(this.lblID);
            this.gpbPaciente.Controls.Add(this.lblDtNascimento);
            this.gpbPaciente.Controls.Add(this.txbID);
            this.gpbPaciente.Controls.Add(this.txbProfissao);
            this.gpbPaciente.Controls.Add(this.label8);
            this.gpbPaciente.Controls.Add(this.lblProfissao);
            this.gpbPaciente.Controls.Add(this.label12);
            this.gpbPaciente.Controls.Add(this.txbProntuario);
            this.gpbPaciente.Controls.Add(this.label4);
            this.gpbPaciente.Location = new System.Drawing.Point(16, 4);
            this.gpbPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPaciente.Name = "gpbPaciente";
            this.gpbPaciente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPaciente.Size = new System.Drawing.Size(888, 244);
            this.gpbPaciente.TabIndex = 52;
            this.gpbPaciente.TabStop = false;
            this.gpbPaciente.Text = "Paciente";
            // 
            // txbRg
            // 
            this.txbRg.Location = new System.Drawing.Point(69, 121);
            this.txbRg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbRg.Mask = "000000000";
            this.txbRg.Name = "txbRg";
            this.txbRg.Size = new System.Drawing.Size(199, 22);
            this.txbRg.TabIndex = 2;
            this.txbRg.ValidatingType = typeof(int);
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(319, 119);
            this.txbCpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCpf.Mask = "00000000000";
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(248, 22);
            this.txbCpf.TabIndex = 3;
            this.txbCpf.ValidatingType = typeof(int);
            // 
            // txbDtNascimento
            // 
            this.txbDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txbDtNascimento.Location = new System.Drawing.Point(700, 119);
            this.txbDtNascimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDtNascimento.Name = "txbDtNascimento";
            this.txbDtNascimento.Size = new System.Drawing.Size(163, 22);
            this.txbDtNascimento.TabIndex = 4;
            // 
            // txbGrauInstrucao
            // 
            this.txbGrauInstrucao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txbGrauInstrucao.FormattingEnabled = true;
            this.txbGrauInstrucao.Items.AddRange(new object[] {
            "SUPERIOR",
            "FUNDAMENTAL",
            "BASICO"});
            this.txbGrauInstrucao.Location = new System.Drawing.Point(151, 164);
            this.txbGrauInstrucao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbGrauInstrucao.Name = "txbGrauInstrucao";
            this.txbGrauInstrucao.Size = new System.Drawing.Size(160, 24);
            this.txbGrauInstrucao.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Location = new System.Drawing.Point(768, 372);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(136, 36);
            this.btnSalvar.TabIndex = 53;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmPacientesManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 433);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpbPaciente);
            this.Controls.Add(this.gpbInfoAdicional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPacientesManter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.frmPacientesManter_Load);
            this.gpbInfoAdicional.ResumeLayout(false);
            this.gpbInfoAdicional.PerformLayout();
            this.gpbPaciente.ResumeLayout(false);
            this.gpbPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.TextBox txbProfissao;
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGrupoSanguineo;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbProntuario;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox gpbInfoAdicional;
        private System.Windows.Forms.GroupBox gpbPaciente;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private System.Windows.Forms.ComboBox txbGrupoSanguineo;
        private System.Windows.Forms.MaskedTextBox txbAltura;
        private System.Windows.Forms.MaskedTextBox txbRg;
        private System.Windows.Forms.MaskedTextBox txbCpf;
        private System.Windows.Forms.DateTimePicker txbDtNascimento;
        private System.Windows.Forms.ComboBox txbGrauInstrucao;
    }
}