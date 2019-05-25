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

        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvPacientes.DataSource = controle.ListaPaciente();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.comando = "inserir";
            frmPacientesManter frmPacientesManter = new frmPacientesManter(this, this.comando, 0);
            frmPacientesManter.ShowDialog();
        }
    }
}
