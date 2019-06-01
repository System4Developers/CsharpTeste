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
        private readonly frmPacientes frmPacientes;
        private string comando;
        private int idPaciente;

        public frmPacientesManter(frmPacientes frm, string comando, int idPaciente)
        {
            InitializeComponent();
            this.comando = comando;
            this.idPaciente = idPaciente;
            this.frmPacientes = frm;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            if (this.comando.Equals("inserir"))
            {
                controle.cadastrarPaciente(txbNome.Text, txbRg.Text, txbCpf.Text, txbDtNascimento.Text, txbProfissao.Text, txbGrauInstrucao.Text, txbProntuario.Text, Convert.ToDouble(txbPeso.Text), Convert.ToDouble(txbAltura.Text), txbGrupoSanguineo.Text, cmbEstado.Text,txbLogradouro.Text,txbBairro.Text,txbNumero.Text,txbCidade.Text,txbEstado.Text);
                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Cadastro OK");
                    this.frmPacientes.AtualizarTabela();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(controle.ToString());
                }
            }

            if (this.comando.Equals("editar"))
            {
                controle.AtualizarPaciente(txbNome.Text,txbRg.Text,txbCpf.Text,txbDtNascimento.Text,txbProfissao.Text,txbGrauInstrucao.Text,txbProntuario.Text,Convert.ToDouble(txbPeso.Text), Convert.ToDouble(txbAltura.Text),txbGrupoSanguineo.Text,cmbEstado.Text,txbLogradouro.Text,txbBairro.Text,txbNumero.Text,txbCidade.Text,txbEstado.Text,Convert.ToInt32(txbID.Text));
                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Atualizado com Sucesso!");
                    this.frmPacientes.AtualizarTabela();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(controle.ToString());
                }
            }
        }

        private void frmPacientesManter_Load(object sender, EventArgs e)
        {
            if (this.comando.Equals("editar"))
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
                    txbCidade.Text = dalPaciente.dr.GetValue(8).ToString();
                    txbEstado.Text = dalPaciente.dr.GetValue(9).ToString();
                    txbLogradouro.Text = dalPaciente.dr.GetValue(10).ToString();
                    txbBairro.Text = dalPaciente.dr.GetValue(11).ToString();
                    txbNumero.Text = dalPaciente.dr.GetValue(12).ToString();
                    txbPeso.Text = dalPaciente.dr.GetValue(13).ToString();
                    txbAltura.Text = dalPaciente.dr.GetValue(14).ToString();
                    txbGrupoSanguineo.Text = dalPaciente.dr.GetValue(15).ToString();
                  
                }
            }
        }
    }
}
