namespace s4d_biomedicina.Apresentacao
{
    partial class frmPacientesMain
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
            this.lblDadosCadastrais = new System.Windows.Forms.Label();
            this.lblEnderecos = new System.Windows.Forms.Label();
            this.lblAgendamentos = new System.Windows.Forms.Label();
            this.lblExames = new System.Windows.Forms.Label();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.lblFechar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDadosCadastrais
            // 
            this.lblDadosCadastrais.AutoSize = true;
            this.lblDadosCadastrais.Location = new System.Drawing.Point(97, 31);
            this.lblDadosCadastrais.Name = "lblDadosCadastrais";
            this.lblDadosCadastrais.Size = new System.Drawing.Size(116, 13);
            this.lblDadosCadastrais.TabIndex = 0;
            this.lblDadosCadastrais.Text = "DADOS CADASTRAIS";
            this.lblDadosCadastrais.Click += new System.EventHandler(this.lblDados_Click);
            // 
            // lblEnderecos
            // 
            this.lblEnderecos.AutoSize = true;
            this.lblEnderecos.Location = new System.Drawing.Point(356, 31);
            this.lblEnderecos.Name = "lblEnderecos";
            this.lblEnderecos.Size = new System.Drawing.Size(74, 13);
            this.lblEnderecos.TabIndex = 1;
            this.lblEnderecos.Text = "ENDEREÇOS";
            this.lblEnderecos.Click += new System.EventHandler(this.lblEnderecos_Click);
            // 
            // lblAgendamentos
            // 
            this.lblAgendamentos.AutoSize = true;
            this.lblAgendamentos.Location = new System.Drawing.Point(642, 31);
            this.lblAgendamentos.Name = "lblAgendamentos";
            this.lblAgendamentos.Size = new System.Drawing.Size(98, 13);
            this.lblAgendamentos.TabIndex = 2;
            this.lblAgendamentos.Text = "AGENDAMENTOS";
            this.lblAgendamentos.Click += new System.EventHandler(this.lblAgendamentos_Click);
            // 
            // lblExames
            // 
            this.lblExames.AutoSize = true;
            this.lblExames.Location = new System.Drawing.Point(941, 31);
            this.lblExames.Name = "lblExames";
            this.lblExames.Size = new System.Drawing.Size(51, 13);
            this.lblExames.TabIndex = 3;
            this.lblExames.Text = "EXAMES";
            this.lblExames.Click += new System.EventHandler(this.lblExames_Click);
            // 
            // pnlForms
            // 
            this.pnlForms.Location = new System.Drawing.Point(-1, 65);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(1313, 639);
            this.pnlForms.TabIndex = 4;
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Location = new System.Drawing.Point(1112, 31);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(125, 13);
            this.lblFechar.TabIndex = 5;
            this.lblFechar.Text = "FECHAR PRONTUÁRIO";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // frmPacientesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 716);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.lblExames);
            this.Controls.Add(this.lblAgendamentos);
            this.Controls.Add(this.lblEnderecos);
            this.Controls.Add(this.lblDadosCadastrais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPacientesMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPacienteMain";
            this.Load += new System.EventHandler(this.frmPacientesMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDadosCadastrais;
        private System.Windows.Forms.Label lblEnderecos;
        private System.Windows.Forms.Label lblAgendamentos;
        private System.Windows.Forms.Label lblExames;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Label lblFechar;
    }
}