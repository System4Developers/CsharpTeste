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
        private int idConsulta;

        public frmPacientesExames(int idPaciente, int idConsulta)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
            this.idConsulta = idConsulta;
        }

        private void frmPacientesExames_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvPacientesExames.DataSource = controle.ListaPacienteExames(this.idPaciente,this.idConsulta);
            dgvPacientesExames.Columns["idExameResultado"].Visible = false;
            dgvPacientesExames.Columns["idExameParametro"].Visible = false;
            dgvPacientesExames.Columns["idExameTipo"].Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idExameResultado;
            idExameResultado = Convert.ToInt32(dgvPacientesExames.CurrentRow.Cells["idExameResultado"].Value);
            frmPacientesExamesResultados frmPacientesExamesResultados = new frmPacientesExamesResultados(idExameResultado, "editar");
            frmPacientesExamesResultados.ShowDialog();
            AtualizarTabela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExames_Click(object sender, EventArgs e)
        {
            frmPacientesExamesManter frmPacientesExamesManter = new frmPacientesExamesManter("editar", this.idPaciente, this.idConsulta);
            frmPacientesExamesManter.ShowDialog();
            AtualizarTabela();
        }
    }
}
