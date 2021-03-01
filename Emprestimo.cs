using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_biblioteca_LiviaSiqueira
{
    public class Emprestimo
    {
        public DateTime datadev;
        public DateTime data;
        public string nome;
        public string telefone;
        public string cod;
        public string cpf;
        public string dev { get; set; }
        public Emprestimo()
        {
        }
        public Emprestimo(string cod, string nome, string telefone, string cpf, string dev, DateTime data, DateTime datadev)
        {
            this.cod = cod;
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            this.dev = dev;
            this.data = data;
            this.datadev = datadev;

        }
        public string RetornaCpf()
        {
            return cpf;
        }
        public string RetornaNome()
        {
            return nome;
        }
        public string RetornaTelefone()
        {
            return telefone;
        }
        public void AlterarDevolucao()
        {
            this.dev = "DEVOLVIDO";
        }
        public string RetornarDev()
        {
            return dev;
        }
        public string Retornarcod()
        {
            return cod;
        }
        public DateTime RetornaData()
        {
            return data;
        }
        public DateTime RetornaDevolucao()
        {
            return datadev;
        }

    }
}
