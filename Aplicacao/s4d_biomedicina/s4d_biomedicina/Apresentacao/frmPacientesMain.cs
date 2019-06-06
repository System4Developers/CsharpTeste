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
    public partial class frmPacientesMain : Form
    {
        private string comando;
        private int idPaciente;

        public frmPacientesMain(string comando, int idPaciente)
        {
            InitializeComponent();
            this.comando = comando;
            this.idPaciente = idPaciente;
        }

        private void lblDados_Click(object sender, EventArgs e)
        {
            Apresentacao.frmPacientesDadosCadastrais frmPacienteDadosCadastrais = new frmPacientesDadosCadastrais(this.comando, idPaciente);
            AbrirFormulario(frmPacienteDadosCadastrais);
        }

        private void lblEnderecos_Click(object sender, EventArgs e)
        {
            Apresentacao.frmPacientesEnderecos frmPacientesEnderecos = new frmPacientesEnderecos(idPaciente);
            AbrirFormulario(frmPacientesEnderecos);
        }

        private void frmPacientesMain_Load(object sender, EventArgs e)
        {
            Apresentacao.frmPacientesDadosCadastrais frmPacienteDadosCadastrais = new frmPacientesDadosCadastrais(this.comando, idPaciente);
            AbrirFormulario(frmPacienteDadosCadastrais);
        }

        private void lblExames_Click(object sender, EventArgs e)
        {
            Apresentacao.frmPacientesExames frmPacientesExames = new frmPacientesExames(idPaciente);
            AbrirFormulario(frmPacientesExames);
        }
       
        private void lblAgendamentos_Click(object sender, EventArgs e)
        {
            Apresentacao.frmPacientesAgendamentos frmPacientesAgendamentos = new frmPacientesAgendamentos(idPaciente);
            AbrirFormulario(frmPacientesAgendamentos);
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormulario(Form frm)
        {
            string frmStatus = "";
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == frm.Name)
                {
                    frmStatus = "aberto";
                }
                else
                {
                    frmStatus = "";
                }
            }
            if (frmStatus.Equals(""))
            {
                FecharFormularios();
                frm.TopLevel = false;
                frm.AutoScroll = true;
                pnlForms.Controls.Clear();
                pnlForms.Controls.Add(frm);
                frm.Show();
            }
        }

        private void FecharFormularios()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name != "frmPrincipal" && Application.OpenForms[i].Name != "frmPacientesMain" && Application.OpenForms[i].Name != "frmPacientes")
                {
                    Application.OpenForms[i].Close();
                }
            }
            pnlForms.Controls.Clear();
        }

        
    }
}
