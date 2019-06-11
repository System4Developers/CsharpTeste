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
    public partial class frmUsuariosManter : Form
    {
        private string comando;
        private int idUsuario;

        public frmUsuariosManter(string comando,int idUsuario)
        {
            InitializeComponent();
            this.comando = comando;
            this.idUsuario = idUsuario;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            if (this.comando.Equals("inserir"))
            {
                controle.cadastrarUsuario(txbLogin.Text, txbSenha.Text, txbRA.Text, txbRegistro.Text, txbCurso.Text, cmbEstado.Text, cmbTipo.Text, 0);
                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Cadastro OK");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(controle.ToString());
                }
            }

            if (this.comando.Equals("editar"))
            {
                 controle.AtualizarUsuario(txbLogin.Text, txbSenha.Text, txbRA.Text, txbRegistro.Text, txbCurso.Text, cmbEstado.Text, cmbTipo.Text, 0, Convert.ToInt32(txbID.Text));
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
        }

        private void frmUsuariosManter_Load(object sender, EventArgs e)
        {
            if (this.comando.Equals("editar"))
            {
                Modelo.Controle controle = new Modelo.Controle();
                controle.GetEditarUsuario(this.idUsuario);
                while(controle.Dr.Read())
                {
                    txbID.Text = this.idUsuario.ToString();
                    txbLogin.Text = controle.Dr.GetValue(0).ToString();
                    txbSenha.Text = controle.Dr.GetValue(1).ToString();
                    txbRA.Text = controle.Dr.GetValue(2).ToString();
                    txbRegistro.Text = controle.Dr.GetValue(3).ToString();
                    txbCurso.Text = controle.Dr.GetValue(4).ToString();
                    cmbTipo.Text = controle.Dr.GetValue(5).ToString();
                    cmbEstado.Text = controle.Dr.GetValue(6).ToString();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
