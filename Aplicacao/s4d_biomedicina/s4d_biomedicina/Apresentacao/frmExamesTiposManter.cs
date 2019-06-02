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
    public partial class frmExamesTiposManter : Form
    {

        private readonly frmExamesTipos frmExamesTipos;
        private string comando;
        private int idExameTipo;

        public frmExamesTiposManter(frmExamesTipos frm, string comando, int idExameTipo)
        {
            InitializeComponent();
            
            this.comando = comando;
            this.idExameTipo = idExameTipo;
            this.frmExamesTipos = frm;
        }

        private void frmExamesTiposManter_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'unipBiomedicinaDataSet1.examesAreas'. Você pode movê-la ou removê-la conforme necessário.
            this.examesAreasTableAdapter.Fill(this.unipBiomedicinaDataSet1.examesAreas);
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbArea.SelectedValue.ToString());
            
            Modelo.Controle controle = new Modelo.Controle();
            if (this.comando.Equals("inserir"))
            {
               controle.cadastrarExameTipo(txbTipo.Text, cmbStatus.Text, Convert.ToInt32(cmbArea.SelectedValue.ToString()));
                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Cadastro OK");
                    this.frmExamesTipos.AtualizarTabela();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(controle.ToString());
                }
                
            }

            if (this.comando.Equals("editar"))
            {
                controle.AtualizarExamesTipos(txbTipo.Text,cmbStatus.Text, Convert.ToInt32(cmbArea.Text),Convert.ToInt32(txbID.Text));
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
            }
        }

    }
}
