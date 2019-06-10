using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace s4d_biomedicina.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
          //con.ConnectionString = @"Data Source=DESKTOP-62JOGHE\SQLEXPRESS;Initial Catalog=unipBiomedicina;Integrated Security=True"; 
            con.ConnectionString = @"Data Source=RUKANOTE\SQLEXPRESS;Initial Catalog=unipBiomedicina;User ID=sa;Password=admin01";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
