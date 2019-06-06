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
    public partial class frmPacientesExames : Form
    {
        private int idPaciente;

        public frmPacientesExames(int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
        }

        private void frmPacientesExames_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvPacientesExames.DataSource = controle.ListaPacienteExames(this.idPaciente);
        }
    }
}
