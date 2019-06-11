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
    public partial class frmPacientesAgendamentosManter : Form
    {
        private string comando;
        private int idAgendamento;

        public frmPacientesAgendamentosManter(string comando, int idAgendamento)
        {
            InitializeComponent();
            this.idAgendamento = idAgendamento;
            this.comando = comando;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.comando == "editar")
            {
                Modelo.Controle controle = new Modelo.Controle();
                controle.AtualizarPacienteAgendamento(dtpAgendamento.Text, cmbHorario.Text, cmbStatus.Text, this.idAgendamento, txbSolicitante.Text);

                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Cadastro OK");
                    this.Close();
                }
            }
            if (this.comando == "inserir")
            {
                Modelo.Controle controle = new Modelo.Controle();
                controle.AdicionarPacienteAgendamento(dtpAgendamento.Text, cmbHorario.Text, cmbStatus.Text, this.idAgendamento, txbSolicitante.Text);

                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Cadastro OK");
                    this.comando = "editar";
                    this.Close();
                }
            }
        }

        private void frmPacientesAgendamentosManter_Load(object sender, EventArgs e)
        {
            if (this.comando == "editar")
            {
                Modelo.Controle controle = new Modelo.Controle();
                controle.GetEditarAgendamento(this.idAgendamento);
                while (controle.Dr.Read())
                {
                    dtpAgendamento.Text = controle.Dr.GetValue(0).ToString();
                    cmbHorario.Text = controle.Dr.GetValue(1).ToString();
                    cmbStatus.Text = controle.Dr.GetValue(3).ToString();
                    txbSolicitante.Text = controle.Dr.GetValue(2).ToString();
                }
            }
            else
            {
                cmbStatus.SelectedIndex = 0;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
