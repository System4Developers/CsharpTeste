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
            this.tsmAcessoSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArquivo});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnsMenu.Size = new System.Drawing.Size(1185, 28);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // tsmArquivo
            // 
            this.tsmArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAcessoSistema,
            this.tsmTrocarUsuario,
            this.tsmSair});
            this.tsmArquivo.Name = "tsmArquivo";
            this.tsmArquivo.Size = new System.Drawing.Size(73, 24);
            this.tsmArquivo.Text = "Arquivo";
            // 
            // tsmAcessoSistema
            // 
            this.tsmAcessoSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiUsuarios});
            this.tsmAcessoSistema.Name = "tsmAcessoSistema";
            this.tsmAcessoSistema.Size = new System.Drawing.Size(216, 26);
            this.tsmAcessoSistema.Text = "Acesso ao Sistema";
            // 
            // tsiUsuarios
            // 
            this.tsiUsuarios.Name = "tsiUsuarios";
            this.tsiUsuarios.Size = new System.Drawing.Size(216, 26);
            this.tsiUsuarios.Text = "Usuarios";
            this.tsiUsuarios.Click += new System.EventHandler(this.tsiUsuarios_Click);
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
            // pnlForms
            // 
            this.pnlForms.AutoSize = true;
            this.pnlForms.Location = new System.Drawing.Point(112, 112);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(999, 348);
            this.pnlForms.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 472);
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
        private System.Windows.Forms.ToolStripMenuItem tsmAcessoSistema;
        private System.Windows.Forms.ToolStripMenuItem tsiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmTrocarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.Panel pnlForms;
    }
}