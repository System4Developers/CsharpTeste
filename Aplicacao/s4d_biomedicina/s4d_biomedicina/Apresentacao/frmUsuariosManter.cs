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

        private readonly frmUsuarios frmUsuarios;
        private string comando;
        private int idUsuario;

        public frmUsuariosManter(frmUsuarios frm,string comando,int idUsuario)
        {
            InitializeComponent();
            this.comando = comando;
            this.idUsuario = idUsuario;
            this.frmUsuarios = frm;

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
                    this.frmUsuarios.AtualizarTabela();
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
                    this.frmUsuarios.AtualizarTabela();
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
                DAL.dalUsuario dalUsuario = new DAL.dalUsuario();
                dalUsuario.BuscarUsuario(this.idUsuario);
                while(dalUsuario.dr.Read())
                {
                    txbID.Text = this.idUsuario.ToString();
                    txbLogin.Text = dalUsuario.dr.GetValue(0).ToString();
                    txbSenha.Text = dalUsuario.dr.GetValue(1).ToString();
                    txbRA.Text = dalUsuario.dr.GetValue(2).ToString();
                    txbRegistro.Text = dalUsuario.dr.GetValue(3).ToString();
                    txbCurso.Text = dalUsuario.dr.GetValue(4).ToString();
                    cmbTipo.Text = dalUsuario.dr.GetValue(5).ToString();
                    cmbEstado.Text = dalUsuario.dr.GetValue(6).ToString();




                    /*
                          DataTable dt = new DataTable()
                        txtID.text=dt.Rows[0]["EmpID"].ToString();
                        txtName.text=dt.Rows[0]["EmpName"].ToString();
                        txtDept.text=dt.Rows[0]["Dept"].ToString();
                        txtSalary.text=dt.Rows[0]["Dept"].ToString();
                        txtCity.text=dt.Rows[0]["City"].ToString();
                                        
                     */
                }
            }
        }
    }
}
