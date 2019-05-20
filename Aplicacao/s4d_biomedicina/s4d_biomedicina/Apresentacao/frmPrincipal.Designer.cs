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
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArquivo});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(703, 24);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // tsmArquivo
            // 
            this.tsmArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAcessoSistema});
            this.tsmArquivo.Name = "tsmArquivo";
            this.tsmArquivo.Size = new System.Drawing.Size(61, 20);
            this.tsmArquivo.Text = "Arquivo";
            // 
            // tsmAcessoSistema
            // 
            this.tsmAcessoSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiUsuarios});
            this.tsmAcessoSistema.Name = "tsmAcessoSistema";
            this.tsmAcessoSistema.Size = new System.Drawing.Size(180, 22);
            this.tsmAcessoSistema.Text = "Acesso ao Sistema";
            // 
            // tsiUsuarios
            // 
            this.tsiUsuarios.Name = "tsiUsuarios";
            this.tsiUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsiUsuarios.Text = "Usuarios";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 365);
            this.Controls.Add(this.mnsMenu);
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "frmPrincipal";
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
        private System.Windows.Forms.ToolStripMenuItem tsmAcessoSistema;
        private System.Windows.Forms.ToolStripMenuItem tsiUsuarios;
    }
}