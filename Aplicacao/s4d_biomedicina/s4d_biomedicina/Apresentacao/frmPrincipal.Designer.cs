namespace s4d_biomedicina.Apresentacao
{
    partial class frmPrincipal
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
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.tsmArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExames = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExamesAreas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExamesTipos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExamesParametros = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArquivo,
            this.tsmConsulta});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1301, 24);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // tsmArquivo
            // 
            this.tsmArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTrocarUsuario,
            this.tsmSair});
            this.tsmArquivo.Name = "tsmArquivo";
            this.tsmArquivo.Size = new System.Drawing.Size(61, 20);
            this.tsmArquivo.Text = "Arquivo";
            // 
            // tsmTrocarUsuario
            // 
            this.tsmTrocarUsuario.Name = "tsmTrocarUsuario";
            this.tsmTrocarUsuario.Size = new System.Drawing.Size(149, 22);
            this.tsmTrocarUsuario.Text = "Trocar Usuario";
            this.tsmTrocarUsuario.Click += new System.EventHandler(this.tsmTrocarUsuario_Click);
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(149, 22);
            this.tsmSair.Text = "Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // tsmConsulta
            // 
            this.tsmConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiPacientes,
            this.tsiUsuarios,
            this.tsmExames,
            this.agendamentosToolStripMenuItem});
            this.tsmConsulta.Name = "tsmConsulta";
            this.tsmConsulta.Size = new System.Drawing.Size(66, 20);
            this.tsmConsulta.Text = "Consulta";
            // 
            // tsiPacientes
            // 
            this.tsiPacientes.Name = "tsiPacientes";
            this.tsiPacientes.Size = new System.Drawing.Size(180, 22);
            this.tsiPacientes.Text = "Pacientes";
            this.tsiPacientes.Click += new System.EventHandler(this.tsiPacientes_Click);
            // 
            // tsiUsuarios
            // 
            this.tsiUsuarios.Name = "tsiUsuarios";
            this.tsiUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsiUsuarios.Text = "Usuarios";
            this.tsiUsuarios.Click += new System.EventHandler(this.tsiUsuarios_Click);
            // 
            // tsmExames
            // 
            this.tsmExames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiExamesAreas,
            this.tsiExamesTipos,
            this.tsiExamesParametros});
            this.tsmExames.Name = "tsmExames";
            this.tsmExames.Size = new System.Drawing.Size(180, 22);
            this.tsmExames.Text = "Exames";
            // 
            // tsiExamesAreas
            // 
            this.tsiExamesAreas.Name = "tsiExamesAreas";
            this.tsiExamesAreas.Size = new System.Drawing.Size(180, 22);
            this.tsiExamesAreas.Text = "Areas";
            this.tsiExamesAreas.Click += new System.EventHandler(this.tsiExamesAreas_Click);
            // 
            // tsiExamesTipos
            // 
            this.tsiExamesTipos.Name = "tsiExamesTipos";
            this.tsiExamesTipos.Size = new System.Drawing.Size(180, 22);
            this.tsiExamesTipos.Text = "Tipos";
            this.tsiExamesTipos.Click += new System.EventHandler(this.tsiExamesTipos_Click);
            // 
            // tsiExamesParametros
            // 
            this.tsiExamesParametros.Name = "tsiExamesParametros";
            this.tsiExamesParametros.Size = new System.Drawing.Size(180, 22);
            this.tsiExamesParametros.Text = "Parametros";
            this.tsiExamesParametros.Click += new System.EventHandler(this.tsiExamesParametros_Click);
            // 
            // agendamentosToolStripMenuItem
            // 
            this.agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            this.agendamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendamentosToolStripMenuItem.Text = "Agendamentos";
            this.agendamentosToolStripMenuItem.Click += new System.EventHandler(this.agendamentosToolStripMenuItem_Click);
            // 
            // pnlForms
            // 
            this.pnlForms.AutoSize = true;
            this.pnlForms.Location = new System.Drawing.Point(84, 91);
            this.pnlForms.Margin = new System.Windows.Forms.Padding(2);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(749, 283);
            this.pnlForms.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 599);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.mnsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnsMenu;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmArquivo;
        private System.Windows.Forms.ToolStripMenuItem tsmTrocarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.ToolStripMenuItem tsmConsulta;
        private System.Windows.Forms.ToolStripMenuItem tsiPacientes;
        private System.Windows.Forms.ToolStripMenuItem tsiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmExames;
        private System.Windows.Forms.ToolStripMenuItem tsiExamesAreas;
        private System.Windows.Forms.ToolStripMenuItem tsiExamesTipos;
        private System.Windows.Forms.ToolStripMenuItem tsiExamesParametros;
        private System.Windows.Forms.ToolStripMenuItem agendamentosToolStripMenuItem;
    }
}