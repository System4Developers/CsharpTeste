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
    public class dalExameArea : Exames
    {
        public SqlDataReader dr;
        public DataTable dt;

        public DataTable GetListaExamesAreas()
        {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select idExameArea as [ID],dsExameArea as [Área da Biomedicina] from examesAreas", con.Conectar());
            this.dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public string AdicionarArea(string dsExameArea)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.dsExameArea = dsExameArea;

            cmd.CommandText = "insert into examesAreas (dsExameArea) values (@dsExameArea)";
            cmd.Parameters.AddWithValue("@dsExameArea", this.dsExameArea);

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

        public string AtualizarArea(string dsExameArea, int idExameArea)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.dsExameArea = dsExameArea;
            this.idExameArea = idExameArea;
           

            cmd.CommandText = "update examesAreas set dsExameArea = @dsExameArea where idExameArea = @idExameArea";
            cmd.Parameters.AddWithValue("@idExameArea", this.idExameArea);
            cmd.Parameters.AddWithValue("@dsExameArea", this.dsExameArea);
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

        public void GetEditarArea(int idExameArea)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "select * from examesAreas where idExameArea = @idExameArea";

            cmd.Parameters.AddWithValue("@idExameArea", idExameArea);
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

        public DataTable GetPesquisaAreas(int idExameArea, string dsExameArea)
        {
            Conexao con = new Conexao();

            string strSQL = "";
            SqlDataAdapter sda;

            if (idExameArea > 0)
            {
                strSQL = "select idExameArea as [ID],dsExameArea as [Área da Biomedicina] from examesAreas where idExameArea = @idExameArea";
                sda = new SqlDataAdapter(strSQL, con.Conectar());
                sda.SelectCommand.Parameters.AddWithValue("@idExameArea", idExameArea);
            }
            else
            {
                strSQL = "select idExameArea as [ID],dsExameArea as [Área da Biomedicina] from examesAreas where dsExameArea like @dsExameArea";
                sda = new SqlDataAdapter(strSQL, con.Conectar());
                sda.SelectCommand.Parameters.AddWithValue("@dsExameArea", string.Format("%{0}%", dsExameArea));
            }
            this.dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

    }
}
