using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4d_biomedicina.Modelo
{
    public abstract class baseUsuario
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

        protected int IdUsuario { get => idUsuario; set => idUsuario = value; }
        protected string Login { get => login; set => login = value; }
        protected string Senha { get => senha; set => senha = value; }
        protected string Ra { get => ra; set => ra = value; }
        protected string Registro { get => registro; set => registro = value; }
        protected string Curso { get => curso; set => curso = value; }
        protected string Estado { get => estado; set => estado = value; }
        protected string Tipo { get => tipo; set => tipo = value; }
        protected string Comando { get => comando; set => comando = value; }
               
        public override string ToString()
        {
            return this.mensagem;
        }


    }
}
