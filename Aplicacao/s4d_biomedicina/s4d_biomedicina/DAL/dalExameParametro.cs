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
    public class dalExameParametro :  Exames
    {
        public SqlDataReader dr;
        public DataTable dt;

        public void GetExameTipoCombo()
        {
            
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select idExameTipo as [ID],dsExameTipo as [Tipo] from examesTipos where estadoExameTipo = 'Habilitado'", con.Conectar());
            this.dt = new DataTable();
            sda.Fill(dt);
         }

        public DataTable GetListaExamesParametros()
        {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select idExameParametro as [ID],dsExameTipo as [Tipo],dsExameParametro as [Parametro],valorMin as [Limite Min], valorMax as [Limite Max] from examesParametros join examesTipos on examesParametros.fk_idExameTipo_examesTipos = examesTipos.idExameTipo", con.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public string AdicionarExamesParametros(string dsExameParametro, double valorMax, double valorMin, int idExameTipo)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.dsExameParametro = dsExameParametro;
            this.valorMax = valorMax;
            this.valorMin = valorMin;
            this.idExameTipo = idExameTipo;

            cmd.CommandText = "insert into examesParametros (dsExameParametro,valorMax,valorMin,fk_idExameTipo_examesTipos) values (@dsExameParametro,@valorMax,@valorMin,@idExameTipo)";
            cmd.Parameters.AddWithValue("@dsExameParametro", this.dsExameParametro);
            cmd.Parameters.AddWithValue("@valorMax", this.valorMax);
            cmd.Parameters.AddWithValue("@valorMin", this.valorMin);
            cmd.Parameters.AddWithValue("@idExameTipo", this.idExameTipo);

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


        public void GetEditarExamesParametros(int idExameParametro)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "select idExameParametro,dsExameParametro,valorMax,valorMin,dsExameTipo from examesParametros join examesTipos on examesParametros.fk_idExameTipo_examesTipos = examesTipos.idExameTipo where idExameParametro = @idExameParametro";
            cmd.Parameters.AddWithValue("@idExameParametro", idExameParametro);

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

        
        public string AtualizarExamesParametros(string dsExameParametro, double valorMax, double valorMin, int idExameTipo,int idExameParametro)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.dsExameParametro = dsExameParametro;
            this.valorMax = valorMax;
            this.valorMin = valorMin;
            this.idExameTipo = idExameTipo;
            this.idExameParametro = idExameParametro;

            cmd.CommandText = "update examesParametros set dsExameParametro = @dsExameParametro, valorMax = @valorMax, valorMin = @valorMin,fk_idExameTipo_examesTipos = @idExameTipo where idExameParametro = @idExameParametro";
            cmd.Parameters.AddWithValue("@dsExameParametro", this.dsExameParametro);
            cmd.Parameters.AddWithValue("@valorMax", this.valorMax);
            cmd.Parameters.AddWithValue("@valorMin", this.valorMin);
            cmd.Parameters.AddWithValue("@idExameTipo", this.idExameTipo);
            cmd.Parameters.AddWithValue("@idExameParametro", this.idExameParametro);

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


       
        public DataTable GetPesquisaExamesParametros(int idExameParametro, string dsExameParametro)
        {
            Conexao con = new Conexao();

            string strSQL = "";
            SqlDataAdapter sda;


            if (idExameParametro > 0)
            {

                strSQL = "select idExameParametro as [ID],dsExameTipo as [Tipo],dsExameParametro as [Parametro],valorMin as [Limite Min], valorMax as [Limite Max] from examesParametros join examesTipos on examesParametros.fk_idExameTipo_examesTipos = examesTipos.idExameTipo where idExameParametro = @idExameParametro";
                sda = new SqlDataAdapter(strSQL, con.Conectar());

                sda.SelectCommand.Parameters.AddWithValue("@idExameParametro", idExameParametro);
            }
            else
            {
                strSQL = "select idExameParametro as [ID],dsExameTipo as [Tipo],dsExameParametro as [Parametro],valorMin as [Limite Min], valorMax as [Limite Max] from examesParametros join examesTipos on examesParametros.fk_idExameTipo_examesTipos = examesTipos.idExameTipo where dsExameParametro like @dsExameParametro";
                sda = new SqlDataAdapter(strSQL, con.Conectar());
                sda.SelectCommand.Parameters.AddWithValue("@dsExameParametro", string.Format("%{0}%", dsExameParametro));
            }
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
      
    }
}
