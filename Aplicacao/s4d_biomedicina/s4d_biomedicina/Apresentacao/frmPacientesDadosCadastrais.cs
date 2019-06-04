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

        private readonly frmPacientesMain frmPacientesMain;
        private string comando;
        private int idPaciente;


        public frmPacientesDadosCadastrais(frmPacientesMain frm, string comando, int idPaciente)
        {
            InitializeComponent();
            this.comando = comando;
            this.idPaciente = idPaciente;
            this.frmPacientesMain = frm;
        }

        private void frmPacienteDadosCadastrais_Load(object sender, EventArgs e)
        {

            DAL.dalPaciente dalPaciente = new DAL.dalPaciente();
            dalPaciente.GetEditarPaciente(this.idPaciente);
            while (dalPaciente.dr.Read())
            {

                txbID.Text = this.idPaciente.ToString();
                txbProntuario.Text = dalPaciente.dr.GetValue(0).ToString();
                txbNome.Text = dalPaciente.dr.GetValue(1).ToString();
                txbRg.Text = dalPaciente.dr.GetValue(2).ToString();
                txbCpf.Text = dalPaciente.dr.GetValue(3).ToString();
                txbDtNascimento.Text = dalPaciente.dr.GetValue(4).ToString();
                txbGrauInstrucao.Text = dalPaciente.dr.GetValue(5).ToString();
                txbProfissao.Text = dalPaciente.dr.GetValue(6).ToString();
                cmbEstado.Text = dalPaciente.dr.GetValue(7).ToString();
              
                txbPeso.Text = dalPaciente.dr.GetValue(13).ToString();
                txbAltura.Text = dalPaciente.dr.GetValue(14).ToString();
                txbGrupoSanguineo.Text = dalPaciente.dr.GetValue(15).ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
