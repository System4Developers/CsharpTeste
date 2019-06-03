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
    public partial class frmExamesParametros : Form
    {
        private string comando;

        public frmExamesParametros()
        {
            InitializeComponent();
        }

        private void frmExamesParametros_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvExamesParametros.DataSource = controle.ListaExamesParametros();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.comando = "inserir";
            frmExamesParametrosManter frmExamesParametrosManter = new frmExamesParametrosManter(this, this.comando, 0);
            frmExamesParametrosManter.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idExameParametro;
            this.comando = "editar";
            idExameParametro = Convert.ToInt32(dgvExamesParametros.CurrentRow.Cells[0].Value);

            frmExamesParametrosManter frmExamesParametrosManter = new frmExamesParametrosManter(this, this.comando, idExameParametro);
            frmExamesParametrosManter.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvExamesParametros.DataSource = controle.PesquisarExamesParametros(Convert.ToInt32(txbID.Text), txbTipo.Text);
        }
    }
}
