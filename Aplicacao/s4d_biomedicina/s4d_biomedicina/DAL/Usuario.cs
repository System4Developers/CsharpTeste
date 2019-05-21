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

            }
            catch (SqlException)
            {

                this.mensagem = "Erro com banco de Dados";
            }

            return this.mensagem;
        }
    }
}
