using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace s4d_biomedicina.DAL
{
    public class dalAgendamentos : Modelo.Agendamentos
    {
        public SqlDataReader dr;

        public string AdicionarPacienteAgendamento(string Data, string Horario, string Status, int id,string solicitante)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            int idUsuario;
            idUsuario = Modelo.Estaticos.idUsuario;
            this.mensagem = "";
            this.Data = Data;
            this.Horario = Horario;
            this.Status = Status;
            this.idPaciente = id;
            this.Solicitante = solicitante;
            string dtConsulta = this.Data + " " + this.Horario;

            cmd.CommandText = "insert into consultas (dtConsulta, solicitante, estadoConsulta,fk_idUsuario_usuarios,fk_idPaciente_pacientes) values (@dtConsulta," +
                "@Solicitante,@Status,@idUsuario,@idPaciente)";

            cmd.Parameters.AddWithValue("@dtConsulta", this.Data);
            cmd.Parameters.AddWithValue("@Solicitante", this.Solicitante);
            cmd.Parameters.AddWithValue("@Status", this.Status);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@idPaciente", this.idPaciente);

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
            }
            return this.mensagem;
        }

        public DataTable GetListaPacienteAgendamentos(int idPaciente)
            {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select * from consultas join pacientes on pacientes.idPaciente = consultas.fk_idPaciente_pacientes where pacientes.idPaciente=@idPaciente", con.Conectar());
            sda.SelectCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
            }

    }
}
