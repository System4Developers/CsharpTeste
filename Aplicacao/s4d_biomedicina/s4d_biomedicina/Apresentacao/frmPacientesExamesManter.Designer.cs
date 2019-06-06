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
            this.bntMover1 = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnMoverTodos = new System.Windows.Forms.Button();
            this.btnRemoverTodos = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDisponiveis = new System.Windows.Forms.Label();
            this.lblSolicitados = new System.Windows.Forms.Label();
            this.ltvExames = new System.Windows.Forms.ListView();
            this.ltvExamesSelecionados = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            // ltvExames
            // 
            this.ltvExames.FullRowSelect = true;
            this.ltvExames.HideSelection = false;
            this.ltvExames.Location = new System.Drawing.Point(75, 84);
            this.ltvExames.MultiSelect = false;
            this.ltvExames.Name = "ltvExames";
            this.ltvExames.Size = new System.Drawing.Size(191, 227);
            this.ltvExames.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ltvExames.TabIndex = 9;
            this.ltvExames.UseCompatibleStateImageBehavior = false;
            this.ltvExames.View = System.Windows.Forms.View.Details;
            // 
            // ltvExamesSelecionados
            // 
            this.ltvExamesSelecionados.FullRowSelect = true;
            this.ltvExamesSelecionados.HideSelection = false;
            this.ltvExamesSelecionados.Location = new System.Drawing.Point(448, 84);
            this.ltvExamesSelecionados.MultiSelect = false;
            this.ltvExamesSelecionados.Name = "ltvExamesSelecionados";
            this.ltvExamesSelecionados.Size = new System.Drawing.Size(194, 227);
            this.ltvExamesSelecionados.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ltvExamesSelecionados.TabIndex = 10;
            this.ltvExamesSelecionados.UseCompatibleStateImageBehavior = false;
            this.ltvExamesSelecionados.View = System.Windows.Forms.View.Details;
            // 
            // frmPacientesExamesManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 516);
            this.Controls.Add(this.ltvExamesSelecionados);
            this.Controls.Add(this.ltvExames);
            this.Controls.Add(this.lblSolicitados);
            this.Controls.Add(this.lblDisponiveis);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnRemoverTodos);
            this.Controls.Add(this.btnMoverTodos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.bntMover1);
            this.Name = "frmPacientesExamesManter";
            this.Text = "frmPacientesExamesManter";
            this.Load += new System.EventHandler(this.frmPacientesExamesManter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntMover1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnMoverTodos;
        private System.Windows.Forms.Button btnRemoverTodos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDisponiveis;
        private System.Windows.Forms.Label lblSolicitados;
        private System.Windows.Forms.ListView ltvExames;
        private System.Windows.Forms.ListView ltvExamesSelecionados;
    }
}