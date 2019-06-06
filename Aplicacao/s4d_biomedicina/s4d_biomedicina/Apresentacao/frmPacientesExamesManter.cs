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

        }

        private void bntMover1_Click(object sender, EventArgs e)
        {
            lbExames2.Items.Add(lbExames.Text);
            lbExames.Items.Remove(lbExames.Text);

        }
    }
}
