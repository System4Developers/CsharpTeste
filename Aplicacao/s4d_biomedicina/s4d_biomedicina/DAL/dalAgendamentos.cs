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

            cmd.Parameters.AddWithValue("@dtConsulta", dtConsulta);
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
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco";
            }
            return this.mensagem;
        }

        public DataTable GetListaPacienteAgendamentos(int idPaciente)
            {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select idConsulta as [ID], dtConsulta as [Data do Agendamento], solicitante as [Solicitante], estadoConsulta as [Estado do Agendamento], nome as [Criado por] from consultas join usuarios on consultas.fk_idUsuario_usuarios = usuarios.idUsuario join pacientes on consultas.fk_idPaciente_pacientes = pacientes.idPaciente join pessoas on pacientes.fk_idPessoa_pessoas = pessoas.idPessoa where idPaciente = @idPaciente", con.Conectar());
            sda.SelectCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
            }

        public void GetEditarPacienteAgendamentos(int id)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "select dtConsulta as [Data],CONVERT(VARCHAR(5),dtConsulta,114) AS hora,solicitante as [solicitante], estadoConsulta as [estadoConsulta] from consultas where idConsulta = @idConsulta";

            cmd.Parameters.AddWithValue("@idConsulta", id);
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

        public string AtualizarPacienteAgendamento(string Data, string Horario, string Status, int id, string solicitante)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            int idUsuario;
            idUsuario = Modelo.Estaticos.idUsuario;
            this.mensagem = "";
            this.Data = Data;
            this.Horario = Horario;
            this.Status = Status;
            this.idAgendamento = id;
            this.Solicitante = solicitante;
            string dtConsulta = this.Data + " " + this.Horario;

            cmd.CommandText = "update consultas " +
                "set dtConsulta=@dtConsulta,solicitante=@Solicitante,estadoConsulta=@Status,fk_idUsuario_usuarios=@idUsuario " +
                "where idConsulta = @idAgendamento ";

            cmd.Parameters.AddWithValue("@dtConsulta", dtConsulta);
            cmd.Parameters.AddWithValue("@Solicitante", this.Solicitante);
            cmd.Parameters.AddWithValue("@Status", this.Status);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@idAgendamento", this.idAgendamento);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
            }
            catch (SqlException ex)
            {
                //return this.mensagem;
                throw new InvalidOperationException(ex.Message + " - " + cmd.CommandText, ex);
            }

            return this.mensagem;

        }

        public string AdicionarExameAgendado(string estadoExame,string dtExame,int idConsulta,int idPaciente,int idExameParametro)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";

            this.estadoExame = estadoExame;
            this.dataExame = dtExame;
            this.idConsulta = idConsulta;
            this.idPaciente = idPaciente;
            this.idExameParametro = idExameParametro;

            cmd.CommandText = "insert into examesAgendados (estadoExame, dtExame, fk_idConsulta_consultas,fk_idPaciente_pacientes) " +
                "values (@estadoExame,@dtExame,@idConsulta,@idPaciente) " +
                "declare @idExAg int = @@identity " +
                "insert into ExamesResultados(valorMedidoC,valorMedidoB,valorMedidoA,fk_idExameParametro_examesParametros,fk_idExameAgendado_examesAgendados) " +
                "values (0,0,0,@idExameParametro,@idExAg)";

            cmd.Parameters.AddWithValue("@estadoExame", this.estadoExame);
            cmd.Parameters.AddWithValue("@dtExame", this.dataExame);
            cmd.Parameters.AddWithValue("@idConsulta", this.idConsulta);
            cmd.Parameters.AddWithValue("@idExameParametro", idExameParametro);
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

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
    }
}
