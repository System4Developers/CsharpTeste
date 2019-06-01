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
                    Estaticos.userName = login;
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
            Validacao validacao = new Validacao();
            validacao.verCadastroUsuario(login,senha,ra,registro,curso,estado,tipo,idPessoa);
            if (validacao.ToString().Equals(""))
            {
                DAL.dalUsuario usuario = new DAL.dalUsuario();
                usuario.AdicionarUsuario(login, senha, ra, registro, curso, estado, tipo, idPessoa);
                if (!usuario.ToString().Equals(""))
                {
                    this.mensagem = usuario.ToString();
                }
            }
            else
            {
                this.mensagem = validacao.ToString();
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

        public DataTable PequisarUsuario(int idUsuario, string dslogin)
        {
            DataTable dt = new DataTable();
            DAL.dalUsuario usuario = new DAL.dalUsuario();
            dt = usuario.GetPesquisaUsuario(idUsuario, dslogin);
            return dt;
        }
        #endregion

        #region Manter Paciente
        public void cadastrarPaciente(string nome, string rg, string cpf, string dtNascimento, string profissao, string grauInstrucao, string prontuario, double peso, double altura, string grupoSanguineo, string estadoPaciente, string logradouro, string bairro, string numero, string cidade, string estado)
        {
            this.mensagem = "";

            DAL.dalPaciente paciente = new DAL.dalPaciente();
            paciente.AdicionarPaciente(nome,rg,cpf,dtNascimento,profissao,grauInstrucao,prontuario,peso,altura,grupoSanguineo,estadoPaciente,logradouro,bairro,numero,cidade,estado);
            if (!paciente.ToString().Equals(""))
            {
                this.mensagem = paciente.ToString();
            }
        }


        public DataTable ListaPaciente()
        {
            DataTable dt = new DataTable();
            DAL.dalPaciente paciente = new DAL.dalPaciente();
            dt = paciente.GetListaPacientes();
            return dt;
        }
        #endregion

    }
}
