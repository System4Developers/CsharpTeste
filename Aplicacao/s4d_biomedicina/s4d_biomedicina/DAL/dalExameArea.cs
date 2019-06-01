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
    public class dalExameArea : ExamesAreas
    {
       

        public DataTable GetListaExamesAreas()
        {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select idExameArea as [ID],dsExameArea as [Descricao] from examesAreas", con.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

      
        

    }
}
