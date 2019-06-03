using s4d_biomedicina.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4d_biomedicina.DAL
{
    public class dalExameTipo : Exames
    {
        public SqlDataReader dr;
        public DataTable dt;

        public void GetExameAreaCombo()
        {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select idExameArea as [ID], dsExameArea as [dsArea] from examesAreas", con.Conectar());
            this.dt = new DataTable();
            sda.Fill(this.dt);
        }

        public DataTable GetListaExamesTipos()
        {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select idExameTipo as [ID],dsExameTipo as [Tipo do Exame],estadoExameTipo as [Status], dsExameArea as [Area da Biomedicina] from examesTipos join examesAreas on examesTipos.fk_idExameArea_examesAreas = examesAreas.idExameArea", con.Conectar());
            this.dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public string AdicionarExameTipo(string dsExameTipo, string estadoExameTipo, int idExameArea)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.dsExameTipo = dsExameTipo;
            this.estadoExameTipo = estadoExameTipo;
            this.idExameArea = idExameArea;


            cmd.CommandText = "insert into examesTipos (dsExameTipo,estadoExameTipo,fk_idExameArea_examesAreas) values (@dsExameTipo,@estadoExameTipo,@idExameArea)";
            cmd.Parameters.AddWithValue("@dsExameTipo", this.dsExameTipo);
            cmd.Parameters.AddWithValue("@estadoExameTipo", this.estadoExameTipo);
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

        public string AtualizarExamesTipos(string dsExameTipo, string estadoExameTipo, int idExameTipo,int idExameArea)
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



    }
}
