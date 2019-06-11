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
    public partial class frmPacientesExamesManter : Form
    {
        private string comando;
        private int idPaciente;
        private int idExame;

        public frmPacientesExamesManter(string comando, int idPaciente,int idExame)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
            this.idExame = idExame;
            this.comando = comando;
        }

        private void frmPacientesExamesManter_Load(object sender, EventArgs e)
        {
            CarregaListBox();
            AjustarColunas(ltvExames);
        }

        private void bntMover1_Click(object sender, EventArgs e)
        {
            if (ltvExames.SelectedItems.Count < 1)
            {
                MessageBox.Show("selecione um item");
            }
            else
            {
                ltvExamesSelecionados.Items.Add(new ListViewItem(new string[] { ltvExames.SelectedItems[0].Text, ltvExames.SelectedItems[0].SubItems[1].Text }));
                ltvExames.SelectedItems[0].Remove();
            }
            AjustarColunas(ltvExamesSelecionados);
        }
        
        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (ltvExamesSelecionados.SelectedItems.Count < 1)
            {
                MessageBox.Show("selecione um item");
            }
            else
            {
                ltvExames.Items.Add(new ListViewItem(new string[] { ltvExamesSelecionados.SelectedItems[0].Text, ltvExamesSelecionados.SelectedItems[0].SubItems[1].Text }));
                ltvExamesSelecionados.SelectedItems[0].Remove();
            }
            AjustarColunas(ltvExames);
        }

        private void btnMoverTodos_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ltvExames.Items)
            {
                ltvExamesSelecionados.Items.Add((ListViewItem)item.Clone());
            }
            ltvExames.Items.Clear();
            AjustarColunas(ltvExamesSelecionados);
        }

        private void btnRemoverTodos_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ltvExamesSelecionados.Items)
            {
                ltvExames.Items.Add((ListViewItem)item.Clone());
            }
            ltvExamesSelecionados.Items.Clear();
            AjustarColunas(ltvExames);
        }

        private void CarregaListBox()
        {
            Modelo.Controle controle = new Modelo.Controle();
            controle.GetListaExames();

            ltvExames.Columns.Add("ID");
            ltvExames.Columns.Add("Tipo");
            ltvExamesSelecionados.Columns.Add("ID");
            ltvExamesSelecionados.Columns.Add("Tipo");

            while (controle.Dr.Read())
            {
                ltvExames.Items.Add(new ListViewItem(new string[] { controle.Dr["ID"].ToString(), controle.Dr["Tipo"].ToString() }));
            }
        }

        private void AjustarColunas(ListView ltv)
        {
            ltv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ltv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            int idExameParametro;
            for (int i = 0; i < ltvExamesSelecionados.Items.Count; i++)
            {
                idExameParametro = Convert.ToInt32(ltvExamesSelecionados.Items[i].Text);
            }
            controle.AdicionarExameAgendado("PENDENTE", dtpAgendamento.Text,this.idExame,this.idPaciente,this.idPaciente);
        }
    }
}
