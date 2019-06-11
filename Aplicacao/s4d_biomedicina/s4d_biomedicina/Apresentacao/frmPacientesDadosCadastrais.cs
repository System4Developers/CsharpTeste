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
    public partial class frmPacientesDadosCadastrais : Form
    {
        private string comando;
        private int idPaciente;

        public frmPacientesDadosCadastrais(string comando, int idPaciente)
        {
            InitializeComponent();
            this.comando = comando;
            this.idPaciente = idPaciente;
        }

        private void frmPacienteDadosCadastrais_Load(object sender, EventArgs e)
        {
            AtualizarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.comando = "editar";
            frmPacientesManter frmPacientesManter = new frmPacientesManter(this.comando, Convert.ToInt32(txbID.Text));
            frmPacientesManter.ShowDialog();
            AtualizarCampos();
        }

        private void AtualizarCampos()
        {
            Modelo.Controle controle = new Modelo.Controle();
            controle.GetPacienteDadosCadastrais(this.idPaciente);
            while (controle.Dr.Read())
            {
                txbID.Text = this.idPaciente.ToString();
                txbProntuario.Text = controle.Dr["prontuario"].ToString();
                txbPeso.Text = controle.Dr["peso"].ToString();
                txbAltura.Text = controle.Dr["altura"].ToString();
                txbGrupoSanguineo.Text = controle.Dr["grupoSanguineo"].ToString();
                cmbEstado.Text = controle.Dr["estadoPaciente"].ToString();
                txbNome.Text = controle.Dr["nome"].ToString();
                txbRg.Text = controle.Dr["rg"].ToString();
                txbCpf.Text = controle.Dr["cpf"].ToString();
                txbDtNascimento.Text = controle.Dr["dtNascimento"].ToString();
                txbProfissao.Text = controle.Dr["profissao"].ToString();
                txbGrauInstrucao.Text = controle.Dr["grauInstrucao"].ToString();
            }
        }
    }
}
