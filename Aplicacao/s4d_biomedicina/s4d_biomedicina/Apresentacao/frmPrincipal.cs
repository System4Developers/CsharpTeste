using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using s4d_biomedicina.Apresentacao;


namespace s4d_biomedicina.Apresentacao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (!Modelo.Estaticos.logado)
            {
                this.Close();
            }
        }
    }
}
