using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_biblioteca_LiviaSiqueira
{
    public class GerenciamentoEmprestimo
    {
        public Emprestimo[] controle { get; set; }
        public int cont_emp { get; set; }
        private string[] livemprestados;
        public int cont_LivrosEmprestados { get; set; }
        private string[] livdev;
        //public int cont_LivrosDevolvidos {get;set;}


        public GerenciamentoEmprestimo()
        {
            this.controle = new Emprestimo[1000];
            this.cont_emp = 0;
            this.livemprestados = new string[1000];
            this.livdev = new string[1000];
            this.cont_LivrosEmprestados = 0;

        }
        public void AdicionarEmprestismo(Emprestimo info)
        {
            controle[cont_emp] = info;
            cont_emp++;

        }
        public Emprestimo RetornarEmprestimo(string cpf)
        {
            for (int i = 0; i < cont_emp; i++)
            {
                if ((controle[i].RetornaCpf() == cpf) && (controle[i].RetornarDev() != "DEVOLVIDO"))
                {
                    return controle[i];
                }
            }
            return null;
        }
        public Emprestimo RetornarEmpCod_Livro(string COD)
        {
            for (int i = 0; i < cont_emp; i++)
            {
                if(controle[i].Retornarcod() == COD)
                {
                    return controle[i];
                }
            }
            return null;
        }
      
        
        public Emprestimo[] ListarEmprestimos()
        {
            return controle;
        }
        public int Quantidade()
        {
            return cont_emp;
        }
        
        public void LivrosEmprestados(string cod)
        {
            livemprestados[cont_LivrosEmprestados] = cod;
            cont_LivrosEmprestados++;
        }
        public int VerificarLivroEmp(string cod)
        {
            if (controle.Length > 0)
            {
                for (int i = 0; i < cont_emp; i++)
                {
                    if ((controle[i].Retornarcod() == cod))
                    {
                        return 1;
                    }
                }
            }
            else
            {
                return 2;
            }
            return 0;
        }
        public int RetornarEmp_Posi(string cpf)
        {
            int o = 0;
            for (int i = 0; i < cont_emp; i++)
            {
                if(controle[i].RetornaCpf() == cpf)
                {
                    o = i;
                    return o;
                }
            }
            return 0;
        }
        public int VerificaDevNec(string cod)
        {
            int i = 0;
            do
            {
                if(controle[i].Retornarcod() == cod)
                {
                    if(controle[i].RetornarDev() == "EMPRESTADO")
                    {
                        return 1;
                    }
                }
                i++;
            } while (i < cont_emp);
            return 0;
        }
        public int VerificaDevol(string cod)
        {
            if (cont_emp > 0)
            {
                for (int i = 0; i < cont_emp; i++)
                {
                    if (controle[i].Retornarcod() == cod)
                    {
                        if (controle[i].RetornarDev() == "DEVOLVIDO")
                        {
                            return 1;
                        }
                    }
                }
            }
            return 0;
        }
        public int RetornaqEmpUser(string cpf)
        {
            int i = 0;
            int qEmp_user = 0;
            while (i < cont_emp)
            {
                if(controle[i].RetornaCpf() == cpf && controle[i].RetornarDev() == "EMPRESTADO")
                {
                    qEmp_user++;
                }
                i++;
            }
            return qEmp_user;
        }
    }
}
