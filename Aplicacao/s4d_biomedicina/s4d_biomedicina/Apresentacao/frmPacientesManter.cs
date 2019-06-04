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
    public partial class frmPacientesManter : Form
    {
        private readonly frmPacientesMain frmPacientesMain;
        private string comando;
        private int idPaciente;

        public frmPacientesManter(frmPacientesMain frm, string comando, int idPaciente)
        {
            InitializeComponent();
            this.comando = comando;
            this.idPaciente = idPaciente;
            this.frmPacientesMain = frm;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();

            controle.cadastrarPaciente(txbNome.Text, txbRg.Text, txbCpf.Text, txbDtNascimento.Text, txbProfissao.Text, txbGrauInstrucao.Text, txbProntuario.Text, Convert.ToDouble(txbPeso.Text), Convert.ToDouble(txbAltura.Text), txbGrupoSanguineo.Text, cmbEstado.Text, txbLogradouro.Text, txbBairro.Text, txbNumero.Text, txbCidade.Text, txbEstado.Text);
            if (controle.ToString().Equals(""))
            {
                MessageBox.Show("Cadastro OK");
                //consulta sql que retorna o iD conforme o txbCPF
                this.comando = "editar";

                DAL.dalPaciente dalPaciente = new DAL.dalPaciente();
                dalPaciente.ConsultaCpfPaciente(txbCpf.Text);
                while (dalPaciente.dr.Read())
                {
                    this.idPaciente = Convert.ToInt32(dalPaciente.dr["idPaciente"].ToString());


                    frmPacientesMain frmPacientesMain = new frmPacientesMain(this, this.comando, this.idPaciente);
                    frmPacientesMain.ShowDialog();

                }


            }

        }
    }
}
