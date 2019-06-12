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
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblGeral = new MaterialSkin.Controls.MaterialLabel();
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
            this.gpbPaciente.Location = new System.Drawing.Point(21, 130);
            this.gpbPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPaciente.Name = "gpbPaciente";
            this.gpbPaciente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPaciente.Size = new System.Drawing.Size(895, 220);
            this.gpbPaciente.TabIndex = 56;
            this.gpbPaciente.TabStop = false;
            this.gpbPaciente.Text = "Paciente";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(69, 76);
            this.txbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNome.Name = "txbNome";
            this.txbNome.ReadOnly = true;
            this.txbNome.Size = new System.Drawing.Size(793, 22);
            this.txbNome.TabIndex = 3;
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
            // txbRg
            // 
            this.txbRg.Location = new System.Drawing.Point(69, 119);
            this.txbRg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbRg.Name = "txbRg";
            this.txbRg.ReadOnly = true;
            this.txbRg.Size = new System.Drawing.Size(200, 22);
            this.txbRg.TabIndex = 4;
            // 
            // txbDtNascimento
            // 
            this.txbDtNascimento.Location = new System.Drawing.Point(704, 117);
            this.txbDtNascimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDtNascimento.Mask = "00/00/0000";
            this.txbDtNascimento.Name = "txbDtNascimento";
            this.txbDtNascimento.ReadOnly = true;
            this.txbDtNascimento.Size = new System.Drawing.Size(159, 22);
            this.txbDtNascimento.TabIndex = 6;
            this.txbDtNascimento.ValidatingType = typeof(System.DateTime);
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
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(317, 117);
            this.txbCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.ReadOnly = true;
            this.txbCpf.Size = new System.Drawing.Size(249, 22);
            this.txbCpf.TabIndex = 5;
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
            this.cmbEstado.TabIndex = 9;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(276, 121);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 17);
            this.lblCpf.TabIndex = 19;
            this.lblCpf.Text = "CPF";
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
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Location = new System.Drawing.Point(583, 121);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(112, 17);
            this.lblDtNascimento.TabIndex = 21;
            this.lblDtNascimento.Text = "Dat. Nascimento";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(69, 33);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(89, 22);
            this.txbID.TabIndex = 1;
            this.txbID.TabStop = false;
            // 
            // txbProfissao
            // 
            this.txbProfissao.Location = new System.Drawing.Point(408, 164);
            this.txbProfissao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbProfissao.Name = "txbProfissao";
            this.txbProfissao.ReadOnly = true;
            this.txbProfissao.Size = new System.Drawing.Size(159, 22);
            this.txbProfissao.TabIndex = 8;
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
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(336, 167);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(67, 17);
            this.lblProfissao.TabIndex = 23;
            this.lblProfissao.Text = "Profissao";
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
            // txbGrauInstrucao
            // 
            this.txbGrauInstrucao.Location = new System.Drawing.Point(153, 165);
            this.txbGrauInstrucao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbGrauInstrucao.Name = "txbGrauInstrucao";
            this.txbGrauInstrucao.ReadOnly = true;
            this.txbGrauInstrucao.Size = new System.Drawing.Size(157, 22);
            this.txbGrauInstrucao.TabIndex = 7;
            // 
            // txbProntuario
            // 
            this.txbProntuario.Location = new System.Drawing.Point(251, 33);
            this.txbProntuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbProntuario.Name = "txbProntuario";
            this.txbProntuario.ReadOnly = true;
            this.txbProntuario.Size = new System.Drawing.Size(612, 22);
            this.txbProntuario.TabIndex = 2;
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
            // gpbInfoAdicional
            // 
            this.gpbInfoAdicional.Controls.Add(this.lblPeso);
            this.gpbInfoAdicional.Controls.Add(this.txbPeso);
            this.gpbInfoAdicional.Controls.Add(this.txbAltura);
            this.gpbInfoAdicional.Controls.Add(this.lblAltura);
            this.gpbInfoAdicional.Controls.Add(this.txbGrupoSanguineo);
            this.gpbInfoAdicional.Controls.Add(this.lblGrupoSanguineo);
            this.gpbInfoAdicional.Location = new System.Drawing.Point(21, 380);
            this.gpbInfoAdicional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbInfoAdicional.Name = "gpbInfoAdicional";
            this.gpbInfoAdicional.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbInfoAdicional.Size = new System.Drawing.Size(895, 87);
            this.gpbInfoAdicional.TabIndex = 55;
            this.gpbInfoAdicional.TabStop = false;
            this.gpbInfoAdicional.Text = "Informacoes Adicionais";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(17, 41);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 17);
            this.lblPeso.TabIndex = 29;
            this.lblPeso.Text = "Peso";
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(69, 36);
            this.txbPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.ReadOnly = true;
            this.txbPeso.Size = new System.Drawing.Size(91, 22);
            this.txbPeso.TabIndex = 16;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(349, 37);
            this.txbAltura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.ReadOnly = true;
            this.txbAltura.Size = new System.Drawing.Size(109, 22);
            this.txbAltura.TabIndex = 17;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(299, 41);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(45, 17);
            this.lblAltura.TabIndex = 31;
            this.lblAltura.Text = "Altura";
            // 
            // txbGrupoSanguineo
            // 
            this.txbGrupoSanguineo.Location = new System.Drawing.Point(692, 36);
            this.txbGrupoSanguineo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbGrupoSanguineo.Name = "txbGrupoSanguineo";
            this.txbGrupoSanguineo.ReadOnly = true;
            this.txbGrupoSanguineo.Size = new System.Drawing.Size(171, 22);
            this.txbGrupoSanguineo.TabIndex = 18;
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.AutoSize = true;
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(556, 38);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(120, 17);
            this.lblGrupoSanguineo.TabIndex = 33;
            this.lblGrupoSanguineo.Text = "Grupo Sanguineo";
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(749, 507);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(136, 36);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(5, 85);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(933, 2);
            this.materialDivider1.TabIndex = 59;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblGeral
            // 
            this.lblGeral.AutoSize = true;
            this.lblGeral.Depth = 0;
            this.lblGeral.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGeral.Location = new System.Drawing.Point(16, 43);
            this.lblGeral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeral.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGeral.Name = "lblGeral";
            this.lblGeral.Size = new System.Drawing.Size(185, 24);
            this.lblGeral.TabIndex = 58;
            this.lblGeral.Text = "DADOS CADASTRAIS";
            // 
            // frmPacientesDadosCadastrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 577);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lblGeral);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gpbPaciente);
            this.Controls.Add(this.gpbInfoAdicional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPacientesDadosCadastrais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPacienteDadosCadastrais";
            this.Load += new System.EventHandler(this.frmPacienteDadosCadastrais_Load);
            this.gpbPaciente.ResumeLayout(false);
            this.gpbPaciente.PerformLayout();
            this.gpbInfoAdicional.ResumeLayout(false);
            this.gpbInfoAdicional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblGeral;
    }
}