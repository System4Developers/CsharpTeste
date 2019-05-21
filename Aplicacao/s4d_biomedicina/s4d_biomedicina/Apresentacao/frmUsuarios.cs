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
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'unipBiomedicinaDataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            // this.usuariosTableAdapter.Fill(this.unipBiomedicinaDataSet.usuarios);
            /*DAL.Conexao con = new DAL.Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select * from usuarios", con.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvUsuarios.DataSource = dt;*/
            AtualizarTabela();                      
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmUsuariosNovo frmNovoUsuario = new frmUsuariosNovo(this);
            frmNovoUsuario.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.unipBiomedicinaDataSet.usuarios);
        }

        public void AtualizarTabela()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvUsuarios.DataSource = controle.ListaUsuario();
        }
    }
}
