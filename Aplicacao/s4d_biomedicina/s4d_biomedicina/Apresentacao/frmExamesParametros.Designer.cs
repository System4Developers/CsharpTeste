namespace s4d_biomedicina.Apresentacao
{
    partial class frmExamesParametros
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
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.dgvExamesParametros = new System.Windows.Forms.DataGridView();
            this.lbTipo = new MaterialSkin.Controls.MaterialLabel();
            this.lblID = new MaterialSkin.Controls.MaterialLabel();
            this.btnPesquisar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblGeral = new MaterialSkin.Controls.MaterialLabel();
            this.mDividir = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesParametros)).BeginInit();
            this.SuspendLayout();
            // 
            // txbTipo
            // 
            this.txbTipo.Location = new System.Drawing.Point(150, 164);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(218, 20);
            this.txbTipo.TabIndex = 5;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(48, 164);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(75, 20);
            this.txbID.TabIndex = 6;
            this.txbID.Text = "0";
            // 
            // dgvExamesParametros
            // 
            this.dgvExamesParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamesParametros.Location = new System.Drawing.Point(47, 206);
            this.dgvExamesParametros.Name = "dgvExamesParametros";
            this.dgvExamesParametros.Size = new System.Drawing.Size(769, 335);
            this.dgvExamesParametros.TabIndex = 4;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Depth = 0;
            this.lbTipo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTipo.Location = new System.Drawing.Point(146, 142);
            this.lbTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(156, 19);
            this.lbTipo.TabIndex = 36;
            this.lbTipo.Text = "TIPO DE PARÂMETRO";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Depth = 0;
            this.lblID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblID.Location = new System.Drawing.Point(52, 141);
            this.lblID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 19);
            this.lblID.TabIndex = 35;
            this.lblID.Text = "ID";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Depth = 0;
            this.btnPesquisar.Location = new System.Drawing.Point(405, 159);
            this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Primary = true;
            this.btnPesquisar.Size = new System.Drawing.Size(102, 29);
            this.btnPesquisar.TabIndex = 39;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(164, 92);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(102, 29);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Depth = 0;
            this.btnNovo.Location = new System.Drawing.Point(47, 92);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = true;
            this.btnNovo.Size = new System.Drawing.Size(102, 29);
            this.btnNovo.TabIndex = 37;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblGeral
            // 
            this.lblGeral.AutoSize = true;
            this.lblGeral.Depth = 0;
            this.lblGeral.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGeral.Location = new System.Drawing.Point(28, 27);
            this.lblGeral.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGeral.Name = "lblGeral";
            this.lblGeral.Size = new System.Drawing.Size(363, 19);
            this.lblGeral.TabIndex = 41;
            this.lblGeral.Text = "GERENCIAMENTO DOS PARÂMETROS DOS EXAMES";
            // 
            // mDividir
            // 
            this.mDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mDividir.Depth = 0;
            this.mDividir.Location = new System.Drawing.Point(16, 61);
            this.mDividir.MouseState = MaterialSkin.MouseState.HOVER;
            this.mDividir.Name = "mDividir";
            this.mDividir.Size = new System.Drawing.Size(800, 2);
            this.mDividir.TabIndex = 40;
            this.mDividir.Text = "mDividir";
            // 
            // frmExamesParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 570);
            this.Controls.Add(this.lblGeral);
            this.Controls.Add(this.mDividir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbTipo);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.dgvExamesParametros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExamesParametros";
            this.Text = "frmExamesParametros";
            this.Load += new System.EventHandler(this.frmExamesParametros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesParametros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbTipo;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.DataGridView dgvExamesParametros;
        private MaterialSkin.Controls.MaterialLabel lbTipo;
        private MaterialSkin.Controls.MaterialLabel lblID;
        private MaterialSkin.Controls.MaterialRaisedButton btnPesquisar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNovo;
        private MaterialSkin.Controls.MaterialLabel lblGeral;
        private MaterialSkin.Controls.MaterialDivider mDividir;
    }
}