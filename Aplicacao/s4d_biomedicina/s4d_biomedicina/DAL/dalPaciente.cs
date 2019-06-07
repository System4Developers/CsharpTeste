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
    public class dalPaciente : Pacientes
    {

        public SqlDataReader dr;

        public DataTable GetListaPacientes()
        {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select idPaciente as [ID], nome as [NOME], rg as [RG],cpf as [CPF], dtNascimento as [NASCIMENTO], prontuario as [PRONTUARIO], profissao as [PROFISSAO] from pacientes join pessoas on pacientes.fk_idPessoa_pessoas = pessoas.idPessoa", con.Conectar());
             DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable GetListaPacienteEnderecos(int idPaciente)
        {
            Conexao con = new Conexao();

            SqlDataAdapter sda = new SqlDataAdapter("select idEndereco as [ID],logradouro as [Logradouro], bairro as [Bairro],numero as [Numero],cidade as [Cidade],estado as [Estado] from enderecos join pessoas on enderecos.fk_idPessoa_pessoas=pessoas.idPessoa join pacientes on pessoas.idPessoa = pacientes.fk_idPessoa_pessoas where idPaciente = @idPaciente", con.Conectar());
            sda.SelectCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable GetListaPacienteExames(int idPaciente)
        {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select idExameAgendado as [ID],dsExameTipo as [Exame],estadoExame as [Status],dtExame as [Data do Exame],solicitante as [Solicitante],valorMedidoA as [Resultado 1],valorMedidoB as [Resultado 2],valorMedidoC as [Resultado 3],valorMin as [Valor Min.],valorMax as [Valor Max.],idExameParametro,idExameTipo,idExameResultado " +
             "from examesAgendados " +
             "join pacientes on examesAgendados.fk_idPaciente_pacientes = pacientes.idPaciente " +
             "join consultas on examesAgendados.fk_idConsulta_consultas = consultas.idConsulta " +
             "join ExamesResultados on examesAgendados.idExameAgendado = ExamesResultados.fk_idExameAgendado_examesAgendados " +
             "join examesParametros on ExamesResultados.fk_idExameParametro_examesParametros = examesParametros.idExameParametro " +
             "join examesTipos on examesParametros.fk_idExameTipo_examesTipos = examesTipos.idExameTipo " +
             "where idPaciente = @idPaciente", con.Conectar());
            sda.SelectCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public string AdicionarPaciente(string nome, string rg, string cpf, string dtNascimento, string profissao, string grauInstrucao, string prontuario, double peso,double altura,string grupoSanguineo,string estadoPaciente)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
            this.dtNascimento = dtNascimento;
            this.profissao = profissao;
            this.grauInstrucao = grauInstrucao;
            this.prontuario = prontuario;
            this.peso = peso;
            this.altura = altura;
            this.grupoSanguineo = grupoSanguineo;
            this.estadoPaciente = estadoPaciente;

            cmd.CommandText = "insert into pessoas (nome,rg,cpf,dtNascimento,profissao,grauInstrucao) " +
                "values (@nome,@rg,@cpf,@dtNascimento,@profissao,@grauInstrucao) " +
                "declare @idPessoa int = @@identity " +
                "insert into pacientes (prontuario,peso,altura,grupoSanguineo,fk_idPessoa_pessoas,estadoPaciente) " +
                "values (@prontuario,@peso,@altura,@grupoSanguineo,@idPessoa,@estadoPaciente)";
                
            cmd.Parameters.AddWithValue("@nome", this.nome);
            cmd.Parameters.AddWithValue("@rg", this.rg);
            cmd.Parameters.AddWithValue("@cpf", this.cpf);
            cmd.Parameters.AddWithValue("@dtNascimento", this.dtNascimento);
            cmd.Parameters.AddWithValue("@profissao", this.profissao);
            cmd.Parameters.AddWithValue("@grauInstrucao", this.grauInstrucao);

            cmd.Parameters.AddWithValue("@prontuario", this.prontuario);
            cmd.Parameters.AddWithValue("@peso", this.peso);
            cmd.Parameters.AddWithValue("@altura", this.altura);
            cmd.Parameters.AddWithValue("@grupoSanguineo", this.grupoSanguineo);
            cmd.Parameters.AddWithValue("@estadoPaciente", this.estadoPaciente);

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

        public string AdicionarPacienteEndereco(string Cep, string Rua, string Numero, string Complemento, string Bairro, string Estado, string Cidade, int idPaciente)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.Cep = Cep;
            this.Rua = Rua;
            this.Numero = Numero;
            this.Complemento = Complemento;
            this.Bairro = Bairro;
            this.Estado = Estado;
            this.Cidade = Cidade;
            this.idPaciente = idPaciente;
           

            cmd.CommandText = "declare @id int select @id = idPessoa from pessoas join pacientes on pacientes.fk_idPessoa_pessoas = pessoas.idPessoa where idPaciente = @idPaciente " +
                "insert into enderecos (logradouro, bairro, numero, cidade,estado,fk_idPessoa_pessoas,cep,complemento) values (@rua,@bairro,@numero,@cidade,@estado,@id,@cep,@complemento) ";

            cmd.Parameters.AddWithValue("@rua", this.Rua);
            cmd.Parameters.AddWithValue("@bairro", this.Bairro);
            cmd.Parameters.AddWithValue("@numero", this.Numero);
            cmd.Parameters.AddWithValue("@cidade", this.Cidade);
            cmd.Parameters.AddWithValue("@estado", this.Estado);
            cmd.Parameters.AddWithValue("@idPaciente", this.idPaciente);
            cmd.Parameters.AddWithValue("@cep", this.Cep);
            cmd.Parameters.AddWithValue("@complemento", this.Complemento);

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


        public string ConsultaCpfPaciente(string cpf)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "select idPaciente from pacientes join pessoas on pessoas.idPessoa = pacientes.fk_idPessoa_pessoas where pessoas.cpf = @cpf";

            this.mensagem = "";
            this.cpf = cpf;
            cmd.Parameters.AddWithValue("@cpf", this.cpf);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco";
            }
            return this.mensagem;
        }

        public void GetPacienteDadosCadastrais(int idPaciente)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "select prontuario,peso,altura,grupoSanguineo,estadoPaciente,nome,rg,cpf,dtNascimento,profissao,grauInstrucao " +
            "from pacientes " +
            "join pessoas on pacientes.fk_idPessoa_pessoas = pessoas.idPessoa " +
            "where idPaciente = @idPaciente";
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

            try
            {
                cmd.Connection = con.Conectar();
                this.dr = cmd.ExecuteReader();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco!";
            }
        }

        public void GetEditarPacienteEnderecos(int idEnderecos)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "select idEndereco as [ID],logradouro as [Logradouro], bairro as [Bairro],numero as [Numero],cidade as [Cidade],estado as [Estado] from enderecos where idEndereco = @idEndereco";

            cmd.Parameters.AddWithValue("@idEndereco", idEnderecos);
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

        public string AtualizarPaciente(string nome, string rg, string cpf, string dtNascimento, string profissao, string grauInstrucao, string prontuario, double peso, double altura, string grupoSanguineo, string estadoPaciente,int idPaciente)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
            this.dtNascimento = dtNascimento;
            this.profissao = profissao;
            this.grauInstrucao = grauInstrucao;
            this.prontuario = prontuario;
            this.peso = peso;
            this.altura = altura;
            this.grupoSanguineo = grupoSanguineo;
            this.estadoPaciente = estadoPaciente;
            this.idPaciente = idPaciente;

            cmd.CommandText = "declare @TempId int " +
                "select @TempId = idPessoa from pessoas join pacientes on pessoas.idPessoa = pacientes.fk_idPessoa_pessoas where idPaciente = @idPaciente " +
                "update pessoas " +
                "set nome=@nome,rg=@rg,cpf=@cpf,dtNascimento=@dtNascimento,profissao=@profissao,grauInstrucao=@grauInstrucao " +
                "where idPessoa = @TempId " +
                "update pacientes " +
                "set prontuario = @prontuario,peso=@peso,altura=@altura,grupoSanguineo=@grupoSanguineo,estadoPaciente=@estadoPaciente " +
                "where idPaciente= @idPaciente";

            cmd.Parameters.AddWithValue("@nome", this.nome);
            cmd.Parameters.AddWithValue("@rg", this.rg);
            cmd.Parameters.AddWithValue("@cpf", this.cpf);
            cmd.Parameters.AddWithValue("@dtNascimento", this.dtNascimento);
            cmd.Parameters.AddWithValue("@grauInstrucao", this.grauInstrucao);
            cmd.Parameters.AddWithValue("@profissao", this.profissao);
            cmd.Parameters.AddWithValue("@idPessoa", this.idPessoa);
            cmd.Parameters.AddWithValue("@prontuario", this.prontuario);
            cmd.Parameters.AddWithValue("@peso", this.peso);
            cmd.Parameters.AddWithValue("@altura", this.altura);
            cmd.Parameters.AddWithValue("@grupoSanguineo", this.grupoSanguineo);
            cmd.Parameters.AddWithValue("@estadoPaciente", this.estadoPaciente);
            cmd.Parameters.AddWithValue("@idPaciente", this.idPaciente);

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


        public string AtualizarPacienteEndereco(string Cep, string Rua, string Numero, string Complemento, string Bairro, string Estado, string Cidade, int idEndereco)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            this.mensagem = "";
            this.mensagem = "";
            this.Cep = Cep;
            this.Rua = Rua;
            this.Numero = Numero;
            this.Complemento = Complemento;
            this.Bairro = Bairro;
            this.Estado = Estado;
            this.Cidade = Cidade;
            this.idEndereco = idEndereco;


            cmd.CommandText = "update enderecos set logradouro = @rua, cep=@cep,bairro=@bairro, numero = @numero, complemento = @complemento,cidade=@cidade, estado=@estado where idEndereco = @idEndereco";
            cmd.Parameters.AddWithValue("@idEndereco", this.idEndereco);
            cmd.Parameters.AddWithValue("@bairro", this.Bairro);
            cmd.Parameters.AddWithValue("@estado", this.Estado);
            cmd.Parameters.AddWithValue("@cidade", this.Cidade);
            cmd.Parameters.AddWithValue("@complemento", this.Complemento);
            cmd.Parameters.AddWithValue("@numero", this.Numero);
            cmd.Parameters.AddWithValue("@rua", this.Rua);
            cmd.Parameters.AddWithValue("@cep", this.Cep);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
            }
            catch (SqlException)
            {
                return this.mensagem;
            }

            return this.mensagem;
        }
        public DataTable GetPesquisaPaciente(string nome, string cpf)
        {
            Conexao con = new Conexao();
            SqlDataAdapter sda;
            string strSQL = "";
            
            if (!cpf.Equals(""))
            {
                strSQL = "select idPaciente as [ID], nome as [NOME], rg as [RG],cpf as [CPF], dtNascimento as [NASCIMENTO], prontuario as [PRONTUARIO], profissao as [PROFISSAO],logradouro as [ENDERECO],bairro as [BAIRRO],cidade as [CIDADE] ,estado as [ESTADO] from pacientes join pessoas on pacientes.fk_idPessoa_pessoas = pessoas.idPessoa left join enderecos on pessoas.idPessoa = enderecos.fk_idPessoa_pessoas where cpf = @cpf";
                sda = new SqlDataAdapter(strSQL, con.Conectar());
                sda.SelectCommand.Parameters.AddWithValue("@cpf", cpf);
            }
            else
            {
                strSQL = "select idPaciente as [ID], nome as [NOME], rg as [RG],cpf as [CPF], dtNascimento as [NASCIMENTO], prontuario as [PRONTUARIO], profissao as [PROFISSAO],logradouro as [ENDERECO],bairro as [BAIRRO],cidade as [CIDADE] ,estado as [ESTADO] from pacientes join pessoas on pacientes.fk_idPessoa_pessoas = pessoas.idPessoa left join enderecos on pessoas.idPessoa = enderecos.fk_idPessoa_pessoas where nome like @nome";
                sda = new SqlDataAdapter(strSQL, con.Conectar());
                sda.SelectCommand.Parameters.AddWithValue("@nome", string.Format("%{0}%", nome));
            }
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        
    }
}
