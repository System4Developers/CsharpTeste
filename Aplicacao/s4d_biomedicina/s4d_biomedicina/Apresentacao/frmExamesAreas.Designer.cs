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
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbDS = new System.Windows.Forms.TextBox();
            this.lblGeral = new MaterialSkin.Controls.MaterialLabel();
            this.mDividir = new MaterialSkin.Controls.MaterialDivider();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbArea = new MaterialSkin.Controls.MaterialLabel();
            this.btnPesquisar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblID = new MaterialSkin.Controls.MaterialLabel();
            this.dgvExamesAreas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(51, 173);
            this.txbID.Margin = new System.Windows.Forms.Padding(2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(76, 20);
            this.txbID.TabIndex = 2;
            this.txbID.Text = "0";
            // 
            // txbDS
            // 
            this.txbDS.Location = new System.Drawing.Point(136, 173);
            this.txbDS.Margin = new System.Windows.Forms.Padding(2);
            this.txbDS.Name = "txbDS";
            this.txbDS.Size = new System.Drawing.Size(210, 20);
            this.txbDS.TabIndex = 2;
            // 
            // lblGeral
            // 
            this.lblGeral.AutoSize = true;
            this.lblGeral.Depth = 0;
            this.lblGeral.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGeral.Location = new System.Drawing.Point(26, 28);
            this.lblGeral.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGeral.Name = "lblGeral";
            this.lblGeral.Size = new System.Drawing.Size(363, 19);
            this.lblGeral.TabIndex = 45;
            this.lblGeral.Text = "GERENCIAMENTO DOS PARÂMETROS DOS EXAMES";
            // 
            // mDividir
            // 
            this.mDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mDividir.Depth = 0;
            this.mDividir.Location = new System.Drawing.Point(14, 62);
            this.mDividir.MouseState = MaterialSkin.MouseState.HOVER;
            this.mDividir.Name = "mDividir";
            this.mDividir.Size = new System.Drawing.Size(800, 2);
            this.mDividir.TabIndex = 44;
            this.mDividir.Text = "mDividir";
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(162, 93);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(102, 29);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Depth = 0;
            this.btnNovo.Location = new System.Drawing.Point(45, 93);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = true;
            this.btnNovo.Size = new System.Drawing.Size(102, 29);
            this.btnNovo.TabIndex = 42;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Depth = 0;
            this.lbArea.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbArea.Location = new System.Drawing.Point(132, 151);
            this.lbArea.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(168, 19);
            this.lbArea.TabIndex = 46;
            this.lbArea.Text = "ÁREA DE BIOMEDICINA";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Depth = 0;
            this.btnPesquisar.Location = new System.Drawing.Point(363, 168);
            this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Primary = true;
            this.btnPesquisar.Size = new System.Drawing.Size(102, 29);
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
            this.lblID.Location = new System.Drawing.Point(61, 151);
            this.lblID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 19);
            this.lblID.TabIndex = 48;
            this.lblID.Text = "ID";
            // 
            // dgvExamesAreas
            // 
            this.dgvExamesAreas.AllowUserToAddRows = false;
            this.dgvExamesAreas.AllowUserToDeleteRows = false;
            this.dgvExamesAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamesAreas.Location = new System.Drawing.Point(51, 217);
            this.dgvExamesAreas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvExamesAreas.Name = "dgvExamesAreas";
            this.dgvExamesAreas.ReadOnly = true;
            this.dgvExamesAreas.RowTemplate.Height = 24;
            this.dgvExamesAreas.Size = new System.Drawing.Size(740, 334);
            this.dgvExamesAreas.TabIndex = 0;
            // 
            // frmExamesAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 578);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lblGeral);
            this.Controls.Add(this.mDividir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txbDS);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.dgvExamesAreas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmExamesAreas";
            this.Text = "Exames Areas";
            this.Load += new System.EventHandler(this.frmExamesAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesAreas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbDS;
        private MaterialSkin.Controls.MaterialLabel lblGeral;
        private MaterialSkin.Controls.MaterialDivider mDividir;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNovo;
        private MaterialSkin.Controls.MaterialLabel lbArea;
        private MaterialSkin.Controls.MaterialRaisedButton btnPesquisar;
        private MaterialSkin.Controls.MaterialLabel lblID;
        private System.Windows.Forms.DataGridView dgvExamesAreas;
    }
}