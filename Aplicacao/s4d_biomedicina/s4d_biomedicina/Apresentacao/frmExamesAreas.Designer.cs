﻿namespace s4d_biomedicina.Apresentacao
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
            this.dgvExamesAreas = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExamesAreas
            // 
            this.dgvExamesAreas.AllowUserToAddRows = false;
            this.dgvExamesAreas.AllowUserToDeleteRows = false;
            this.dgvExamesAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamesAreas.Location = new System.Drawing.Point(36, 146);
            this.dgvExamesAreas.Name = "dgvExamesAreas";
            this.dgvExamesAreas.ReadOnly = true;
            this.dgvExamesAreas.RowTemplate.Height = 24;
            this.dgvExamesAreas.Size = new System.Drawing.Size(921, 332);
            this.dgvExamesAreas.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(36, 91);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(97, 34);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(452, 47);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 34);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(149, 91);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 34);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 22);
            this.textBox2.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(33, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(146, 33);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(71, 17);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descricao";
            // 
            // frmExamesAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 536);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvExamesAreas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExamesAreas";
            this.Text = "Exames Areas";
            this.Load += new System.EventHandler(this.frmExamesAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesAreas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExamesAreas;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescricao;
    }
}