using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4d_biomedicina.Modelo
{
    public abstract class Exames:absPropriedades
    {
        protected int idExameArea;
        protected string dsExameArea;

        protected int idExameTipo;
        protected string dsExameTipo;
        protected string estadoExameTipo;

        protected int idExameParametro;
        protected double valorMin;
        protected double valorMax;
        protected string dsExameParametro;

        protected int idExameResultado;
        protected double valorMedidoA;
        protected double valorMedidoB;
        protected double valorMedidoC;

    }
}
