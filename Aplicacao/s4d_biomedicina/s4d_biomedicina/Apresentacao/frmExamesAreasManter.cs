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
    public partial class frmExamesAreasManter : Form
    {
 
            private readonly frmExamesAreas frmExamesAreas;
            private string comando;
            private int idExameArea;

            public frmExamesAreasManter(frmExamesAreas frm, string comando, int idExameArea)
            {
                InitializeComponent();
                this.comando = comando;
                this.idExameArea = idExameArea;
                this.frmExamesAreas = frm;
            }

           
            private void frmAreas_Load(object sender, EventArgs e)
            {
                if (this.comando.Equals("editar"))
                {
                    DAL.dalExameArea exame = new DAL.dalExameArea();
                    exame.GetEditarArea(this.idExameArea);
                    while (exame.dr.Read())
                    {                  
                        txbID.Text = this.idExameArea.ToString();
                        txbArea.Text = exame.dr.GetValue(1).ToString();
                    }

                }
            }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            if (this.comando.Equals("inserir"))
            {
                controle.CadastrarExameArea(txbArea.Text);
                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Cadastro OK");
                    this.frmExamesAreas.AtualizarTabela();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(controle.ToString());
                }
            }

            if (this.comando.Equals("editar"))
            {
                controle.AtualizarExameArea(txbArea.Text, Convert.ToInt32(txbID.Text));
                if (controle.ToString().Equals(""))
                {
                    MessageBox.Show("Atualizado com Sucesso!");
                    this.frmExamesAreas.AtualizarTabela();
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

