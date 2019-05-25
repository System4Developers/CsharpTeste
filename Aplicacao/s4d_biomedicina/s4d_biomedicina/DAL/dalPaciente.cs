using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using s4d_biomedicina.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace s4d_biomedicina.DAL
{
    public class dalPaciente : basePacientes
    {


        /*
            insert into pessoas
            values
            ('lucas','302518787','30685794655','20190525','analista','superior')
            declare @idPessoa int = @@identity
            insert into pacientes
            values
            ('1',98.5,1.85,'ab-',@idPessoa,'ATIVADO')

            select idPaciente,nome,rg,cpf,dtNascimento,profissao,grauInstrucao,prontuario,peso,altura,grupoSanguineo
            from pacientes
            join pessoas 
            on pacientes.fk_idPessoa_pessoas = pessoas.idPessoa
          
         */

        public DataTable GetListaPacientes()
        {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select idPaciente as [ID], nome as [NOME], rg as [RG],cpf as [CPF], dtNascimento as [NASCIMENTO], prontuario as [PRONTUARIO], profissao as [PROFISSAO] from pacientes join pessoas on pacientes.fk_idPessoa_pessoas = pessoas.idPessoa", con.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public string AdicionarPaciente(string nome, string rg, string cpf, string dtNascimento, string profissao, string grauInstrucao, string prontuario, double peso,double altura,string grupoSanguineo,string estadoPaciente)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
            this.dtNascimento = dtNascimento;
            this.profissao = profissao;
            this.grauInstrucao = grauInstrucao;
            this.prontuario = prontuario;
            this.peso = peso;
            this.altura = altura;
            this.grupoSanguineo = grupoSanguineo;
            this.estadoPaciente = estadoPaciente;

            cmd.CommandText = "insert into pessoas (nome,rg,cpf,dtNascimento,profissao,grauInstrucao) " +
                "values (@nome,@rg,@cpf,@dtNascimento,@profissao,@grauInstrucao) " +
                "declare @idPessoa int = @@identity " +
                "insert into pacientes (prontuario,peso,altura,grupoSanguineo,fk_idPessoa_pessoas,estadoPaciente) " +
                "values (@prontuario,@peso,@altura,@grupoSanguineo,@idPessoa,@estadoPaciente)";
            cmd.Parameters.AddWithValue("@nome", this.nome);
            cmd.Parameters.AddWithValue("@rg", this.rg);
            cmd.Parameters.AddWithValue("@cpf", this.cpf);
            cmd.Parameters.AddWithValue("@dtNascimento", this.dtNascimento);
            cmd.Parameters.AddWithValue("@profissao", this.profissao);
            cmd.Parameters.AddWithValue("@grauInstrucao", this.grauInstrucao);

            cmd.Parameters.AddWithValue("@prontuario", this.prontuario);
            cmd.Parameters.AddWithValue("@peso", this.peso);
            cmd.Parameters.AddWithValue("@altura", this.altura);
            cmd.Parameters.AddWithValue("@grupoSanguineo", this.grupoSanguineo);
            cmd.Parameters.AddWithValue("@estadoPaciente", this.estadoPaciente);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
            }
            catch (SqlException ex)
            {
                throw new InvalidOperationException(ex.Message + " - " + cmd.CommandText, ex);
                //this.mensagem = "Erro com Banco";
                //this.mensagem = ;
            }

            return this.mensagem;
        }
        //public SqlDataReader dr;

        /*
        

        public string AtualizarUsuario(string login, string senha, string ra, string registro, string curso, string estado, string tipo, int idPessoa, int idUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.login = login;
            this.senha = senha;
            this.ra = ra;
            this.registro = registro;
            this.curso = curso;
            this.estado = estado;
            this.tipo = tipo;
            this.idUsuario = idUsuario;

            cmd.CommandText = "update usuarios set dslogin = @login, senha = @senha, ra = @ra, registroFuncional = @registro, curso = @curso , estadoUsuario = @estado, tipoUsuario = @tipo where idUsuario = @idUsuario";
            cmd.Parameters.AddWithValue("@login", this.login);
            cmd.Parameters.AddWithValue("@senha", this.senha);
            cmd.Parameters.AddWithValue("@ra", this.ra);
            cmd.Parameters.AddWithValue("@registro", this.registro);
            cmd.Parameters.AddWithValue("@curso", this.curso);
            cmd.Parameters.AddWithValue("@estado", this.estado);
            cmd.Parameters.AddWithValue("@tipo", this.tipo);
            cmd.Parameters.AddWithValue("@idUsuario", this.idUsuario);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco";
            }

            return this.mensagem;
        }

        public void GetEditarUsuario(int idUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "select dslogin,senha,ra,registroFuncional,curso,tipoUsuario,estadoUsuario from usuarios where idUsuario=@idUsuario";
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco!";
            }
        }

        public DataTable GetPesquisaUsuario(int idUsuario, string dslogin)
        {
            Conexao con = new Conexao();

            string strSQL = "";
            SqlDataAdapter sda;

            if (idUsuario > 0)
            {
                strSQL = "select idUsuario as [ID], dslogin as [LOGIN], ra as [RA],registroFuncional as [REGISTRO], curso as [CURSO], estadoUsuario as [ESTADO],tipoUsuario as [TIPO]  from usuarios where idUsuario = @idUsuario";
                sda = new SqlDataAdapter(strSQL, con.Conectar());
                sda.SelectCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
            }
            else
            {
                strSQL = "select idUsuario as [ID], dslogin as [LOGIN], ra as [RA],registroFuncional as [REGISTRO], curso as [CURSO], estadoUsuario as [ESTADO],tipoUsuario as [TIPO]  from usuarios where dslogin like @login";
                sda = new SqlDataAdapter(strSQL, con.Conectar());
                sda.SelectCommand.Parameters.AddWithValue("@login", string.Format("%{0}%", dslogin));
            }
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        
        */
    }
}
