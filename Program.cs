using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_biblioteca_LiviaSiqueira
{
    static class Program
    {
        public static GerenciamentoLivro g1 = new GerenciamentoLivro();
        public static GerenciamentoUsuario g2 = new GerenciamentoUsuario();
        public static GerenciamentoEmprestimo g3 = new GerenciamentoEmprestimo();
        public static int escolha;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormEntrada());
        }
    }
}
