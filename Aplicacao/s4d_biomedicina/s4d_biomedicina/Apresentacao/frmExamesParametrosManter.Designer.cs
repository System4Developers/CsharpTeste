namespace s4d_biomedicina.Apresentacao
{
    partial class frmExamesParametrosManter
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txbParametro = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLimiteMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLimiteMin = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(153, 112);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(173, 21);
            this.cmbTipo.TabIndex = 60;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(43, 164);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(75, 13);
            this.lblTipo.TabIndex = 58;
            this.lblTipo.Text = "PARAMETRO";
            // 
            // txbParametro
            // 
            this.txbParametro.Location = new System.Drawing.Point(153, 161);
            this.txbParametro.Name = "txbParametro";
            this.txbParametro.Size = new System.Drawing.Size(173, 20);
            this.txbParametro.TabIndex = 56;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(43, 68);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 55;
            this.lblID.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(153, 63);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(173, 20);
            this.txbID.TabIndex = 54;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(43, 112);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 53;
            this.lblArea.Text = "TIPO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "LIMITE MAXIMO";
            // 
            // txbLimiteMax
            // 
            this.txbLimiteMax.Location = new System.Drawing.Point(153, 255);
            this.txbLimiteMax.Name = "txbLimiteMax";
            this.txbLimiteMax.Size = new System.Drawing.Size(173, 20);
            this.txbLimiteMax.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "LIMITE MINIMO";
            // 
            // txbLimiteMin
            // 
            this.txbLimiteMin.Location = new System.Drawing.Point(153, 206);
            this.txbLimiteMin.Name = "txbLimiteMin";
            this.txbLimiteMin.Size = new System.Drawing.Size(173, 20);
            this.txbLimiteMin.TabIndex = 63;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(260, 305);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(66, 22);
            this.btnSalvar.TabIndex = 65;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmExamesParametrosManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 375);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbLimiteMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLimiteMax);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txbParametro);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblArea);
            this.Name = "frmExamesParametrosManter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExamesParametrosManter";
            this.Load += new System.EventHandler(this.frmExamesParametrosManter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txbParametro;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLimiteMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLimiteMin;
        private System.Windows.Forms.Button btnSalvar;
    }
}