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
            SqlDataAdapter sda = new SqlDataAdapter("select idExameTipo as [ID],dsExameTipo as [Tipo] from examesTipos", con.Conectar());
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
            catch (SqlException ex)
            {
                throw new InvalidOperationException(ex.Message + " - " + cmd.CommandText, ex);
                //this.mensagem = "Erro com Banco";
                //this.mensagem = ;
            }/*
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco";
            }*/

            return this.mensagem;
        }
        /*
        public string AtualizarExamesTipos(string dsExameTipo, string estadoExameTipo, int idExameTipo, int idExameArea)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.dsExameTipo = dsExameTipo;
            this.estadoExameTipo = estadoExameTipo;
            this.idExameTipo = idExameTipo;
            this.idExameArea = idExameArea;

            cmd.CommandText = "update examesTipos set dsExameTipo = @dsExameTipo, estadoExameTipo = @estadoExameTipo, fk_idExameArea_examesAreas = @idExameArea where idExameTipo = @idExameTipo";
            cmd.Parameters.AddWithValue("@dsExameTipo", this.dsExameTipo);
            cmd.Parameters.AddWithValue("@estadoExameTipo", this.estadoExameTipo);
            cmd.Parameters.AddWithValue("@idExameTipo", this.idExameTipo);
            cmd.Parameters.AddWithValue("@idExameArea", this.idExameArea);

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

        public void GetEditarExamesTipos(int idExameTipo)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "select dsExameTipo,estadoExameTipo, dsExameArea from examesTipos join examesAreas on examesTipos.fk_idExameArea_examesAreas=examesAreas.idExameArea where idExameTipo = @idExameTipo";

            cmd.Parameters.AddWithValue("@idExameTipo", idExameTipo);
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

        public DataTable GetPesquisaExamesTipos(int idExameTipo, string dsExameTipo)
        {
            Conexao con = new Conexao();

            string strSQL = "";
            SqlDataAdapter sda;


            if (idExameArea > 0)
            {
                strSQL = "select idExameTipo as [ID],dsExameTipo as [Tipo do Exame],estadoExameTipo as [Status],dsExameArea as [Area da Biomedicina] from examesTipos join examesAreas on examesTipos.fk_idExameArea_examesAreas = examesAreas.idExameArea where idExameTipo = @idExameTipo";
                sda = new SqlDataAdapter(strSQL, con.Conectar());
                sda.SelectCommand.Parameters.AddWithValue("@idExameTipo", idExameTipo);
            }
            else
            {
                strSQL = "select idExameTipo as [ID],dsExameTipo as [Tipo do Exame],estadoExameTipo as [Status],dsExameArea as [Area da Biomedicina] from examesTipos join examesAreas on examesTipos.fk_idExameArea_examesAreas = examesAreas.idExameArea where dsExameTipo like @dsExameTipo";
                sda = new SqlDataAdapter(strSQL, con.Conectar());
                sda.SelectCommand.Parameters.AddWithValue("@dsExameTipo", string.Format("%{0}%", dsExameTipo));
            }
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        */
    }
}
