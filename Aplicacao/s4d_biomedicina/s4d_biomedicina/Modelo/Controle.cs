using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s4d_biomedicina.Modelo
{
    public class Controle : absPropriedades
    {

        public void acessar(string login, string senha)
        {
            Estaticos.logado = false;
            this.mensagem = "";

            Validacao validacao = new Validacao();
            validacao.verLogin(login, senha);
            if (validacao.ToString().Equals(""))
            {
                DAL.Usuario loginCmd = new DAL.Usuario();
                loginCmd.VerificarLogin(login, senha);
                if (loginCmd.ToString().Equals(""))
                {
                    Estaticos.logado = true;
                }
                else
                {
                    this.mensagem= loginCmd.ToString();
                }
            }
            else
            {
                this.mensagem = validacao.ToString();
            }
        }

        public void cadastrarUsuario(string login, string senha, string ra, string registro, string curso, string estado, string tipo, int idPessoa)
        {
            DAL.Usuario usuario = new DAL.Usuario();
            usuario.AdicionarUsuario(login, senha, ra, registro, curso, estado, tipo, idPessoa);
            if (usuario.ToString().Equals(""))
            {
                MessageBox.Show("Cadastro OK");
            }
            else
            {
                this.mensagem = usuario.ToString();
            }
        }



    }
}
