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
        private int idPacientesouAgendamento;
        private readonly frmPacientesAgendamentos frmPacientesAgendamentos;

        public frmPacientesAgendamentosManter(string comando, int idPacientesouAgendamento, frmPacientesAgendamentos frm)
        {
            InitializeComponent();
            this.idPacientesouAgendamento = idPacientesouAgendamento;
            this.comando = comando;
            this.frmPacientesAgendamentos = frm;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.comando == "inserir")
            {
                Modelo.Controle controle = new Modelo.Controle();
                controle.adicionarPacienteAgendamento(dtpAgendamento.Text, cmbHorario.Text, cmbStatus.Text,this.idPacientesouAgendamento,txbSolicitante.Text);
                

                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Cadastro OK");
                    //consulta sql que retorna o iD conforme o txbCPF
                    this.comando = "editar";
                    this.frmPacientesAgendamentos.AtualizarTabela();
                    this.Close();
                }
            }
        }

        private void cmbHorario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPacientesAgendamentosManter_Load(object sender, EventArgs e)
        {
            if (this.comando == "editar")
            {
                DAL.dalAgendamentos dalAgendamentos = new DAL.dalAgendamentos();
                dalAgendamentos.GetEditarPacienteAgendamentos(this.idPacientesouAgendamento);
                while (dalAgendamentos.dr.Read())
                {
                    dtpAgendamento.Text = dalAgendamentos.dr.GetValue(0).ToString();
                    cmbHorario.Text = dalAgendamentos.dr.GetValue(1).ToString();
                    cmbStatus.Text =  dalAgendamentos.dr.GetValue(3).ToString();
                    txbSolicitante.Text =  dalAgendamentos.dr.GetValue(2).ToString();

                }
            }
        }
    }
}
