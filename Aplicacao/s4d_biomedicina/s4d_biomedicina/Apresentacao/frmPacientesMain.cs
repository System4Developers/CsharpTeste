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
        private readonly Form frmPacientes;
        private string comando;
        private int idPaciente;

        public frmPacientesMain(Form frm, string comando, int idPaciente)
        {
            InitializeComponent();
            this.comando = comando;
            this.idPaciente = idPaciente;
            this.frmPacientes = frm;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            Apresentacao.frmPacientesDadosCadastrais frmPacienteDadosCadastrais = new frmPacientesDadosCadastrais(this, this.comando, idPaciente);
            AbrirFormulario(frmPacienteDadosCadastrais);
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
                if (Application.OpenForms[i].Name != "frmPrincipal" && Application.OpenForms[i].Name != "frmPacientesMain" )
                {
                    Application.OpenForms[i].Close();
                }
            }
            pnlForms.Controls.Clear();
        }

        private void frmPacientesMain_Load(object sender, EventArgs e)
        {
            Apresentacao.frmPacientesDadosCadastrais frmPacienteDadosCadastrais = new frmPacientesDadosCadastrais(this, this.comando, idPaciente);
            AbrirFormulario(frmPacienteDadosCadastrais);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Apresentacao.frmPacientesEnderecos frmPacientesEnderecos = new frmPacientesEnderecos(idPaciente);
            AbrirFormulario(frmPacientesEnderecos);
        }

        private void pnlForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAgendamentos_Click(object sender, EventArgs e)
        {
            Apresentacao.frmPacientesAgendamentos frmPacientesAgendamentos = new frmPacientesAgendamentos(idPaciente);
            AbrirFormulario(frmPacientesAgendamentos);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Apresentacao.frmPacientesExames frmPacientesExames = new frmPacientesExames(idPaciente);
            AbrirFormulario(frmPacientesExames);
        }
    }
}
