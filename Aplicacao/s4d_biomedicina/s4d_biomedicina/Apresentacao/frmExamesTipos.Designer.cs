namespace s4d_biomedicina.Apresentacao
{
    partial class frmExamesTipos
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
            this.txbDS = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.dgvExamesTipos = new System.Windows.Forms.DataGridView();
            this.lblGeral = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mDividir = new MaterialSkin.Controls.MaterialDivider();
            this.btnPesquisar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblID = new MaterialSkin.Controls.MaterialLabel();
            this.lblExame = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // txbDS
            // 
            this.txbDS.Location = new System.Drawing.Point(127, 161);
            this.txbDS.Margin = new System.Windows.Forms.Padding(2);
            this.txbDS.Name = "txbDS";
            this.txbDS.Size = new System.Drawing.Size(210, 20);
            this.txbDS.TabIndex = 8;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(42, 161);
            this.txbID.Margin = new System.Windows.Forms.Padding(2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(76, 20);
            this.txbID.TabIndex = 9;
            this.txbID.Text = "0";
            // 
            // dgvExamesTipos
            // 
            this.dgvExamesTipos.AllowUserToAddRows = false;
            this.dgvExamesTipos.AllowUserToDeleteRows = false;
            this.dgvExamesTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamesTipos.Location = new System.Drawing.Point(32, 200);
            this.dgvExamesTipos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvExamesTipos.Name = "dgvExamesTipos";
            this.dgvExamesTipos.ReadOnly = true;
            this.dgvExamesTipos.RowTemplate.Height = 24;
            this.dgvExamesTipos.Size = new System.Drawing.Size(748, 327);
            this.dgvExamesTipos.TabIndex = 4;
            // 
            // lblGeral
            // 
            this.lblGeral.AutoSize = true;
            this.lblGeral.Depth = 0;
            this.lblGeral.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGeral.Location = new System.Drawing.Point(32, 30);
            this.lblGeral.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGeral.Name = "lblGeral";
            this.lblGeral.Size = new System.Drawing.Size(287, 19);
            this.lblGeral.TabIndex = 31;
            this.lblGeral.Text = "GERENCIAMENTO DE TIPOS DE EXAMES";
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(153, 84);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(102, 29);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Depth = 0;
            this.btnNovo.Location = new System.Drawing.Point(36, 84);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = true;
            this.btnNovo.Size = new System.Drawing.Size(102, 29);
            this.btnNovo.TabIndex = 29;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // mDividir
            // 
            this.mDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mDividir.Depth = 0;
            this.mDividir.Location = new System.Drawing.Point(20, 64);
            this.mDividir.MouseState = MaterialSkin.MouseState.HOVER;
            this.mDividir.Name = "mDividir";
            this.mDividir.Size = new System.Drawing.Size(800, 2);
            this.mDividir.TabIndex = 28;
            this.mDividir.Text = "mDividir";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Depth = 0;
            this.btnPesquisar.Location = new System.Drawing.Point(359, 156);
            this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Primary = true;
            this.btnPesquisar.Size = new System.Drawing.Size(102, 29);
            this.btnPesquisar.TabIndex = 32;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Depth = 0;
            this.lblID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblID.Location = new System.Drawing.Point(38, 139);
            this.lblID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 19);
            this.lblID.TabIndex = 33;
            this.lblID.Text = "ID";
            // 
            // lblExame
            // 
            this.lblExame.AutoSize = true;
            this.lblExame.Depth = 0;
            this.lblExame.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblExame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExame.Location = new System.Drawing.Point(132, 140);
            this.lblExame.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblExame.Name = "lblExame";
            this.lblExame.Size = new System.Drawing.Size(118, 19);
            this.lblExame.TabIndex = 34;
            this.lblExame.Text = "TIPO DE EXAME";
            // 
            // frmExamesTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 606);
            this.Controls.Add(this.lblExame);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblGeral);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.mDividir);
            this.Controls.Add(this.txbDS);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.dgvExamesTipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExamesTipos";
            this.Text = "frmExamesTipos";
            this.Load += new System.EventHandler(this.frmExamesTipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesTipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbDS;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.DataGridView dgvExamesTipos;
        private MaterialSkin.Controls.MaterialLabel lblGeral;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNovo;
        private MaterialSkin.Controls.MaterialDivider mDividir;
        private MaterialSkin.Controls.MaterialRaisedButton btnPesquisar;
        private MaterialSkin.Controls.MaterialLabel lblID;
        private MaterialSkin.Controls.MaterialLabel lblExame;
    }
}