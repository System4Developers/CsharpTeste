namespace s4d_biomedicina.Apresentacao
{
    partial class frmLogin
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
            this.txbSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mDividir = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // txbSenha
            // 
            this.txbSenha.Depth = 0;
            this.txbSenha.Hint = "Senha";
            this.txbSenha.Location = new System.Drawing.Point(16, 192);
            this.txbSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.SelectedText = "";
            this.txbSenha.SelectionLength = 0;
            this.txbSenha.SelectionStart = 0;
            this.txbSenha.Size = new System.Drawing.Size(428, 28);
            this.txbSenha.TabIndex = 2;
            this.txbSenha.UseSystemPasswordChar = false;
            // 
            // txbLogin
            // 
            this.txbLogin.Depth = 0;
            this.txbLogin.Hint = "Usuário";
            this.txbLogin.Location = new System.Drawing.Point(16, 114);
            this.txbLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.PasswordChar = '\0';
            this.txbLogin.SelectedText = "";
            this.txbLogin.SelectionLength = 0;
            this.txbLogin.SelectionStart = 0;
            this.txbLogin.Size = new System.Drawing.Size(428, 28);
            this.txbLogin.TabIndex = 1;
            this.txbLogin.UseSystemPasswordChar = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.Location = new System.Drawing.Point(308, 262);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Primary = true;
            this.btnConfirmar.Size = new System.Drawing.Size(136, 36);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Entrar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // mDividir
            // 
            this.mDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mDividir.Depth = 0;
            this.mDividir.Location = new System.Drawing.Point(16, 321);
            this.mDividir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mDividir.MouseState = MaterialSkin.MouseState.HOVER;
            this.mDividir.Name = "mDividir";
            this.mDividir.Size = new System.Drawing.Size(428, 2);
            this.mDividir.TabIndex = 9;
            this.mDividir.TabStop = false;
            this.mDividir.Text = "materialDivider1";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 357);
            this.Controls.Add(this.mDividir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.txbSenha);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACESSO AO SISTEMA";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txbSenha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbLogin;
        private MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
        private MaterialSkin.Controls.MaterialDivider mDividir;
    }
}