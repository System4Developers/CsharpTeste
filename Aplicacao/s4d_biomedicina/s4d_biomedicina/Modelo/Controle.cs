using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s4d_biomedicina.Modelo

{
    public class Controle : absPropriedades
    {
        #region Login
        public void acessar(string login, string senha)
        {
            Estaticos.logado = false;
            this.mensagem = "";

            Validacao validacao = new Validacao();
            validacao.verLogin(login, senha);
            if (validacao.ToString().Equals(""))
            {
                DAL.dalUsuario loginCmd = new DAL.dalUsuario();
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
        #endregion
        #region Manter Usuario
        public void cadastrarUsuario(string login, string senha, string ra, string registro, string curso, string estado, string tipo, int idPessoa)
        {
            this.mensagem = "";
            DAL.dalUsuario usuario = new DAL.dalUsuario();
            usuario.AdicionarUsuario(login, senha, ra, registro, curso, estado, tipo, idPessoa);
            if (!usuario.ToString().Equals(""))
            {
                this.mensagem = usuario.ToString();
            }
        }

        public void AtualizarUsuario(string login, string senha, string ra, string registro, string curso, string estado, string tipo, int idPessoa,int idUsuario)
        {
            this.mensagem = "";
            DAL.dalUsuario usuario = new DAL.dalUsuario();

            usuario.AtualizarUsuario(login, senha, ra, registro, curso, estado, tipo, idPessoa,idUsuario);

            if (!usuario.ToString().Equals(""))
            {
                this.mensagem = usuario.ToString();
            }
        }

        public DataTable ListaUsuario()
        {
            DataTable dt = new DataTable();
            DAL.dalUsuario usuario = new DAL.dalUsuario();
            dt = usuario.GetListaUsuario();
            return dt;
        }
        #endregion
    }
}
