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
    public partial class frmExamesParametrosManter : Form
    {
        private readonly frmExamesParametros frmExamesParametros;
        private string comando;
        private int idExameParametro;

        public frmExamesParametrosManter(frmExamesParametros frm, string comando, int idExameParametro)
        {
            InitializeComponent();
            this.comando = comando;
            this.idExameParametro = idExameParametro;
            this.frmExamesParametros = frm;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            if (this.comando.Equals("inserir"))
            {
                controle.cadastarExameParametro(txbParametro.Text,Convert.ToDouble(txbLimiteMax.Text),Convert.ToDouble(txbLimiteMin.Text),Convert.ToInt32(cmbTipo.SelectedValue.ToString()));
                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Cadastro OK");
                    this.frmExamesParametros.AtualizarTabela();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(controle.ToString());
                }

            }
            /*
            if (this.comando.Equals("editar"))
            {
                controle.AtualizarExamesTipos(txbTipo.Text, cmbStatus.Text, Convert.ToInt32(txbID.Text), Convert.ToInt32(cmbArea.SelectedValue.ToString()));
                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Atualizado com Sucesso!");
                    this.frmExamesTipos.AtualizarTabela();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(controle.ToString());
                }
            }*/
        }

        private void frmExamesParametrosManter_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Modelo.Controle controle = new Modelo.Controle();

            dt = controle.GetExameTipoCombo();
            cmbTipo.DataSource = dt;
            cmbTipo.DisplayMember = "Tipo";
            cmbTipo.ValueMember = "ID";


        }
    }
}
