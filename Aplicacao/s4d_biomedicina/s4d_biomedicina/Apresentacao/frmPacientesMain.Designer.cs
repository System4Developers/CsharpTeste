namespace s4d_biomedicina.Apresentacao
{
    partial class frmPacientesMain
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
            this.pnlForms = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblExames = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblSair1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.White;
            this.pnlForms.Location = new System.Drawing.Point(-1, 73);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(1324, 631);
            this.pnlForms.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 65);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.materialFlatButton1);
            this.panel2.Location = new System.Drawing.Point(63, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 39);
            this.panel2.TabIndex = 1;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(1, 2);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(143, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "DADOS CADASTRAIS";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.lblDados_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-574, 38);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1500, 5);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "mDividir";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(44, 1);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(89, 36);
            this.materialFlatButton2.TabIndex = 1;
            this.materialFlatButton2.Text = "ENDEREÇOS";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.lblEnderecos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.materialFlatButton2);
            this.panel3.Location = new System.Drawing.Point(295, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 38);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.lblEnderecos_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.materialDivider1);
            this.panel4.Controls.Add(this.materialFlatButton3);
            this.panel4.Location = new System.Drawing.Point(558, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 40);
            this.panel4.TabIndex = 6;
            this.panel4.Click += new System.EventHandler(this.lblAgendamentos_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.lblExames);
            this.panel5.Location = new System.Drawing.Point(819, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(177, 40);
            this.panel5.TabIndex = 7;
            this.panel5.Click += new System.EventHandler(this.lblExames_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Maroon;
            this.panel6.Controls.Add(this.lblSair1);
            this.panel6.Location = new System.Drawing.Point(1099, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(177, 40);
            this.panel6.TabIndex = 7;
            this.panel6.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(30, 4);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(122, 36);
            this.materialFlatButton3.TabIndex = 1;
            this.materialFlatButton3.Text = "Agendamentos";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.lblAgendamentos_Click);
            // 
            // lblExames
            // 
            this.lblExames.AutoSize = true;
            this.lblExames.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblExames.Depth = 0;
            this.lblExames.Location = new System.Drawing.Point(58, 3);
            this.lblExames.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblExames.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblExames.Name = "lblExames";
            this.lblExames.Primary = false;
            this.lblExames.Size = new System.Drawing.Size(66, 36);
            this.lblExames.TabIndex = 2;
            this.lblExames.Text = "Exames";
            this.lblExames.UseVisualStyleBackColor = true;
            this.lblExames.Click += new System.EventHandler(this.lblExames_Click);
            // 
            // lblSair1
            // 
            this.lblSair1.AutoSize = true;
            this.lblSair1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair1.ForeColor = System.Drawing.Color.White;
            this.lblSair1.Location = new System.Drawing.Point(70, 9);
            this.lblSair1.Name = "lblSair1";
            this.lblSair1.Size = new System.Drawing.Size(36, 20);
            this.lblSair1.TabIndex = 0;
            this.lblSair1.Text = "Sair";
            // 
            // frmPacientesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 716);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPacientesMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPacienteMain";
            this.Load += new System.EventHandler(this.frmPacientesMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlForms;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSair1;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialFlatButton lblExames;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}