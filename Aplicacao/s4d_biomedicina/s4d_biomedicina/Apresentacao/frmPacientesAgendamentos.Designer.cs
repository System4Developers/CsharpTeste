namespace s4d_biomedicina.Apresentacao
{
    partial class frmPacientesAgendamentos
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
            this.dgvPacientesAgendamentos = new System.Windows.Forms.DataGridView();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblGeral = new MaterialSkin.Controls.MaterialLabel();
            this.btnNovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConsultarExames = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesAgendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacientesAgendamentos
            // 
            this.dgvPacientesAgendamentos.AllowUserToAddRows = false;
            this.dgvPacientesAgendamentos.AllowUserToDeleteRows = false;
            this.dgvPacientesAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesAgendamentos.Location = new System.Drawing.Point(53, 108);
            this.dgvPacientesAgendamentos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPacientesAgendamentos.Name = "dgvPacientesAgendamentos";
            this.dgvPacientesAgendamentos.ReadOnly = true;
            this.dgvPacientesAgendamentos.RowTemplate.Height = 24;
            this.dgvPacientesAgendamentos.Size = new System.Drawing.Size(691, 270);
            this.dgvPacientesAgendamentos.TabIndex = 16;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(41, 74);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(724, 2);
            this.materialDivider1.TabIndex = 54;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblGeral
            // 
            this.lblGeral.AutoSize = true;
            this.lblGeral.Depth = 0;
            this.lblGeral.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGeral.Location = new System.Drawing.Point(49, 40);
            this.lblGeral.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGeral.Name = "lblGeral";
            this.lblGeral.Size = new System.Drawing.Size(130, 19);
            this.lblGeral.TabIndex = 53;
            this.lblGeral.Text = "AGENDAMENTOS";
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Depth = 0;
            this.btnNovo.Location = new System.Drawing.Point(53, 398);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = true;
            this.btnNovo.Size = new System.Drawing.Size(170, 29);
            this.btnNovo.TabIndex = 55;
            this.btnNovo.Text = "NOVO AGENDAMENTO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(242, 398);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(167, 29);
            this.materialRaisedButton1.TabIndex = 57;
            this.materialRaisedButton1.Text = "EDITAR AGENDAMENTO";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConsultarExames
            // 
            this.btnConsultarExames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarExames.Depth = 0;
            this.btnConsultarExames.Location = new System.Drawing.Point(427, 398);
            this.btnConsultarExames.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultarExames.Name = "btnConsultarExames";
            this.btnConsultarExames.Primary = true;
            this.btnConsultarExames.Size = new System.Drawing.Size(144, 29);
            this.btnConsultarExames.TabIndex = 56;
            this.btnConsultarExames.Text = "CONSULTAR EXAMES";
            this.btnConsultarExames.UseVisualStyleBackColor = true;
            this.btnConsultarExames.Click += new System.EventHandler(this.btnConsultarExames_Click);
            // 
            // frmPacientesAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 471);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnConsultarExames);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lblGeral);
            this.Controls.Add(this.dgvPacientesAgendamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPacientesAgendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPacientesAgendamentos";
            this.Load += new System.EventHandler(this.frmPacientesAgendamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesAgendamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPacientesAgendamentos;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblGeral;
        private MaterialSkin.Controls.MaterialRaisedButton btnNovo;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultarExames;
    }
}