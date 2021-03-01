using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_biblioteca_LiviaSiqueira
{
    public class Usuarios
    {
        public string CPF { get; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Funcao { get; set; }
        public Usuarios()
        {

        }
        public Usuarios(string CPF, string Nome, string Telefone, string Email, string Funcao)
        {
            this.CPF = CPF;
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
            this.Funcao = Funcao;
        }
        public string RetornaCPF()
        {
            return CPF;
        }
        public string RetornaNome()
        {
            return Nome;
        }
        public string RetornaFuncao()
        {
            return Funcao;
        }
        public string RetornaEmail()
        {
            return Email;
        }
        public string RetornaTelefone()
        {
            return Telefone;
        }
    }
}
