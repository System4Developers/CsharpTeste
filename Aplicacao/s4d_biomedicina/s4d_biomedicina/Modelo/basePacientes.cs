﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4d_biomedicina.Modelo
{
    public abstract class basePacientes:basePessoas
    {
        protected Int32 idPaciente;
        protected string estadoPaciente;
        protected Double altura;
        protected string prontuario;
        protected string grupoSanguineo;
        protected Double peso;
        
    }
}
