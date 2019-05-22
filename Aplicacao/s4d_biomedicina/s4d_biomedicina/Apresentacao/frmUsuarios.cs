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
            this.comando = "inserir";
            frmUsuariosManter frmNovoUsuario = new frmUsuariosManter(this,this.comando,0);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.comando = "editar";
            int idUsuario;

            idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
        //MessageBox.Show(dgvUsuarios.CurrentRow.ToString());
        //MessageBox.Show(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
        //foreach (DataGridViewRow row in dgvUsuarios.SelectedCells)
        //{
        //   MessageBox.Show(row.Cells[0].Value.ToString());

        //}
        frmUsuariosManter frmNovoUsuario = new frmUsuariosManter(this, this.comando, idUsuario);
        frmNovoUsuario.ShowDialog();
    }
    }
}
