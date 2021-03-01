using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_biblioteca_LiviaSiqueira
{
    public partial class FormEntrada : Form
    {
        public FormEntrada()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            Program.escolha = 1;
            this.Hide();
            FormEscolha FormEscolha = new FormEscolha();
            FormEscolha.Show();
            
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            Program.escolha = 2;
            this.Hide();
            FormEscolha FormEscolha = new FormEscolha();
            FormEscolha.Show();
            
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            Program.escolha = 3;
            this.Hide();
            FormEmprestimo formEmprestimo = new FormEmprestimo();
            formEmprestimo.tabEmprestimo.TabPages.Add(formEmprestimo.tabCadastro);
            formEmprestimo.Show();

           
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            Program.escolha = 4;
            this.Hide();
            FormEmprestimo formEmprestimo = new FormEmprestimo();
            formEmprestimo.tabEmprestimo.TabPages.Add(formEmprestimo.tabDevolucao);
            formEmprestimo.Show();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            Program.escolha = 5;
            this.Hide();
            FormRelatorios ul_form = new FormRelatorios();
            ul_form.Show();
        }

        private void FormEntrada_Load(object sender, EventArgs e)
        {

        }
    }
}
