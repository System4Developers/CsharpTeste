using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s4d_biomedicina.Apresentacao
{
    public partial class frmExamesTipos : Form
    {
        public frmExamesTipos()
        {
            InitializeComponent();
        }

        private string comando;

        private void frmExamesTipos_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvExamesTipos.DataSource = controle.ListaExamesTipos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.comando = "inserir";
            frmExamesTiposManter frmExamesTipos = new frmExamesTiposManter(this, this.comando, 0);
            frmExamesTipos.ShowDialog(); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idExameTipo;
            this.comando = "editar";
            idExameTipo = Convert.ToInt32(dgvExamesTipos.CurrentRow.Cells[0].Value);
            frmExamesTiposManter frmExamesTiposManter = new frmExamesTiposManter(this, this.comando, idExameTipo);
            frmExamesTiposManter.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvExamesTipos.DataSource = controle.PesquisarExamesTipos(Convert.ToInt32(txbID.Text), txbDS.Text);
        }
    }
}
