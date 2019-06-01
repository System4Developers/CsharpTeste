using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4d_biomedicina.Modelo
{
    public abstract class Usuario
    {
        protected Int32 idUsuario;
        protected String login;
        protected String senha;
        protected String ra;
        protected String registro;
        protected String curso;
        protected String estado;
        protected String tipo;
        protected String comando;

        protected string mensagem;

        public int IdUsuario { get => idUsuario; }
        public string Login { get => login; }
                
        public override string ToString()
        {
            return this.mensagem;
        }


    }
}
