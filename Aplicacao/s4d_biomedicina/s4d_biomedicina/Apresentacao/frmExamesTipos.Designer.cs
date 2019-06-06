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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txbDS = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvExamesTipos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(139, 44);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(78, 13);
            this.lblDescricao.TabIndex = 10;
            this.lblDescricao.Text = "Tipo do Exame";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(54, 44);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID";
            // 
            // txbDS
            // 
            this.txbDS.Location = new System.Drawing.Point(141, 60);
            this.txbDS.Margin = new System.Windows.Forms.Padding(2);
            this.txbDS.Name = "txbDS";
            this.txbDS.Size = new System.Drawing.Size(210, 20);
            this.txbDS.TabIndex = 8;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(56, 60);
            this.txbID.Margin = new System.Windows.Forms.Padding(2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(76, 20);
            this.txbID.TabIndex = 9;
            this.txbID.Text = "0";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(368, 55);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(73, 28);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(141, 91);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 28);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(56, 91);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(73, 28);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvExamesTipos
            // 
            this.dgvExamesTipos.AllowUserToAddRows = false;
            this.dgvExamesTipos.AllowUserToDeleteRows = false;
            this.dgvExamesTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamesTipos.Location = new System.Drawing.Point(56, 136);
            this.dgvExamesTipos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvExamesTipos.Name = "dgvExamesTipos";
            this.dgvExamesTipos.ReadOnly = true;
            this.dgvExamesTipos.RowTemplate.Height = 24;
            this.dgvExamesTipos.Size = new System.Drawing.Size(691, 270);
            this.dgvExamesTipos.TabIndex = 4;
            // 
            // frmExamesTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbDS);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
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

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbDS;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvExamesTipos;
    }
}