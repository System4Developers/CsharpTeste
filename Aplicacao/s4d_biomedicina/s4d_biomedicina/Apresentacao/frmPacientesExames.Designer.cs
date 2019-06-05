namespace s4d_biomedicina.Apresentacao
{
    partial class frmPacientesExames
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
            this.dgvPacientesExames = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesExames)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(580, 316);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 28);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar Exames";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(426, 316);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(150, 28);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "Novo Exame";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dgvPacientesExames
            // 
            this.dgvPacientesExames.AllowUserToAddRows = false;
            this.dgvPacientesExames.AllowUserToDeleteRows = false;
            this.dgvPacientesExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesExames.Location = new System.Drawing.Point(25, 21);
            this.dgvPacientesExames.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPacientesExames.Name = "dgvPacientesExames";
            this.dgvPacientesExames.ReadOnly = true;
            this.dgvPacientesExames.RowTemplate.Height = 24;
            this.dgvPacientesExames.Size = new System.Drawing.Size(691, 270);
            this.dgvPacientesExames.TabIndex = 16;
            // 
            // frmPacientesExames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(759, 397);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvPacientesExames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPacientesExames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPacientesExames";
            this.Load += new System.EventHandler(this.frmPacientesExames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesExames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvPacientesExames;
    }
}