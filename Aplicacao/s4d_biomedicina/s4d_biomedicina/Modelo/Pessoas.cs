using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4d_biomedicina.Modelo
{
    public abstract class Pessoas
    {
        protected Int32 idPessoa;
        protected String nome;
        protected String rg;
        protected String cpf;
        protected String dtNascimento;
        protected String profissao;
        protected String grauInstrucao;
        protected String Cep;
        protected String Rua;
        protected String Numero;
        protected String Complemento;
        protected String Bairro;
        protected String Estado;
        protected String Cidade;

        protected string mensagem;

        public override string ToString()
        {
            return this.mensagem;
        }
    }
}
