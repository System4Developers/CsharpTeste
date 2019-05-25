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
                controle.cadastrarPaciente(txbNome.Text, txbRg.Text, txbCpf.Text, txbDtNascimento.Text, txbProfissao.Text, txbGrauInstrucao.Text, txbProntuario.Text, Convert.ToDouble(txbPeso.Text), Convert.ToDouble(txbAltura.Text), txbGrupoSanguineo.Text, cmbEstado.Text);
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
        }
    }
}
