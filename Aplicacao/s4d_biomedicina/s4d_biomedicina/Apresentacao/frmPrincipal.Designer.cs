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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlForms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExames = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExamesAreas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExamesTipos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExamesParametros = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLogin = new System.Windows.Forms.ToolStripTextBox();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mnsMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForms
            // 
            this.pnlForms.AutoSize = true;
            this.pnlForms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlForms.Location = new System.Drawing.Point(0, 29);
            this.pnlForms.Margin = new System.Windows.Forms.Padding(2);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(1146, 535);
            this.pnlForms.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(988, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(73, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiUsuarios,
            this.tsmExames,
            this.agendamentosToolStripMenuItem});
            this.tsmAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(98, 23);
            this.tsmAdmin.Text = "Administrador";
            // 
            // tsiUsuarios
            // 
            this.tsiUsuarios.Name = "tsiUsuarios";
            this.tsiUsuarios.Size = new System.Drawing.Size(158, 22);
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
            this.tsmExames.Size = new System.Drawing.Size(158, 22);
            this.tsmExames.Text = "Exames";
            // 
            // tsiExamesAreas
            // 
            this.tsiExamesAreas.Name = "tsiExamesAreas";
            this.tsiExamesAreas.Size = new System.Drawing.Size(138, 22);
            this.tsiExamesAreas.Text = "Áreas";
            this.tsiExamesAreas.Click += new System.EventHandler(this.tsiExamesAreas_Click);
            // 
            // tsiExamesTipos
            // 
            this.tsiExamesTipos.Name = "tsiExamesTipos";
            this.tsiExamesTipos.Size = new System.Drawing.Size(138, 22);
            this.tsiExamesTipos.Text = "Tipos";
            this.tsiExamesTipos.Click += new System.EventHandler(this.tsiExamesTipos_Click);
            // 
            // tsiExamesParametros
            // 
            this.tsiExamesParametros.Name = "tsiExamesParametros";
            this.tsiExamesParametros.Size = new System.Drawing.Size(138, 22);
            this.tsiExamesParametros.Text = "Parametros";
            this.tsiExamesParametros.Click += new System.EventHandler(this.tsiExamesParametros_Click);
            // 
            // agendamentosToolStripMenuItem
            // 
            this.agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            this.agendamentosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.agendamentosToolStripMenuItem.Text = "Agendamentos";
            // 
            // tsmPesquisa
            // 
            this.tsmPesquisa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiPacientes});
            this.tsmPesquisa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmPesquisa.Name = "tsmPesquisa";
            this.tsmPesquisa.Size = new System.Drawing.Size(67, 23);
            this.tsmPesquisa.Text = "Localizar";
            // 
            // tsiPacientes
            // 
            this.tsiPacientes.Name = "tsiPacientes";
            this.tsiPacientes.Size = new System.Drawing.Size(127, 22);
            this.tsiPacientes.Text = "Pacientes";
            this.tsiPacientes.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // tsmLogin
            // 
            this.tsmLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTrocarUsuario,
            this.alterarSenhaToolStripMenuItem,
            this.tsmSair});
            this.tsmLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmLogin.Name = "tsmLogin";
            this.tsmLogin.Size = new System.Drawing.Size(49, 23);
            this.tsmLogin.Text = "Login";
            // 
            // tsmTrocarUsuario
            // 
            this.tsmTrocarUsuario.Name = "tsmTrocarUsuario";
            this.tsmTrocarUsuario.Size = new System.Drawing.Size(154, 22);
            this.tsmTrocarUsuario.Text = "Trocar Usuario";
            this.tsmTrocarUsuario.Click += new System.EventHandler(this.tsmTrocarUsuario_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar senha";
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(154, 22);
            this.tsmSair.Text = "Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // tsbLogin
            // 
            this.tsbLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbLogin.Name = "tsbLogin";
            this.tsbLogin.ReadOnly = true;
            this.tsbLogin.Size = new System.Drawing.Size(300, 23);
            // 
            // mnsMenu
            // 
            this.mnsMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdmin,
            this.tsmPesquisa,
            this.tsmLogin,
            this.tsbLogin});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnsMenu.Size = new System.Drawing.Size(1146, 27);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 569);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 100);
            this.panel1.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 669);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem tsmAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmExames;
        private System.Windows.Forms.ToolStripMenuItem tsiExamesAreas;
        private System.Windows.Forms.ToolStripMenuItem tsiExamesTipos;
        private System.Windows.Forms.ToolStripMenuItem tsiExamesParametros;
        private System.Windows.Forms.ToolStripMenuItem agendamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPesquisa;
        private System.Windows.Forms.ToolStripMenuItem tsiPacientes;
        private System.Windows.Forms.ToolStripMenuItem tsmLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmTrocarUsuario;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.ToolStripTextBox tsbLogin;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.Panel panel1;
    }
}