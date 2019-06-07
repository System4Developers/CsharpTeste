using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using s4d_biomedicina.Modelo;

namespace s4d_biomedicina.DAL
{
    public class dalUsuario : Usuario
    {
        
        public SqlDataReader dr;

        public String VerificarLogin(string login, string senha)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.login = login;
            this.senha = senha;
            
            cmd.CommandText = "select idUsuario from usuarios where dslogin = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login",this.login);
            cmd.Parameters.AddWithValue("@senha",this.senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
            
                if (dr.HasRows)
                {
                    this.mensagem = "";
                    while (dr.Read()) { 
                    Modelo.Estaticos.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                    }
                }
                else
                {
                    this.mensagem = "Usuario/Senha Invalido";
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com banco de Dados";
            }
            return this.mensagem;
        }

        public string AdicionarUsuario(string login, string senha, string ra, string registro, string curso, string estado, string tipo, int idPessoa)
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
  
            cmd.CommandText = "insert into usuarios (dslogin,senha,ra,registroFuncional,curso,estadoUsuario,tipoUsuario) values (@login,@senha,@ra,@registro,@curso,@estado,@tipo)";
            cmd.Parameters.AddWithValue("@login", this.login);
            cmd.Parameters.AddWithValue("@senha", this.senha);
            cmd.Parameters.AddWithValue("@ra", this.ra);
            cmd.Parameters.AddWithValue("@registro", this.registro);
            cmd.Parameters.AddWithValue("@curso", this.curso);
            cmd.Parameters.AddWithValue("@estado", this.estado);
            cmd.Parameters.AddWithValue("@tipo", this.tipo);
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

        public DataTable GetPesquisaUsuario(int idUsuario,string dslogin)
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
                sda.SelectCommand.Parameters.AddWithValue("@login", string.Format("%{0}%",dslogin));
            }
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable GetListaUsuario()
        {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select idUsuario as [ID], dslogin as [LOGIN], ra as [RA],registroFuncional as [REGISTRO], curso as [CURSO], estadoUsuario as [ESTADO],tipoUsuario as [TIPO]  from usuarios", con.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

    }
}
