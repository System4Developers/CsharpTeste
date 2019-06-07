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
    class dalExameResultado : Exames
    {
        public SqlDataReader dr;

        public void GetEditarExameResultado(int id)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "select valormedidoa,valormedidob,valormedidoc,dsExameParametro,dsExameTipo " +
                "from ExamesResultados " +
                "join examesParametros on ExamesResultados.fk_idExameParametro_examesParametros = examesParametros.idExameParametro " +
                "join examesTipos on examesParametros.fk_idExameTipo_examesTipos = examesTipos.idExameTipo " +
                "where idExameResultado = @idExameResultado";
            cmd.Parameters.AddWithValue("@idExameResultado", id);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw new InvalidOperationException(ex.Message + " - " + cmd.CommandText, ex);
                //this.mensagem = "Erro com Banco";
                //this.mensagem = ;
            }
        }
    }
}
