using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s4d_biomedicina.Apresentacao
{
    public partial class frmPacientesEnderecosManter : Form
    {
        private string comando;
        private int idPacienteouEndereco;
        private readonly frmPacientesEnderecos frmPacientesEnderecos;

        public frmPacientesEnderecosManter(string comando, int idPacienteouEndereco, frmPacientesEnderecos frm)
        {
            InitializeComponent();
            this.idPacienteouEndereco = idPacienteouEndereco;
            this.comando = comando;
            this.frmPacientesEnderecos = frm;
        }

        private void frmPacientesEnderecosManter_Load(object sender, EventArgs e)
        {
            if (this.comando == "editar")
            {
                DAL.dalPaciente dalPaciente = new DAL.dalPaciente();
                dalPaciente.GetEditarPacienteEnderecos(this.idPacienteouEndereco);
                while (dalPaciente.dr.Read())
                {
                    txbRua.Text = dalPaciente.dr.GetValue(1).ToString();
                    txbNumero.Text = dalPaciente.dr.GetValue(3).ToString();
                    txbBairro.Text = dalPaciente.dr.GetValue(2).ToString();
                    txbComplemento.Text = "precisa add no banco";
                    txbCidade.Text = dalPaciente.dr.GetValue(4).ToString();
                    txbEstado.Text = dalPaciente.dr.GetValue(5).ToString();
                }
            }
        }

        private void frmPacientesEnderecosManter_Leave(object sender, EventArgs e)
        {

        }
        private void LocalizarCEP()
        {
            try
            {
                Correios.AtendeClienteClient consulta = new Correios.AtendeClienteClient("AtendeClientePort");
                var resultado = consulta.consultaCEP(txbCep.Text);

                if (resultado != null)
                {
                    txbRua.Text = resultado.end;
                    txbBairro.Text = resultado.bairro;
                    txbCidade.Text = resultado.cidade;
                    txbEstado.Text = resultado.uf;
                    lblInformacao.Text = "";
                }
            }
            catch (FaultException)
            {
                lblInformacao.Text = "CEP não encontrado ou inválido";
            }
            catch (EndpointNotFoundException)
            {
                lblInformacao.Text = "Verifique sua conexão com a internet";
            }
        }

        private void txbCep_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.comando == "inserir")
            {
                Modelo.Controle controle = new Modelo.Controle();
                controle.cadastrarPacienteEndereco(txbCep.Text, txbRua.Text, txbNumero.Text, txbComplemento.Text, txbBairro.Text, txbEstado.Text, txbCidade.Text,this.idPacienteouEndereco);

                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Cadastro OK");
                    //consulta sql que retorna o iD conforme o txbCPF
                    this.comando = "editar";
                    this.frmPacientesEnderecos.AtualizarTabela();
                    this.Close();
                }
                               
            }
            if (this.comando == "editar")
            {
                Modelo.Controle controle = new Modelo.Controle();
                controle.AtualizarPacienteEndereco(txbCep.Text, txbRua.Text, txbNumero.Text, txbComplemento.Text, txbBairro.Text, txbEstado.Text, txbCidade.Text, this.idPacienteouEndereco);

                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Atualização ok");
                    //consulta sql que retorna o iD conforme o txbCPF
                    this.comando = "editar";
                    this.frmPacientesEnderecos.AtualizarTabela();
                    this.Close();
                }
            }
        }
    }
}
