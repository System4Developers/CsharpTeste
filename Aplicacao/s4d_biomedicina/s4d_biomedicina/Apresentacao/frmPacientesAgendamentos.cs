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
    public partial class frmPacientesAgendamentos : Form
    {
        private int idPaciente;
        private string comando;


        public frmPacientesAgendamentos(int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
        }

        private void frmPacientesAgendamentos_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvPacientesAgendamentos.DataSource = controle.ListaPacienteAgendamentos(this.idPaciente);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.comando = "inserir";
            frmPacientesAgendamentosManter frmPacientesAgendamentosManter = new frmPacientesAgendamentosManter();
            frmPacientesAgendamentosManter.ShowDialog();
        }
    }
    
}
