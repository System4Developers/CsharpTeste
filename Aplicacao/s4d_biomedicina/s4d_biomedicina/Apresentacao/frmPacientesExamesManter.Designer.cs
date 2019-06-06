namespace s4d_biomedicina.Apresentacao
{
    partial class frmPacientesExamesManter
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
            this.components = new System.ComponentModel.Container();
            this.lbExames = new System.Windows.Forms.ListBox();
            this.lbExames2 = new System.Windows.Forms.ListBox();
            this.bntMover1 = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnMoverTodos = new System.Windows.Forms.Button();
            this.btnRemoverTodos = new System.Windows.Forms.Button();
            this.unipBiomedicinaDataSet = new s4d_biomedicina.unipBiomedicinaDataSet();
            this.examesTiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examesTiposTableAdapter = new s4d_biomedicina.unipBiomedicinaDataSetTableAdapters.examesTiposTableAdapter();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDisponiveis = new System.Windows.Forms.Label();
            this.lblSolicitados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.unipBiomedicinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examesTiposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbExames
            // 
            this.lbExames.FormattingEnabled = true;
            this.lbExames.Location = new System.Drawing.Point(63, 75);
            this.lbExames.Name = "lbExames";
            this.lbExames.Size = new System.Drawing.Size(202, 212);
            this.lbExames.TabIndex = 0;
            // 
            // lbExames2
            // 
            this.lbExames2.FormattingEnabled = true;
            this.lbExames2.Location = new System.Drawing.Point(448, 75);
            this.lbExames2.Name = "lbExames2";
            this.lbExames2.Size = new System.Drawing.Size(186, 212);
            this.lbExames2.TabIndex = 1;
            // 
            // bntMover1
            // 
            this.bntMover1.Location = new System.Drawing.Point(298, 100);
            this.bntMover1.Name = "bntMover1";
            this.bntMover1.Size = new System.Drawing.Size(115, 23);
            this.bntMover1.TabIndex = 2;
            this.bntMover1.Text = ">";
            this.bntMover1.UseVisualStyleBackColor = true;
            this.bntMover1.Click += new System.EventHandler(this.bntMover1_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(298, 145);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(115, 23);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "<";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnMoverTodos
            // 
            this.btnMoverTodos.Location = new System.Drawing.Point(298, 188);
            this.btnMoverTodos.Name = "btnMoverTodos";
            this.btnMoverTodos.Size = new System.Drawing.Size(115, 23);
            this.btnMoverTodos.TabIndex = 4;
            this.btnMoverTodos.Text = "Mover todos >>";
            this.btnMoverTodos.UseVisualStyleBackColor = true;
            this.btnMoverTodos.Click += new System.EventHandler(this.btnMoverTodos_Click);
            // 
            // btnRemoverTodos
            // 
            this.btnRemoverTodos.Location = new System.Drawing.Point(298, 231);
            this.btnRemoverTodos.Name = "btnRemoverTodos";
            this.btnRemoverTodos.Size = new System.Drawing.Size(115, 23);
            this.btnRemoverTodos.TabIndex = 5;
            this.btnRemoverTodos.Text = "<< Remover todos";
            this.btnRemoverTodos.UseVisualStyleBackColor = true;
            this.btnRemoverTodos.Click += new System.EventHandler(this.btnRemoverTodos_Click);
            // 
            // unipBiomedicinaDataSet
            // 
            this.unipBiomedicinaDataSet.DataSetName = "unipBiomedicinaDataSet";
            this.unipBiomedicinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examesTiposBindingSource
            // 
            this.examesTiposBindingSource.DataMember = "examesTipos";
            this.examesTiposBindingSource.DataSource = this.unipBiomedicinaDataSet;
            // 
            // examesTiposTableAdapter
            // 
            this.examesTiposTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(510, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblDisponiveis
            // 
            this.lblDisponiveis.AutoSize = true;
            this.lblDisponiveis.Location = new System.Drawing.Point(72, 56);
            this.lblDisponiveis.Name = "lblDisponiveis";
            this.lblDisponiveis.Size = new System.Drawing.Size(102, 13);
            this.lblDisponiveis.TabIndex = 7;
            this.lblDisponiveis.Text = "Exames disponiveis:";
            // 
            // lblSolicitados
            // 
            this.lblSolicitados.AutoSize = true;
            this.lblSolicitados.Location = new System.Drawing.Point(445, 56);
            this.lblSolicitados.Name = "lblSolicitados";
            this.lblSolicitados.Size = new System.Drawing.Size(69, 13);
            this.lblSolicitados.TabIndex = 8;
            this.lblSolicitados.Text = "Selecionado:";
            // 
            // frmPacientesExamesManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.lblSolicitados);
            this.Controls.Add(this.lblDisponiveis);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnRemoverTodos);
            this.Controls.Add(this.btnMoverTodos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.bntMover1);
            this.Controls.Add(this.lbExames2);
            this.Controls.Add(this.lbExames);
            this.Name = "frmPacientesExamesManter";
            this.Text = "frmPacientesExamesManter";
            this.Load += new System.EventHandler(this.frmPacientesExamesManter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unipBiomedicinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examesTiposBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbExames;
        private System.Windows.Forms.ListBox lbExames2;
        private System.Windows.Forms.Button bntMover1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnMoverTodos;
        private System.Windows.Forms.Button btnRemoverTodos;
        private unipBiomedicinaDataSet unipBiomedicinaDataSet;
        private System.Windows.Forms.BindingSource examesTiposBindingSource;
        private unipBiomedicinaDataSetTableAdapters.examesTiposTableAdapter examesTiposTableAdapter;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDisponiveis;
        private System.Windows.Forms.Label lblSolicitados;
    }
}