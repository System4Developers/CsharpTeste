namespace s4d_biomedicina.Apresentacao
{
    partial class frmPacientesEnderecos
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvPacientesEnderecos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(608, 368);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 28);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar Endereço";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(454, 368);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(150, 28);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "Novo Endereço";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvPacientesEnderecos
            // 
            this.dgvPacientesEnderecos.AllowUserToAddRows = false;
            this.dgvPacientesEnderecos.AllowUserToDeleteRows = false;
            this.dgvPacientesEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesEnderecos.Location = new System.Drawing.Point(53, 62);
            this.dgvPacientesEnderecos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPacientesEnderecos.Name = "dgvPacientesEnderecos";
            this.dgvPacientesEnderecos.ReadOnly = true;
            this.dgvPacientesEnderecos.RowTemplate.Height = 24;
            this.dgvPacientesEnderecos.Size = new System.Drawing.Size(691, 270);
            this.dgvPacientesEnderecos.TabIndex = 12;
            // 
            // frmPacientesEnderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvPacientesEnderecos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPacientesEnderecos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPacientesEnderecos";
            this.Load += new System.EventHandler(this.frmPacientesEnderecos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesEnderecos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvPacientesEnderecos;
    }
}