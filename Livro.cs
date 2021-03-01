using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_biblioteca_LiviaSiqueira
{
    public class Livro
    {
        public string COD { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Paginas { get; set; }
        public string ISSN { get; set; }
        public int Exemplares { get; set; }
        public string Editora { get; set; }

        public Livro()
        {

        }
        public Livro(string COD, string Titulo, string Autor, string Paginas, string ISSN, int Exemplares, string Editora)
        {
            this.COD = COD;
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Paginas = Paginas;
            this.ISSN = ISSN;
            this.Exemplares = Exemplares;
            this.Editora = Editora;
        }
        public string RetornaIssn()
        {
            return ISSN;
        }
        public string RetornaTitulo()
        {
            return Titulo;
        }
        public string RetornaAutor()
        {
            return Autor;
        }
        public string RetornaPaginas()
        {
            return Paginas;
        }
        public string RetornaEditora()
        {
            return Editora;
        }
        public int RetornaExemplares()
        {
            return Exemplares;
        }
        public string RetornaCOD()
        {
            return COD;
        }

    }
}
