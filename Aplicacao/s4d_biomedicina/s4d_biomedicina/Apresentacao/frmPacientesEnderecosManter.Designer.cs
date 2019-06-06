namespace s4d_biomedicina.Apresentacao
{
    partial class frmPacientesEnderecosManter
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
            this.gpbLocalidade = new System.Windows.Forms.GroupBox();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.txbCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.txbRua = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbLocalidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLocalidade
            // 
            this.gpbLocalidade.Controls.Add(this.lblInformacao);
            this.gpbLocalidade.Controls.Add(this.txbCep);
            this.gpbLocalidade.Controls.Add(this.lblCEP);
            this.gpbLocalidade.Controls.Add(this.txbComplemento);
            this.gpbLocalidade.Controls.Add(this.label1);
            this.gpbLocalidade.Controls.Add(this.txbNumero);
            this.gpbLocalidade.Controls.Add(this.txbEstado);
            this.gpbLocalidade.Controls.Add(this.txbRua);
            this.gpbLocalidade.Controls.Add(this.lblEstado);
            this.gpbLocalidade.Controls.Add(this.lblLogradouro);
            this.gpbLocalidade.Controls.Add(this.txbCidade);
            this.gpbLocalidade.Controls.Add(this.lblBairro);
            this.gpbLocalidade.Controls.Add(this.lblCidade);
            this.gpbLocalidade.Controls.Add(this.txbBairro);
            this.gpbLocalidade.Controls.Add(this.lblNumero);
            this.gpbLocalidade.Location = new System.Drawing.Point(12, 12);
            this.gpbLocalidade.Name = "gpbLocalidade";
            this.gpbLocalidade.Size = new System.Drawing.Size(665, 164);
            this.gpbLocalidade.TabIndex = 51;
            this.gpbLocalidade.TabStop = false;
            this.gpbLocalidade.Text = "Localidade";
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.BackColor = System.Drawing.SystemColors.Control;
            this.lblInformacao.ForeColor = System.Drawing.Color.Red;
            this.lblInformacao.Location = new System.Drawing.Point(210, 29);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(0, 13);
            this.lblInformacao.TabIndex = 54;
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(77, 23);
            this.txbCep.Mask = "00000-000";
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(126, 20);
            this.txbCep.TabIndex = 53;
            this.txbCep.Leave += new System.EventHandler(this.txbCep_Leave);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(15, 26);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 52;
            this.lblCEP.Text = "CEP";
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(299, 88);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(349, 20);
            this.txbComplemento.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Complemento";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(77, 88);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(124, 20);
            this.txbNumero.TabIndex = 14;
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(299, 121);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(142, 20);
            this.txbEstado.TabIndex = 11;
            // 
            // txbRua
            // 
            this.txbRua.Location = new System.Drawing.Point(77, 54);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(571, 20);
            this.txbRua.TabIndex = 12;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(222, 124);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 48;
            this.lblEstado.Text = "Estado";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(13, 57);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 42;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(513, 121);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(135, 20);
            this.txbCidade.TabIndex = 10;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(14, 124);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 42;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(467, 124);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 46;
            this.lblCidade.Text = "Cidade";
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(77, 121);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(126, 20);
            this.txbBairro.TabIndex = 13;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(15, 91);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 44;
            this.lblNumero.Text = "Numero";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalvar.Location = new System.Drawing.Point(340, 191);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 38);
            this.btnSalvar.TabIndex = 54;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.Location = new System.Drawing.Point(512, 191);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 38);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPacientesEnderecosManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 254);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpbLocalidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPacientesEnderecosManter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPacientesEnderecosManter";
            this.Load += new System.EventHandler(this.frmPacientesEnderecosManter_Load);
            this.gpbLocalidade.ResumeLayout(false);
            this.gpbLocalidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLocalidade;
        private System.Windows.Forms.MaskedTextBox txbCep;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.TextBox txbRua;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Button btnCancelar;
    }
}