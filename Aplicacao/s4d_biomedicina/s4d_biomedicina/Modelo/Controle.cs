using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        public void AdicionarPaciente(string nome, string rg, string cpf, string dtNascimento, string profissao, string grauInstrucao, string prontuario, double peso, double altura, string grupoSanguineo, string estadoPaciente)
        {
            this.mensagem = "";

            DAL.dalPaciente paciente = new DAL.dalPaciente();
            paciente.AdicionarPaciente(nome,rg,cpf,dtNascimento,profissao,grauInstrucao,prontuario,peso,altura,grupoSanguineo,estadoPaciente);
            if (!paciente.ToString().Equals(""))
            {
                this.mensagem = paciente.ToString();
            }
        }

        public void AdicionarPacienteEndereco(string Cep, string Rua, string Numero, string Complemento, string Bairro, string Estado, string Cidade,int idPaciente)        {
            this.mensagem = "";

            DAL.dalPaciente paciente = new DAL.dalPaciente();
            paciente.AdicionarPacienteEndereco(Cep, Rua, Numero, Complemento, Bairro, Estado, Cidade,idPaciente);
            if (!paciente.ToString().Equals(""))
            {
                this.mensagem = paciente.ToString();
            }
        }

        public void AtualizarPacienteEndereco(string Cep, string Rua, string Numero, string Complemento, string Bairro, string Estado, string Cidade, int idEndereco)
        {
            this.mensagem = "";
            DAL.dalPaciente paciente = new DAL.dalPaciente();
            paciente.AtualizarPacienteEndereco(Cep, Rua, Numero, Complemento, Bairro, Estado, Cidade, idEndereco);
            if (!paciente.ToString().Equals(""))
            {
                this.mensagem = paciente.ToString();
            }
        }

        public void AtualizarPaciente(string nome, string rg, string cpf, string dtNascimento, string profissao, string grauInstrucao, string prontuario, double peso, double altura, string grupoSanguineo, string estadoPaciente, int idPaciente)
        {
            this.mensagem = "";
            DAL.dalPaciente paciente = new DAL.dalPaciente();
            paciente.AtualizarPaciente(nome,rg,cpf,dtNascimento,profissao,grauInstrucao,prontuario,peso,altura,grupoSanguineo,estadoPaciente,idPaciente);
            if (!paciente.ToString().Equals(""))
            {
                this.mensagem = paciente.ToString();
            }
        }

        public SqlDataReader GetPacienteDadosCadastrais(int idPaciente)
        {
            DAL.dalPaciente dalPaciente = new DAL.dalPaciente();
            dalPaciente.GetPacienteDadosCadastrais(idPaciente);
            return dalPaciente.dr;
        }
      
        public DataTable PesquisarPaciente(string nome, string cpf)
        {
            DataTable dt = new DataTable();
            DAL.dalPaciente dalPaciente = new DAL.dalPaciente();
            dt = dalPaciente.GetPesquisaPaciente(nome, cpf);
            return dt;
        }

        public DataTable ListaPaciente()
        {
            DataTable dt = new DataTable();
            DAL.dalPaciente paciente = new DAL.dalPaciente();
            dt = paciente.GetListaPacientes();
            return dt;
        }

        public DataTable ListaPacienteEnderecos(int idPaciente)
        {
            DataTable dt = new DataTable();
            DAL.dalPaciente paciente = new DAL.dalPaciente();
            dt = paciente.GetListaPacienteEnderecos(idPaciente);
            return dt;
        }

        public DataTable ListaPacienteExames(int idPaciente)
        {
            DataTable dt = new DataTable();
            DAL.dalPaciente paciente = new DAL.dalPaciente();
            dt = paciente.GetListaPacienteExames(idPaciente);
            return dt;
        }

        public DataTable ListaPacienteAgendamentos(int idPaciente)
        {
            DataTable dt = new DataTable();
            DAL.dalAgendamentos paciente = new DAL.dalAgendamentos();
            dt = paciente.GetListaPacienteAgendamentos(idPaciente);
            return dt;
        }
        #endregion

        #region Manter Exames Areas
        public void CadastrarExameArea(string dsExameArea)
        {
            this.mensagem = "";

            DAL.dalExameArea exame = new DAL.dalExameArea();
            exame.AdicionarArea(dsExameArea);
            if (!exame.ToString().Equals(""))
            {
                this.mensagem = exame.ToString();
            }
        }

        public void AtualizarExameArea(string dsExameArea, int idExameArea)
        {
            this.mensagem = "";
            DAL.dalExameArea exame = new DAL.dalExameArea();
            exame.AtualizarArea(dsExameArea, idExameArea);
                if (!exame.ToString().Equals(""))
            {
                this.mensagem = exame.ToString();
            }
        }

        public DataTable ListaExamesAreas()
        {
            DataTable dt = new DataTable();
            DAL.dalExameArea exame = new DAL.dalExameArea();
            dt = exame.GetListaExamesAreas();
            return dt;
        }

        public DataTable PesquisarExameArea(int idExameArea, string dsExameArea)
        {
            DataTable dt = new DataTable();
            DAL.dalExameArea exame = new DAL.dalExameArea();
            dt = exame.GetPesquisaAreas(idExameArea,dsExameArea);
            return dt;
        }
        #endregion

        #region Manter Exames Tipos
        public void cadastrarExameTipo(string dsExameArea, string estadoExameTipo, int idExameArea)
        {
            this.mensagem = "";

            DAL.dalExameTipo exametipo = new DAL.dalExameTipo();
            exametipo.AdicionarExameTipo(dsExameArea, estadoExameTipo, idExameArea);
            if (!exametipo.ToString().Equals(""))
            {
                this.mensagem = exametipo.ToString();
            }
        }

        public void AtualizarExamesTipos(string dsExameTipo, string estadoExameTipo,int idExameTipo,int idExameArea)
        {
            this.mensagem = "";
            DAL.dalExameTipo exametipo = new DAL.dalExameTipo();
            exametipo.AtualizarExamesTipos(dsExameTipo, estadoExameTipo, idExameTipo,idExameArea);
            if (!exametipo.ToString().Equals(""))
            {
                this.mensagem = exametipo.ToString();
            }
        }

        public DataTable GetExameAreaCombo()
        {
            DAL.dalExameTipo dalExameTipo = new DAL.dalExameTipo();
            dalExameTipo.GetExameAreaCombo();
            return dalExameTipo.dt;
        }
        
        public DataTable ListaExamesTipos()
        {
            DataTable dt = new DataTable();
            DAL.dalExameTipo exametipo = new DAL.dalExameTipo();
            dt = exametipo.GetListaExamesTipos();
            return dt;
        }

        public DataTable PesquisarExamesTipos(int idExameTipo, string dsExameTipo)
        {
            DataTable dt = new DataTable();
            DAL.dalExameTipo exametipo = new DAL.dalExameTipo();
            dt = exametipo.GetPesquisaExamesTipos(idExameTipo, dsExameTipo);
            return dt;
        }
        #endregion

        #region Manter Exames Parametros

        public void cadastarExameParametro(string dsExameParametro, double valorMax, double valorMin, int idExameTipo)
        {
            this.mensagem = "";

            DAL.dalExameParametro dalExameParametro = new DAL.dalExameParametro();
            dalExameParametro.AdicionarExamesParametros(dsExameParametro, valorMax, valorMin,idExameTipo);
            if (!dalExameParametro.ToString().Equals(""))
            {
                this.mensagem = dalExameParametro.ToString();
            }
        }

        public DataTable GetExameTipoCombo()
        {
            DAL.dalExameParametro dalExameParametro = new DAL.dalExameParametro();
            dalExameParametro.GetExameTipoCombo();
            return dalExameParametro.dt;
        }
        
        public void AtualizarExamesParametros(string dsExameParametro, double valorMax, double valorMin, int idExameTipo,int idExameParametro)
        {
            this.mensagem = "";
            DAL.dalExameParametro dalExameParametro = new DAL.dalExameParametro();
            dalExameParametro.AtualizarExamesParametros(dsExameParametro,valorMax, valorMin, idExameTipo, idExameParametro);
            if (!dalExameParametro.ToString().Equals(""))
            {
                this.mensagem = dalExameParametro.ToString();
            }
        }

        public DataTable ListaExamesParametros()
        {
            DataTable dt = new DataTable();
            DAL.dalExameParametro dalExameParametro = new DAL.dalExameParametro();
            dt = dalExameParametro.GetListaExamesParametros();
            return dt;
        }

        public DataTable PesquisarExamesParametros(int idExameParametro, string dsExameParametro)
        {
            DataTable dt = new DataTable();
            DAL.dalExameParametro dalExameParametro = new DAL.dalExameParametro();
            dt = dalExameParametro.GetPesquisaExamesParametros(idExameParametro, dsExameParametro);
            return dt;
        }
        #endregion

<<<<<<< HEAD
        #region Manter Agendamentos
        public void adicionarPacienteAgendamento(string Data, string Horario, string Status,int id,string solicitante)
        {
            this.mensagem = "";
            
            DAL.dalAgendamentos paciente = new DAL.dalAgendamentos();
            paciente.AdicionarPacienteAgendamento(Data,Horario,Status,id,solicitante);
            if (!paciente.ToString().Equals(""))
            {
                this.mensagem = paciente.ToString();
            }
        }

        #endregion
=======

>>>>>>> 1227b2822c8e410377c5a0fdefc67e1d26349704

    }
}
