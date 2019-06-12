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
    public partial class frmLogin : MaterialSkin.Controls.MaterialForm 
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Modelo.Estaticos.logado = false;
            this.Close();
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.ToString().Equals(""))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(controle.ToString());
            }
        }
    }
}
