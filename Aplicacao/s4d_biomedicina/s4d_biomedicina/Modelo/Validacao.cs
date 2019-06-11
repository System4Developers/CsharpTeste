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

        #region Verificar Operacoes Usuario
        public void verCadastroUsuario(string login, string senha, string ra, string registro, string curso, string estado, string tipo, int idPessoa)
        {
            this.mensagem = "";
            if (login.Equals("") || senha.Equals("") || ra.Equals("") || tipo.Equals("") ) 
            {
                this.mensagem = "Necessario Informar Login, Senha, RA, e o Tipo de Usuario!";
            }
        }
        #endregion


    }
}
