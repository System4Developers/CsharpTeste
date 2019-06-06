using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4d_biomedicina.Modelo
{
    public abstract class Agendamentos:Pacientes
    {
        protected Int32 idAgendamento;
        protected string Data;
        protected string Horario;
        protected string Status;
        protected string Solicitante;

        public int IdAgendamento { get => idAgendamento; }

    }
}
