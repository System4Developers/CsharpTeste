using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s4d_biomedicina.Apresentacao
{
    public partial class frmUsuarios : Form
    {
        private string comando = "";

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            AtualizarTabela();                      
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.comando = "inserir";
            frmUsuariosManter frmNovoUsuario = new frmUsuariosManter(this,this.comando,0);
            frmNovoUsuario.ShowDialog();
        }

        public void AtualizarTabela()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvUsuarios.DataSource = controle.ListaUsuario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idUsuario;
            this.comando = "editar";
            idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
            frmUsuariosManter frmNovoUsuario = new frmUsuariosManter(this, this.comando, idUsuario);
            frmNovoUsuario.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txbID.Text.Equals(""))
            {
                txbID.Text = "0";
            }
            Modelo.Controle controle = new Modelo.Controle();
            dgvUsuarios.DataSource = controle.PequisarUsuario(Convert.ToInt32(txbID.Text), txbLogin.Text);
        }
    }
}
