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
    public partial class frmPacientes : Form
    {
        private string comando;
        private int idPaciente;

        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.comando = "inserir";
            frmPacientesManter frmPacientesManter = new frmPacientesManter(this.comando, 0);
            frmPacientesManter.ShowDialog();
            AtualizarTabela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.comando = "editar";
            this.idPaciente = Convert.ToInt32(dgvPacientes.CurrentRow.Cells[0].Value);
            frmPacientesMain frmPacientesMain = new frmPacientesMain(this.comando, this.idPaciente);
            frmPacientesMain.ShowDialog();
            AtualizarTabela();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvPacientes.DataSource = controle.PesquisarPaciente(txbNome.Text,txbCpf.Text);
        }

        private void AtualizarTabela()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvPacientes.DataSource = controle.ListaPaciente();
        }
    }
}
