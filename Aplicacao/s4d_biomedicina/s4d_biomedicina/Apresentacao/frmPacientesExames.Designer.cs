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
            this.dgvPacientesExames = new System.Windows.Forms.DataGridView();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblGeral = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExames = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesExames)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacientesExames
            // 
            this.dgvPacientesExames.AllowUserToAddRows = false;
            this.dgvPacientesExames.AllowUserToDeleteRows = false;
            this.dgvPacientesExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesExames.Location = new System.Drawing.Point(25, 86);
            this.dgvPacientesExames.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPacientesExames.Name = "dgvPacientesExames";
            this.dgvPacientesExames.ReadOnly = true;
            this.dgvPacientesExames.RowTemplate.Height = 24;
            this.dgvPacientesExames.Size = new System.Drawing.Size(1057, 327);
            this.dgvPacientesExames.TabIndex = 16;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(32, 67);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1050, 2);
            this.materialDivider1.TabIndex = 56;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblGeral
            // 
            this.lblGeral.AutoSize = true;
            this.lblGeral.Depth = 0;
            this.lblGeral.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGeral.Location = new System.Drawing.Point(40, 33);
            this.lblGeral.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGeral.Name = "lblGeral";
            this.lblGeral.Size = new System.Drawing.Size(68, 19);
            this.lblGeral.TabIndex = 55;
            this.lblGeral.Text = "EXAMES";
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(792, 434);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(170, 29);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "RESULTADOS DO EXAME";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(983, 434);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(99, 29);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExames
            // 
            this.btnExames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExames.Depth = 0;
            this.btnExames.Location = new System.Drawing.Point(597, 434);
            this.btnExames.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExames.Name = "btnExames";
            this.btnExames.Primary = true;
            this.btnExames.Size = new System.Drawing.Size(170, 29);
            this.btnExames.TabIndex = 57;
            this.btnExames.Text = "ATRIBUIR EXAMES";
            this.btnExames.UseVisualStyleBackColor = true;
            this.btnExames.Click += new System.EventHandler(this.btnExames_Click);
            // 
            // frmPacientesExames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 489);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExames);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lblGeral);
            this.Controls.Add(this.dgvPacientesExames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPacientesExames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPacientesExames";
            this.Load += new System.EventHandler(this.frmPacientesExames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesExames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPacientesExames;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblGeral;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnExames;
    }
}