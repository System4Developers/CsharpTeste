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
        private string comando;
        private int idExameParametro;

        public frmExamesParametrosManter(string comando, int idExameParametro)
        {
            InitializeComponent();
            this.comando = comando;
            this.idExameParametro = idExameParametro;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            if (this.comando.Equals("inserir"))
            {
                controle.cadastarExameParametro(txbParametro.Text,Convert.ToDouble(txbLimiteMax.Text),Convert.ToDouble(txbLimiteMin.Text),Convert.ToInt32(cmbTipo.SelectedValue.ToString()));
                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Cadastrado com Sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(controle.ToString());
                }
            }
            
            if (this.comando.Equals("editar"))
            {
                controle.AtualizarExamesParametros(txbParametro.Text,Convert.ToDouble(txbLimiteMax.Text), Convert.ToDouble(txbLimiteMin.Text), Convert.ToInt32(cmbTipo.SelectedValue.ToString()),Convert.ToInt32(txbID.Text));
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

        private void frmExamesParametrosManter_Load(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            cmbTipo.DataSource = controle.GetExameTipoCombo();
            cmbTipo.DisplayMember = "Tipo";
            cmbTipo.ValueMember = "ID";

            if (this.comando.Equals("editar"))
            {
                controle.GetEditarExamesParametros(this.idExameParametro);
                while (controle.Dr.Read())
                {
                    txbID.Text = this.idExameParametro.ToString();
                    cmbTipo.Text = controle.Dr["dsExameTipo"].ToString();
                    txbParametro.Text = controle.Dr["dsExameParametro"].ToString();
                    txbLimiteMin.Text = controle.Dr["valorMin"].ToString();
                    txbLimiteMax.Text = controle.Dr["valorMax"].ToString();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
