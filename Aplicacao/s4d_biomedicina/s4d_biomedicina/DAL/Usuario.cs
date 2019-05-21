using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using s4d_biomedicina.Modelo;



namespace s4d_biomedicina.DAL
{
    public class Usuario:absPropriedades
    {
        
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        
        public String VerificarLogin(string login, string senha)
        {
            this.mensagem = "";

            cmd.CommandText = "select * from usuarios where dslogin = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    this.mensagem = "";
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
            this.mensagem = "";
            cmd.CommandText = "insert into usuarios (dslogin,senha,ra,registroFuncional,curso,estadoUsuario,tipoUsuario) values (@login,@senha,@ra,@registro,@curso,@estado,@tipo)";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@ra", ra);
            cmd.Parameters.AddWithValue("@registro", registro);
            cmd.Parameters.AddWithValue("@curso", curso);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@tipo", tipo);
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
    }
}
