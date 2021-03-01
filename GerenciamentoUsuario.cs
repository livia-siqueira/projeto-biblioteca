using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_biblioteca_LiviaSiqueira
{
    public class GerenciamentoUsuario
    {
        public Usuarios[] users;
        public int qUsuarios { get; set; }
        public int qEmprestimos { get; set; }
        public int multa { get; set; }
        public GerenciamentoUsuario()
        {
            this.users = new Usuarios[1000];
            qUsuarios = 0;
            qEmprestimos = 0;
        }
        public void AdicionarUsuario(Usuarios user)
        {
            users[qUsuarios] = user;
            qUsuarios++;
        }
        public int VerificaUsuario(string cpf)
        {
            for (int i = 0; i < qUsuarios; i++)
            {
                Console.WriteLine(users[i].RetornaCPF());
                if (users[i].RetornaCPF() == cpf)
                {
                    return 1;
                }
            }
            return -1;
        }
        public Usuarios PesquisaUsuario(string cpf)
        {
            for (int i = 0; i < qUsuarios; i++)
            {
                if (users[i].RetornaCPF() == cpf)
                {
                    return users[i];
                }
            }
            return null;
        }
        public void AlterarNome(string nome, string cpf)
        {
            for (int i = 0; i < qUsuarios; i++)
            {
                if (users[i].RetornaCPF() == cpf)
                {
                    users[i].Nome = nome;
                }
            }
        }
        public void AlterarEmail(string email, string cpf)
        {
            for (int i = 0; i < qUsuarios; i++)
            {
                if (users[i].RetornaCPF() == cpf)
                {
                    users[i].Email = email;
                }
            }
        }
        public void AlterarTelefone(string tel, string cpf)
        {
            for (int i = 0; i < qUsuarios; i++)
            {
                if (users[i].RetornaCPF() == cpf)
                {
                    users[i].Telefone = tel;
                }
            }
        }
        public void AlterarFuncao(string func, string cpf)
        {
            for (int i = 0; i < qUsuarios; i++)
            {
                if (users[i].RetornaCPF() == cpf)
                {
                    users[i].Funcao = func;
                }
            }
        }
        public Usuarios[] ListaUsuarios()
        {
            return users;
        }
        public int RetornarUser_Posi(string cpf)
        {
            int o = 0;
            for (int i = 0; i < qUsuarios; i++)
            {
                if(users[i].RetornaCPF() == cpf)
                {
                    o = i;
                    return o;
                }
            }
            return 0;
        }
     
    }
}
