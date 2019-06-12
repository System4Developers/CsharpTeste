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

            cmd.CommandText = "select valormedidoa,valormedidob,valormedidoc,dsExameParametro,dsExameTipo,idExameAgendado " +
                "from ExamesResultados " +
                "join examesParametros on ExamesResultados.fk_idExameParametro_examesParametros = examesParametros.idExameParametro " +
                "join examesTipos on examesParametros.fk_idExameTipo_examesTipos = examesTipos.idExameTipo " +
                "join examesAgendados on ExamesResultados.fk_idExameAgendado_examesAgendados = examesAgendados.idExameAgendado " +
                "where idExameResultado = @idExameResultado";
            cmd.Parameters.AddWithValue("@idExameResultado", id);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco";
            }
        }
        
        public string AtualizarExameResultado(int idExameResultado,double valor1,double valor2, double valor3)
        {
            this.mensagem = "";
            this.idExameResultado = idExameResultado;
            this.valorMedidoA = valor1;
            this.valorMedidoB = valor2;
            this.valorMedidoC = valor3;


            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "update ExamesResultados " +
                "set valorMedidoA = @valor1, valorMedidoB = @valor2 ,valorMedidoC = @valor3 " +
                "where idExameResultado = @idExameResultado";

            cmd.Parameters.AddWithValue("@valor3", this.valorMedidoC);
            cmd.Parameters.AddWithValue("@valor2", this.valorMedidoB);
            cmd.Parameters.AddWithValue("@valor1", this.valorMedidoA);
            cmd.Parameters.AddWithValue("@idExameResultado", this.idExameResultado);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
            }
            catch (SqlException ex )
            {
               this.mensagem = "Erro com Banco";
            }
            return this.mensagem;
        }
       
    }
}
