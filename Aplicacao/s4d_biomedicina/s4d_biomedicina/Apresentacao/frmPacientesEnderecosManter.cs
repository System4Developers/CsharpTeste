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
        private int idPacienteEndereco;

        public frmPacientesEnderecosManter(string comando, int idPacienteEndereco)
        {
            InitializeComponent();
            this.idPacienteEndereco = idPacienteEndereco;
            this.comando = comando;
        }

        private void frmPacientesEnderecosManter_Load(object sender, EventArgs e)
        {
            if (this.comando == "editar")
            {
                Modelo.Controle controle = new Modelo.Controle();
                controle.GetEditarPacienteEndereco(this.idPacienteEndereco);
                while (controle.dr.Read())
                {
                    txbRua.Text = controle.dr.GetValue(1).ToString();
                    txbNumero.Text = controle.dr.GetValue(3).ToString();
                    txbBairro.Text = controle.dr.GetValue(2).ToString();
                    txbCidade.Text = controle.dr.GetValue(4).ToString();
                    txbEstado.Text = controle.dr.GetValue(5).ToString();
                }
            }
        }

        private void txbCep_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (this.comando == "editar")
            {
                Modelo.Controle controle = new Modelo.Controle();
                controle.AtualizarPacienteEndereco(txbCep.Text, txbRua.Text, txbNumero.Text, txbComplemento.Text, txbBairro.Text, txbEstado.Text, txbCidade.Text, this.idPacienteEndereco);

                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Atualização ok");
                    this.Close();
                }
            }
            if (this.comando == "inserir")
            {
                Modelo.Controle controle = new Modelo.Controle();
                controle.AdicionarPacienteEndereco(txbCep.Text, txbRua.Text, txbNumero.Text, txbComplemento.Text, txbBairro.Text, txbEstado.Text, txbCidade.Text, this.idPacienteEndereco);

                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Cadastro OK");
                    this.comando = "editar";
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                lblInformacao.Text = "Sem conexão com a internet";
            }
        }
    }
}
