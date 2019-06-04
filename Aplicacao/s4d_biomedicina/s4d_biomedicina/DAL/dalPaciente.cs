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
            SqlDataAdapter sda = new SqlDataAdapter("select idPaciente as [ID], nome as [NOME], rg as [RG],cpf as [CPF], dtNascimento as [NASCIMENTO], prontuario as [PRONTUARIO], profissao as [PROFISSAO],logradouro as [ENDERECO],bairro as [BAIRRO],cidade as [CIDADE] ,estado as [ESTADO] from pacientes join pessoas on pacientes.fk_idPessoa_pessoas = pessoas.idPessoa left join enderecos on pessoas.idPessoa = enderecos.fk_idPessoa_pessoas", con.Conectar());
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
            SqlDataAdapter sda = new SqlDataAdapter("select idPaciente as [ID], nome as [NOME], rg as [RG],cpf as [CPF], dtNascimento as [NASCIMENTO], prontuario as [PRONTUARIO], profissao as [PROFISSAO],logradouro as [ENDERECO],bairro as [BAIRRO],cidade as [CIDADE] ,estado as [ESTADO] from pacientes join pessoas on pacientes.fk_idPessoa_pessoas = pessoas.idPessoa left join enderecos on pessoas.idPessoa = enderecos.fk_idPessoa_pessoas", con.Conectar());
            sda.SelectCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable GetListaPacienteAgendamentos(int idPaciente)
        {
            Conexao con = new Conexao();
            SqlDataAdapter sda = new SqlDataAdapter("select idPaciente as [ID], nome as [NOME], rg as [RG],cpf as [CPF], dtNascimento as [NASCIMENTO], prontuario as [PRONTUARIO], profissao as [PROFISSAO],logradouro as [ENDERECO],bairro as [BAIRRO],cidade as [CIDADE] ,estado as [ESTADO] from pacientes join pessoas on pacientes.fk_idPessoa_pessoas = pessoas.idPessoa left join enderecos on pessoas.idPessoa = enderecos.fk_idPessoa_pessoas", con.Conectar());
            sda.SelectCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public string AdicionarPaciente(string nome, string rg, string cpf, string dtNascimento, string profissao, string grauInstrucao, string prontuario, double peso,double altura,string grupoSanguineo,string estadoPaciente, string logradouro, string bairro, string numero, string cidade, string estado)
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
                "values (@prontuario,@peso,@altura,@grupoSanguineo,@idPessoa,@estadoPaciente)" +
                "insert into enderecos (logradouro,bairro,numero,cidade,estado,fk_idPessoa_pessoas) " +
                "values (@logradouro,@bairro,@numero,@cidade,@estado,@idPessoa)"; 
                
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
            catch (SqlException ex)
            {
                throw new InvalidOperationException(ex.Message + " - " + cmd.CommandText, ex);
                //this.mensagem = "Erro com Banco";
                //this.mensagem = ;
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

        public void GetEditarPaciente(int idPaciente)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "select prontuario,nome,rg,cpf,dtNascimento,grauInstrucao,profissao,estadoPaciente,cidade,estado,logradouro,bairro,numero,peso,altura,grupoSanguineo,idPessoa " +
            "from pacientes " +
            "join pessoas on pacientes.fk_idPessoa_pessoas = pessoas.idPessoa " +
            "left join enderecos on pessoas.idPessoa = enderecos.fk_idPessoa_pessoas " +
            "where idPaciente = @idPaciente";
         
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
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

        public string AtualizarPaciente(string nome, string rg, string cpf, string dtNascimento, string profissao, string grauInstrucao, string prontuario, double peso, double altura, string grupoSanguineo, string estadoPaciente, string logradouro, string bairro, string numero, string cidade, string estado,int idPaciente)
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


            
            cmd.CommandText = "select fk_idPessoa_pessoas from pacientes where idPaciente = @idPaciente";
            cmd.Parameters.AddWithValue("@idPaciente", this.idPaciente);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.idPessoa = Convert.ToInt32(dr["fk_idPessoa_pessoas"]);
                }
                dr.Close();
            }
            catch (SqlException)
            {
                return this.mensagem;
            }

            cmd.Parameters.Clear();
            cmd.CommandText = "update pacientes " +
                "set prontuario = @prontuario,peso=@peso,altura=@altura,grupoSanguineo=@grupoSanguineo,estadoPaciente=@estadoPaciente " +
                "where idPaciente= @idPaciente";
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
            catch (SqlException)
            {
                return this.mensagem;
            }

            cmd.Parameters.Clear();
            cmd.CommandText = "update pessoas " +
                "set nome=@nome,rg=@rg,cpf=@cpf,dtNascimento=@dtNascimento,profissao=@profissao,grauInstrucao=@grauInstrucao " +
                "where idPessoa = @idPessoa ";
            cmd.Parameters.AddWithValue("@nome", this.nome);
            cmd.Parameters.AddWithValue("@rg", this.rg);
            cmd.Parameters.AddWithValue("@cpf", this.cpf);
            cmd.Parameters.AddWithValue("@dtNascimento", this.dtNascimento);
            cmd.Parameters.AddWithValue("@grauInstrucao", this.grauInstrucao);
            cmd.Parameters.AddWithValue("@profissao", this.profissao);
            cmd.Parameters.AddWithValue("@idPessoa", this.idPessoa);

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

            cmd.Parameters.Clear();
            cmd.CommandText = "update enderecos " +
                "set cidade=@cidade,estado=@estado,logradouro=@logradouro,bairro=@bairro,numero=@numero " +
                "where fk_idPessoa_pessoas=@idPessoa";

            cmd.Parameters.AddWithValue("@idPessoa", this.idPessoa);
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
