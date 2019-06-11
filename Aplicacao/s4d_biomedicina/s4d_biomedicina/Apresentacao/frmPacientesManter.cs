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
                    while (controle.Dr.Read())
                    {
                        this.idPaciente = Convert.ToInt32(controle.Dr["idPaciente"].ToString());
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
            else
            {
                cmbEstado.SelectedIndex = 0;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
