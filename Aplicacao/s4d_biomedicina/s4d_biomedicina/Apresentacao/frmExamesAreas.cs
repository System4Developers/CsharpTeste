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
        private string comando;

        public frmExamesAreas()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvExamesAreas.DataSource = controle.PesquisarExameArea(Convert.ToInt32(txbID.Text), txbDS.Text);
        }

        private void frmExamesAreas_Load(object sender, EventArgs e)
        {
          AtualizarTabela();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.comando = "inserir";
            frmExamesAreasManter frmAreas = new frmExamesAreasManter(this.comando, 0);
            frmAreas.ShowDialog();
            AtualizarTabela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idArea;
            this.comando = "editar";
            try
            {
                idArea = Convert.ToInt32(dgvExamesAreas.CurrentRow.Cells[0].Value);
                frmExamesAreasManter frmAreas = new frmExamesAreasManter(this.comando, idArea);
                frmAreas.ShowDialog();
                AtualizarTabela();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um item da tabela");
            }
        }

        private void AtualizarTabela()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvExamesAreas.DataSource = controle.ListaExamesAreas();
        }
    }
}
