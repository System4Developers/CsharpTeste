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
    public partial class frmPacientesExamesManter : Form
    {
        private string comando;
        private int idPacienteouExame;
        private readonly frmPacientesExames frmPacientesExames;

        public frmPacientesExamesManter(string comando, int idPacienteouExame, frmPacientesExames frm)
        {
            InitializeComponent();
            this.idPacienteouExame = idPacienteouExame;
            this.comando = comando;
            this.frmPacientesExames = frm;
        }

        private void frmPacientesExamesManter_Load(object sender, EventArgs e)
        {
            CarregaListBox();
        }

        private void bntMover1_Click(object sender, EventArgs e)
        {
            if(lbExames.SelectedIndex == -1)
            {
                MessageBox.Show("selecione um item");
            }
            else
            {
                lbExames2.Items.Add(lbExames.SelectedItem);
                lbExames.Items.Remove(lbExames.SelectedItem);
            }
        }

        private void CarregaListBox()
        {
            Modelo.Controle controle = new Modelo.Controle();
            lbExames.DataSource = controle.GetListaExames();
            lbExames.DisplayMember = "Tipo";
            lbExames.ValueMember = "ID";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lbExames2.SelectedIndex == -1)
            {
                MessageBox.Show("selecione um item");
            }
            else
            { 
                lbExames.Items.Add(lbExames2.SelectedItem);
                lbExames2.Items.Remove(lbExames2.SelectedItem);
            }
        }

        private void btnMoverTodos_Click(object sender, EventArgs e)
        {
            lbExames2.Items.AddRange(lbExames.Items);

            lbExames.Items.Clear();
          
        }

        private void btnRemoverTodos_Click(object sender, EventArgs e)
        {
            while (lbExames2.SelectedItems.Count != 0)
            {
                lbExames.Items.Add(lbExames2.SelectedItem);
                lbExames2.Items.Remove(lbExames2.SelectedItem);
            }
        }
    }
}
