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
    public partial class frmExamesAreas : Form
    {
        public frmExamesAreas()
        {
            InitializeComponent();
        }

        private string comando;

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvExamesAreas.DataSource = controle.PesquisarArea(Convert.ToInt32(txbID.Text), txbDS.Text);
        }

        private void frmExamesAreas_Load(object sender, EventArgs e)
        {
          AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvExamesAreas.DataSource = controle.ListaExamesAreas();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.comando = "inserir";
            frmExamesAreasManter frmAreas = new frmExamesAreasManter(this, this.comando, 0);
            frmAreas.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idArea;
            this.comando = "editar";
            idArea = Convert.ToInt32(dgvExamesAreas.CurrentRow.Cells[0].Value);
            frmExamesAreasManter frmAreas = new frmExamesAreasManter(this, this.comando, idArea);
            frmAreas.Show();
        }
    }
}
