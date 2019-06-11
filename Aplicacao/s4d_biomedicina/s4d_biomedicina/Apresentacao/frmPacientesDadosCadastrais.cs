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
            while (controle.dr.Read())
            {
                txbID.Text = this.idPaciente.ToString();
                txbProntuario.Text = controle.dr["prontuario"].ToString();
                txbPeso.Text = controle.dr["peso"].ToString();
                txbAltura.Text = controle.dr["altura"].ToString();
                txbGrupoSanguineo.Text = controle.dr["grupoSanguineo"].ToString();
                cmbEstado.Text = controle.dr["estadoPaciente"].ToString();
                txbNome.Text = controle.dr["nome"].ToString();
                txbRg.Text = controle.dr["rg"].ToString();
                txbCpf.Text = controle.dr["cpf"].ToString();
                txbDtNascimento.Text = controle.dr["dtNascimento"].ToString();
                txbProfissao.Text = controle.dr["profissao"].ToString();
                txbGrauInstrucao.Text = controle.dr["grauInstrucao"].ToString();
            }
        }
    }
}
