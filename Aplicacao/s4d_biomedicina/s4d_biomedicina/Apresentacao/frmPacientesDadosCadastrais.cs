using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace s4d_biomedicina.Apresentacao
{
    public partial class frmPacientesDadosCadastrais : Form
    {
        private string comando;
        private int idPaciente;
        private SqlDataReader dr;

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
            this.dr = controle.GetPacienteDadosCadastrais(this.idPaciente);
            while (this.dr.Read())
            {
                txbID.Text = this.idPaciente.ToString();
                txbProntuario.Text = this.dr["prontuario"].ToString();
                txbPeso.Text = this.dr["peso"].ToString();
                txbAltura.Text = this.dr["altura"].ToString();
                txbGrupoSanguineo.Text = this.dr["grupoSanguineo"].ToString();
                cmbEstado.Text = this.dr["estadoPaciente"].ToString();
                txbNome.Text = this.dr["nome"].ToString();
                txbRg.Text = this.dr["rg"].ToString();
                txbCpf.Text = this.dr["cpf"].ToString();
                txbDtNascimento.Text = this.dr["dtNascimento"].ToString();
                txbProfissao.Text = this.dr["profissao"].ToString();
                txbGrauInstrucao.Text = this.dr["grauInstrucao"].ToString();
            }
        }
    }
}
