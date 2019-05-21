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
    public partial class frmUsuariosNovo : Form
    {

        private readonly frmUsuarios frmUsuarios;

        public frmUsuariosNovo(frmUsuarios frm)
        {
            InitializeComponent();

            frmUsuarios = frm;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            controle.cadastrarUsuario(txbLogin.Text, txbSenha.Text, txbRA.Text, txbRegistro.Text, txbCurso.Text, cmbEstado.Text, cmbTipo.Text, 0);
            if (controle.ToString().Equals(""))
            {
                MessageBox.Show("Cadastro OK");
                this.frmUsuarios.AtualizarTabela();
                this.Close();
            }
            else
            {
                MessageBox.Show(controle.ToString());
            }
            
        }
    }
}
