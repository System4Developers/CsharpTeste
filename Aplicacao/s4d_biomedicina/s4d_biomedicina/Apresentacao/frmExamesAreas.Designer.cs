namespace s4d_biomedicina.Apresentacao
{
    partial class frmExamesAreas
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
            this.lblGeral = new MaterialSkin.Controls.MaterialLabel();
            this.mDividir = new MaterialSkin.Controls.MaterialDivider();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvExamesAreas = new System.Windows.Forms.DataGridView();
            this.txbDS = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblID = new MaterialSkin.Controls.MaterialLabel();
            this.lblArea = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGeral
            // 
            this.lblGeral.AutoSize = true;
            this.lblGeral.Depth = 0;
            this.lblGeral.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGeral.Location = new System.Drawing.Point(35, 34);
            this.lblGeral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeral.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGeral.Name = "lblGeral";
            this.lblGeral.Size = new System.Drawing.Size(455, 24);
            this.lblGeral.TabIndex = 45;
            this.lblGeral.Text = "GERENCIAMENTO DOS PARÂMETROS DOS EXAMES";
            // 
            // mDividir
            // 
            this.mDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mDividir.Depth = 0;
            this.mDividir.Location = new System.Drawing.Point(40, 75);
            this.mDividir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mDividir.MouseState = MaterialSkin.MouseState.HOVER;
            this.mDividir.Name = "mDividir";
            this.mDividir.Size = new System.Drawing.Size(1067, 2);
            this.mDividir.TabIndex = 44;
            this.mDividir.Text = "mDividir";
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(200, 102);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(136, 36);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Depth = 0;
            this.btnNovo.Location = new System.Drawing.Point(40, 102);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = true;
            this.btnNovo.Size = new System.Drawing.Size(136, 36);
            this.btnNovo.TabIndex = 42;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvExamesAreas
            // 
            this.dgvExamesAreas.AllowUserToAddRows = false;
            this.dgvExamesAreas.AllowUserToDeleteRows = false;
            this.dgvExamesAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamesAreas.Location = new System.Drawing.Point(40, 293);
            this.dgvExamesAreas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExamesAreas.Name = "dgvExamesAreas";
            this.dgvExamesAreas.ReadOnly = true;
            this.dgvExamesAreas.RowTemplate.Height = 24;
            this.dgvExamesAreas.Size = new System.Drawing.Size(987, 411);
            this.dgvExamesAreas.TabIndex = 0;
            // 
            // txbDS
            // 
            this.txbDS.Location = new System.Drawing.Point(200, 194);
            this.txbDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDS.Name = "txbDS";
            this.txbDS.Size = new System.Drawing.Size(321, 22);
            this.txbDS.TabIndex = 3;
            this.txbDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(40, 194);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(135, 22);
            this.txbID.TabIndex = 2;
            this.txbID.Text = "0";
            this.txbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Depth = 0;
            this.btnPesquisar.Location = new System.Drawing.Point(40, 238);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Primary = true;
            this.btnPesquisar.Size = new System.Drawing.Size(136, 36);
            this.btnPesquisar.TabIndex = 47;
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
            this.lblID.Location = new System.Drawing.Point(35, 169);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 24);
            this.lblID.TabIndex = 48;
            this.lblID.Text = "ID";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Depth = 0;
            this.lblArea.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblArea.Location = new System.Drawing.Point(196, 169);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(209, 24);
            this.lblArea.TabIndex = 48;
            this.lblArea.Text = "AREA DA BIOMEDICINA";
            // 
            // frmExamesAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 782);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txbDS);
            this.Controls.Add(this.lblGeral);
            this.Controls.Add(this.mDividir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvExamesAreas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmExamesAreas";
            this.Text = "Exames Areas";
            this.Load += new System.EventHandler(this.frmExamesAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesAreas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblGeral;
        private MaterialSkin.Controls.MaterialDivider mDividir;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNovo;
        private System.Windows.Forms.DataGridView dgvExamesAreas;
        private System.Windows.Forms.TextBox txbDS;
        private System.Windows.Forms.TextBox txbID;
        private MaterialSkin.Controls.MaterialRaisedButton btnPesquisar;
        private MaterialSkin.Controls.MaterialLabel lblID;
        private MaterialSkin.Controls.MaterialLabel lblArea;
    }
}