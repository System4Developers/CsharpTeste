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
        private SqlDataReader dr;

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
                    DAL.dalPaciente dalPaciente = new DAL.dalPaciente();
                    dalPaciente.ConsultaCpfPaciente(txbCpf.Text);
                    while (dalPaciente.dr.Read())
                    {
                        this.idPaciente = Convert.ToInt32(dalPaciente.dr["idPaciente"].ToString());
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
}
