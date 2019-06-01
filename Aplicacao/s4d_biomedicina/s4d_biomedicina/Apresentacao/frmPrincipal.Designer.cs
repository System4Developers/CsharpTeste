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
            this.pnlForms = new System.Windows.Forms.Panel();
            this.tsmExames = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExamesAreas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExamesTipos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExamesParametros = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnsMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnsMenu.Size = new System.Drawing.Size(1735, 28);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // tsmArquivo
            // 
            this.tsmArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTrocarUsuario,
            this.tsmSair});
            this.tsmArquivo.Name = "tsmArquivo";
            this.tsmArquivo.Size = new System.Drawing.Size(73, 24);
            this.tsmArquivo.Text = "Arquivo";
            // 
            // tsmTrocarUsuario
            // 
            this.tsmTrocarUsuario.Name = "tsmTrocarUsuario";
            this.tsmTrocarUsuario.Size = new System.Drawing.Size(216, 26);
            this.tsmTrocarUsuario.Text = "Trocar Usuario";
            this.tsmTrocarUsuario.Click += new System.EventHandler(this.tsmTrocarUsuario_Click);
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(216, 26);
            this.tsmSair.Text = "Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // tsmConsulta
            // 
            this.tsmConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiPacientes,
            this.tsiUsuarios,
            this.tsmExames});
            this.tsmConsulta.Name = "tsmConsulta";
            this.tsmConsulta.Size = new System.Drawing.Size(78, 24);
            this.tsmConsulta.Text = "Consulta";
            // 
            // tsiPacientes
            // 
            this.tsiPacientes.Name = "tsiPacientes";
            this.tsiPacientes.Size = new System.Drawing.Size(216, 26);
            this.tsiPacientes.Text = "Pacientes";
            this.tsiPacientes.Click += new System.EventHandler(this.tsiPacientes_Click);
            // 
            // tsiUsuarios
            // 
            this.tsiUsuarios.Name = "tsiUsuarios";
            this.tsiUsuarios.Size = new System.Drawing.Size(216, 26);
            this.tsiUsuarios.Text = "Usuarios";
            this.tsiUsuarios.Click += new System.EventHandler(this.tsiUsuarios_Click);
            // 
            // pnlForms
            // 
            this.pnlForms.AutoSize = true;
            this.pnlForms.Location = new System.Drawing.Point(112, 112);
            this.pnlForms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(999, 348);
            this.pnlForms.TabIndex = 1;
            // 
            // tsmExames
            // 
            this.tsmExames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiExamesAreas,
            this.tsiExamesTipos,
            this.tsiExamesParametros});
            this.tsmExames.Name = "tsmExames";
            this.tsmExames.Size = new System.Drawing.Size(216, 26);
            this.tsmExames.Text = "Exames";
            // 
            // tsiExamesAreas
            // 
            this.tsiExamesAreas.Name = "tsiExamesAreas";
            this.tsiExamesAreas.Size = new System.Drawing.Size(216, 26);
            this.tsiExamesAreas.Text = "Areas";
            this.tsiExamesAreas.Click += new System.EventHandler(this.tsiExamesAreas_Click);
            // 
            // tsiExamesTipos
            // 
            this.tsiExamesTipos.Name = "tsiExamesTipos";
            this.tsiExamesTipos.Size = new System.Drawing.Size(216, 26);
            this.tsiExamesTipos.Text = "Tipos";
            // 
            // tsiExamesParametros
            // 
            this.tsiExamesParametros.Name = "tsiExamesParametros";
            this.tsiExamesParametros.Size = new System.Drawing.Size(216, 26);
            this.tsiExamesParametros.Text = "Parametros";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 737);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.mnsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnsMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}