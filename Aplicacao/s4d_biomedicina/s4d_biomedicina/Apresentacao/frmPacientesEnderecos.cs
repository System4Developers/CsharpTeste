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
    public partial class frmPacientesEnderecos : Form
    {
        private int idPaciente;
        private string comando;

        public frmPacientesEnderecos(int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
        }

        private void frmPacientesEnderecos_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvPacientesEnderecos.DataSource = controle.ListaPacienteEnderecos(this.idPaciente);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.comando = "inserir";

            frmPacientesEnderecosManter frmPacientesEnderecosManter = new frmPacientesEnderecosManter(this.comando, idPaciente);
            frmPacientesEnderecosManter.ShowDialog();
            AtualizarTabela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idEndereco;
            this.comando = "editar";
            idEndereco = Convert.ToInt32(dgvPacientesEnderecos.CurrentRow.Cells[0].Value);

            frmPacientesEnderecosManter frmPacientesEnderecosManter = new frmPacientesEnderecosManter(this.comando, idEndereco);
            frmPacientesEnderecosManter.ShowDialog();
            AtualizarTabela();
        }

    }
}
