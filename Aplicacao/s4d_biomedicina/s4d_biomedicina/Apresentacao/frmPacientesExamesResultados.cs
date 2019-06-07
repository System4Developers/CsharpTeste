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
    public partial class frmPacientesExamesResultados : Form
    {
        private string comando;
        private int idExameResultado;

        public frmPacientesExamesResultados(int idExameResultado, string comando)
        {
            InitializeComponent();
            this.comando = comando;
            this.idExameResultado = idExameResultado;

        }

        private void frmPacientesExamesResultados_Load(object sender, EventArgs e)
        {
            if (this.comando == "editar")
            {
                DAL.dalExameResultado dalExameResultado = new DAL.dalExameResultado();
                dalExameResultado.GetEditarExameResultado(this.idExameResultado);
                while (dalExameResultado.dr.Read())
                {
                    txbExameTipo.Text = dalExameResultado.dr["dsExameTipo"].ToString();
                    txbParametro.Text = dalExameResultado.dr["dsExameParametro"].ToString();
                    txbValor1.Text = dalExameResultado.dr["valormedidoa"].ToString();
                    txbValor2.Text = dalExameResultado.dr["valormedidob"].ToString();
                    txbValor3.Text = dalExameResultado.dr["valormedidoc"].ToString();
                }
            }
        }
    }
}
