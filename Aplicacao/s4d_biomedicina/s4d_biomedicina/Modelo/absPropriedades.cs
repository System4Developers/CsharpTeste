using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4d_biomedicina.Modelo
{
    public abstract class absPropriedades
    {
        protected string mensagem;

        public override string ToString()
        {
            return this.mensagem;
        }
    }
}
