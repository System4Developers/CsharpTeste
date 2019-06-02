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
    public class dalExameTipo : ExamesAreas
    {
        public SqlDataReader dr;

        public DataTable GetListaExamesTipos()
        {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select * from examesTipos", con.Conectar());
            DataTable dt = new DataTable();
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

        public string AtualizarExamesTipos(string dsExameArea, int idExameArea)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.dsExameArea = dsExameArea;
            this.idExameArea = idExameArea;


            cmd.CommandText = "update examesTipos set dsExameArea = @dsExameArea where idExameArea = @idExameArea";
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

            cmd.CommandText = "select * from examesTipos where idExameArea = @idExameArea";

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

        public DataTable GetPesquisaExamesTipos(int idExameTipo, string dsExameTipo)
        {
            Conexao con = new Conexao();

            string strSQL = "";
            SqlDataAdapter sda;

            if (idExameArea > 0)
            {
                strSQL = "select * from examesTipos where idExameTipo = @idExameTipo";
                sda = new SqlDataAdapter(strSQL, con.Conectar());
                sda.SelectCommand.Parameters.AddWithValue("@idExameArea", idExameArea);
            }
            else
            {
                strSQL = "select * from examesTipos where dsExameTipo like @dsExameTipo";
                sda = new SqlDataAdapter(strSQL, con.Conectar());
                sda.SelectCommand.Parameters.AddWithValue("@dsExameTipo", string.Format("%{0}%", dsExameTipo));
            }
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }



    }
}
