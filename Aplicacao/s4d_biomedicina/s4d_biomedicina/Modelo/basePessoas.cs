using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4d_biomedicina.Modelo
{
    public abstract class basePessoas
    {
        protected Int32 idPessoa;
        protected String nome;
        protected String rg;
        protected String cpf;
        protected String dtNascimento;
        protected String profissao;
        protected String grauInstrucao;
        protected String logradouro;
        protected String bairro;
        protected String numero;
        protected String cidade;
        protected String estado;

        protected string mensagem;

        public override string ToString()
        {
            return this.mensagem;
        }
    }
}
