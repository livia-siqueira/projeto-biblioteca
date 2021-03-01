using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_biblioteca_LiviaSiqueira
{
    public class GerenciamentoLivro
    {
        public Livro[] livrinhos;
        public int qLivros;
        //public int qExemplares

        public GerenciamentoLivro()
        {
            this.livrinhos = new Livro[1000];
            this.qLivros = 0;
        }

        public void AdicionarLivro(Livro info)
        {
            livrinhos[qLivros] = info;
            qLivros++;
        }
        public int VerificaLivro(string cod)
        {
            for (int i = 0; i < qLivros; i++)
            {
                if (livrinhos[i].RetornaCOD() == cod)
                {
                    return 1;
                }
            }
            return -1;
        }
        public Livro PesquisaLivro(string cod)
        {
            for (int i = 0; i < qLivros; i++)
            {
                if (cod == livrinhos[i].RetornaCOD())
                {
                    return livrinhos[i];
                }
            }
            return null;
        }
        public Livro RetornaLivros()
        {
            return livrinhos[qLivros];
        }
        public void AlteraTitulo(string tit, string cod)
        {
            for (int i = 0; i < qLivros; i++)
            {
                if (livrinhos[i].RetornaCOD() == cod)
                {

                    livrinhos[i].Titulo = tit;
                }
            }
        }
        public void AlteraAutor(string autor, string cod)
        {
            for (int i = 0; i < qLivros; i++)
            {
                if (livrinhos[i].RetornaCOD() == cod)
                {
                    livrinhos[i].Autor = autor;
                }
            }
        }
        public void AlteraNPaginas(string npag, string cod)
        {
            for (int i = 0; i < qLivros; i++)
            {
                if (livrinhos[i].RetornaCOD() == cod)
                {
                    livrinhos[i].Paginas = npag;
                }
            }
        }
        public void AlterarExemplares(int exe, string cod)
        {
            for (int i = 0; i < qLivros; i++)
            {
                if (livrinhos[i].RetornaCOD() == cod)
                {
                    livrinhos[i].Exemplares = exe;
                }
            }
        }
        public void AlteraEditora(string ed, string cod)
        {
            for (int i = 0; i < qLivros; i++)
            {
                if (livrinhos[i].RetornaCOD() == cod)
                {
                    livrinhos[i].Editora = ed;
                }
            }
        }
        public Livro[] ListarLivros()
        {
            return livrinhos;
        }
        public int RetornaLiv_Posi(string cod)
        {
            int o = 0;
            for (int i = 0; i < qLivros; i++)
            {
                if(livrinhos[i].RetornaCOD() == cod)
                {
                    o = i;
                    return o;
                }
            }
            return 0;
        }
    }
}
