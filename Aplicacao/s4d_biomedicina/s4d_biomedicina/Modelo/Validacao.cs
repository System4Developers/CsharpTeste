using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4d_biomedicina.Modelo
{
    public class Validacao:absPropriedades
    {

        public void verLogin(string login, string senha)
        {
            this.mensagem = "";
                            
            if (login.Equals("") || senha.Equals(""))
            {
                this.mensagem = "Informe o Login e/ou Senha";
            }

        }
    }
}
