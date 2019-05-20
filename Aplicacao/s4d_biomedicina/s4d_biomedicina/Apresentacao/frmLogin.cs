﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Modelo.Estaticos.logado = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Modelo.Estaticos.logado = false;
            this.Close();
        }
    }
}
