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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpAgendamento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbExamesAreas = new System.Windows.Forms.ComboBox();
            this.lblExamesAreas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntMover1
            // 
            this.bntMover1.Location = new System.Drawing.Point(505, 252);
            this.bntMover1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntMover1.Name = "bntMover1";
            this.bntMover1.Size = new System.Drawing.Size(153, 28);
            this.bntMover1.TabIndex = 2;
            this.bntMover1.Text = ">";
            this.bntMover1.UseVisualStyleBackColor = true;
            this.bntMover1.Click += new System.EventHandler(this.bntMover1_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(505, 308);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(153, 28);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnMoverTodos
            // 
            this.btnMoverTodos.Location = new System.Drawing.Point(505, 361);
            this.btnMoverTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoverTodos.Name = "btnMoverTodos";
            this.btnMoverTodos.Size = new System.Drawing.Size(153, 28);
            this.btnMoverTodos.TabIndex = 4;
            this.btnMoverTodos.Text = "Mover todos >>";
            this.btnMoverTodos.UseVisualStyleBackColor = true;
            this.btnMoverTodos.Click += new System.EventHandler(this.btnMoverTodos_Click);
            // 
            // btnRemoverTodos
            // 
            this.btnRemoverTodos.Location = new System.Drawing.Point(505, 414);
            this.btnRemoverTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoverTodos.Name = "btnRemoverTodos";
            this.btnRemoverTodos.Size = new System.Drawing.Size(153, 28);
            this.btnRemoverTodos.TabIndex = 5;
            this.btnRemoverTodos.Text = "<< Remover todos";
            this.btnRemoverTodos.UseVisualStyleBackColor = true;
            this.btnRemoverTodos.Click += new System.EventHandler(this.btnRemoverTodos_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(812, 548);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(153, 28);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDisponiveis
            // 
            this.lblDisponiveis.AutoSize = true;
            this.lblDisponiveis.Location = new System.Drawing.Point(49, 175);
            this.lblDisponiveis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisponiveis.Name = "lblDisponiveis";
            this.lblDisponiveis.Size = new System.Drawing.Size(135, 17);
            this.lblDisponiveis.TabIndex = 7;
            this.lblDisponiveis.Text = "Exames disponiveis:";
            // 
            // lblSolicitados
            // 
            this.lblSolicitados.AutoSize = true;
            this.lblSolicitados.Location = new System.Drawing.Point(720, 175);
            this.lblSolicitados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolicitados.Name = "lblSolicitados";
            this.lblSolicitados.Size = new System.Drawing.Size(97, 17);
            this.lblSolicitados.TabIndex = 8;
            this.lblSolicitados.Text = "Selecionados:";
            // 
            // ltvExames
            // 
            this.ltvExames.FullRowSelect = true;
            this.ltvExames.HideSelection = false;
            this.ltvExames.Location = new System.Drawing.Point(53, 209);
            this.ltvExames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltvExames.MultiSelect = false;
            this.ltvExames.Name = "ltvExames";
            this.ltvExames.Size = new System.Drawing.Size(411, 278);
            this.ltvExames.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ltvExames.TabIndex = 9;
            this.ltvExames.UseCompatibleStateImageBehavior = false;
            this.ltvExames.View = System.Windows.Forms.View.Details;
            // 
            // ltvExamesSelecionados
            // 
            this.ltvExamesSelecionados.FullRowSelect = true;
            this.ltvExamesSelecionados.HideSelection = false;
            this.ltvExamesSelecionados.Location = new System.Drawing.Point(724, 209);
            this.ltvExamesSelecionados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltvExamesSelecionados.MultiSelect = false;
            this.ltvExamesSelecionados.Name = "ltvExamesSelecionados";
            this.ltvExamesSelecionados.Size = new System.Drawing.Size(411, 278);
            this.ltvExamesSelecionados.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ltvExamesSelecionados.TabIndex = 10;
            this.ltvExamesSelecionados.UseCompatibleStateImageBehavior = false;
            this.ltvExamesSelecionados.View = System.Windows.Forms.View.Details;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(983, 548);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpAgendamento
            // 
            this.dtpAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAgendamento.Location = new System.Drawing.Point(49, 58);
            this.dtpAgendamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpAgendamento.Name = "dtpAgendamento";
            this.dtpAgendamento.Size = new System.Drawing.Size(415, 22);
            this.dtpAgendamento.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data de Cadastro dos Exame:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbExamesAreas
            // 
            this.cmbExamesAreas.FormattingEnabled = true;
            this.cmbExamesAreas.Location = new System.Drawing.Point(49, 129);
            this.cmbExamesAreas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbExamesAreas.Name = "cmbExamesAreas";
            this.cmbExamesAreas.Size = new System.Drawing.Size(415, 24);
            this.cmbExamesAreas.TabIndex = 1;
            this.cmbExamesAreas.SelectedIndexChanged += new System.EventHandler(this.cmbExamesAreas_SelectedIndexChanged);
            // 
            // lblExamesAreas
            // 
            this.lblExamesAreas.AutoSize = true;
            this.lblExamesAreas.Location = new System.Drawing.Point(45, 97);
            this.lblExamesAreas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExamesAreas.Name = "lblExamesAreas";
            this.lblExamesAreas.Size = new System.Drawing.Size(102, 17);
            this.lblExamesAreas.TabIndex = 14;
            this.lblExamesAreas.Text = "Exames Areas:";
            // 
            // frmPacientesExamesManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 615);
            this.Controls.Add(this.cmbExamesAreas);
            this.Controls.Add(this.lblExamesAreas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpAgendamento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.ltvExamesSelecionados);
            this.Controls.Add(this.ltvExames);
            this.Controls.Add(this.lblSolicitados);
            this.Controls.Add(this.lblDisponiveis);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnRemoverTodos);
            this.Controls.Add(this.btnMoverTodos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.bntMover1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPacientesExamesManter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Exames por Agendamento";
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpAgendamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbExamesAreas;
        private System.Windows.Forms.Label lblExamesAreas;
    }
}