﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using s4d_biomedicina.Apresentacao;


namespace s4d_biomedicina.Apresentacao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (!Modelo.Estaticos.logado)
            {
                this.Close();
            }
        }

        private void tsiUsuarios_Click(object sender, EventArgs e)
        {
            Apresentacao.frmUsuarios frmUsuarios = new frmUsuarios();
            AbrirFormulario(frmUsuarios);
        }

        private void tsmTrocarUsuario_Click(object sender, EventArgs e)
        {
            
            Apresentacao.frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void tsmSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Operacoes de formularios
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
                if (Application.OpenForms[i].Name != "frmPrincipal")
                {
                    Application.OpenForms[i].Close();
                }
            }
            pnlForms.Controls.Clear();
        }
        #endregion

    }
}
