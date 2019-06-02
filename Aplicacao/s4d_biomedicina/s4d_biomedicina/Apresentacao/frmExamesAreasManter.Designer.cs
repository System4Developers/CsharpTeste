namespace s4d_biomedicina.Apresentacao
{
    partial class frmExamesAreasManter
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
            this.lblID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txbArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(49, 44);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 40;
            this.lblID.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(196, 38);
            this.txbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(229, 22);
            this.txbID.TabIndex = 39;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(327, 156);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 38;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(49, 106);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(45, 17);
            this.lblLogin.TabIndex = 37;
            this.lblLogin.Text = "AREA";
            // 
            // txbArea
            // 
            this.txbArea.Location = new System.Drawing.Point(196, 100);
            this.txbArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbArea.Name = "txbArea";
            this.txbArea.Size = new System.Drawing.Size(229, 22);
            this.txbArea.TabIndex = 36;
            // 
            // frmExamesAreasManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 225);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txbArea);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExamesAreasManter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAreasManter";
            this.Load += new System.EventHandler(this.frmAreas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txbArea;
    }
}