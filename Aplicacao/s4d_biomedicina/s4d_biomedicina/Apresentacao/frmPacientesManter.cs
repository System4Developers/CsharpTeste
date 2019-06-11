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
    public partial class frmPacientesManter : Form
    {
        
        private string comando;
        private int idPaciente;

        public frmPacientesManter(string comando, int idPaciente)
        {
            InitializeComponent();
            this.comando = comando;
            this.idPaciente = idPaciente;
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.comando.Equals("editar"))
            {
                Modelo.Controle controle = new Modelo.Controle();
                controle.AtualizarPaciente(txbNome.Text, txbRg.Text, txbCpf.Text, txbDtNascimento.Text, txbProfissao.Text, txbGrauInstrucao.Text, txbProntuario.Text, Convert.ToDouble(txbPeso.Text), Convert.ToDouble(txbAltura.Text), txbGrupoSanguineo.Text, cmbEstado.Text, Convert.ToInt32(txbID.Text));
                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Atualizado com Sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(controle.ToString());
                }
            }
            else
            {
                Modelo.Controle controle = new Modelo.Controle();
                controle.AdicionarPaciente(txbNome.Text, txbRg.Text, txbCpf.Text, txbDtNascimento.Text, txbProfissao.Text, txbGrauInstrucao.Text, txbProntuario.Text, Convert.ToDouble(txbPeso.Text), Convert.ToDouble(txbAltura.Text), txbGrupoSanguineo.Text, cmbEstado.Text);
                if (controle.ToString().Equals(""))
                {
                    controle.GetPacienteID(txbCpf.Text);
                    while (controle.dr.Read())
                    {
                        this.idPaciente = Convert.ToInt32(controle.dr["idPaciente"].ToString());
                    }
                    frmPacientesMain frmPacientesMain = new frmPacientesMain(this.comando, this.idPaciente);
                    frmPacientesMain.ShowDialog();
                    this.Close();
                }
            }
        }

        private void frmPacientesManter_Load(object sender, EventArgs e)
        {
            if (this.comando.Equals("editar"))
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
