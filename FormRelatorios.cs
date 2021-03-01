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
    public partial class FormRelatorios : Form
    {
        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void FormRelatorios_Load(object sender, EventArgs e)
        {
            list_relatLivro.Visible = false;
            listrelat_User.Visible = false;
            list_relatEmp.Visible = false;
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
             list_relatLivro.Visible = false;
            listrelat_User.Visible = false;
            list_relatEmp.Visible = false;
            string c = com_relat.Text;
            if(c == "Usuários")
            {
                listrelat_User.Items.Clear();
                listrelat_User.Visible = true;
                Usuarios[] users = Program.g2.ListaUsuarios();
                for (int i = 0; i < Program.g2.qUsuarios; i++)
                {
                    ListViewItem lu = new ListViewItem(users[i].RetornaCPF());
                    lu.SubItems.Add(users[i].RetornaNome());
                    lu.SubItems.Add(users[i].RetornaEmail());
                    lu.SubItems.Add(users[i].RetornaTelefone());
                    lu.SubItems.Add(users[i].RetornaFuncao());
                    listrelat_User.Items.Add(lu);

                }
                 
            }
            else
            {
                if (c == "Livros")
                {
                    list_relatLivro.Items.Clear();
                    list_relatLivro.Visible = true;
                    Livro[] liv = Program.g1.ListarLivros();
                    for (int i = 0; i < Program.g1.qLivros; i++)
                    {
                        ListViewItem lv = new ListViewItem(liv[i].RetornaCOD());
                        lv.SubItems.Add(liv[i].RetornaTitulo());
                        lv.SubItems.Add(liv[i].RetornaAutor());
                        lv.SubItems.Add(liv[i].RetornaPaginas());
                        lv.SubItems.Add(liv[i].RetornaExemplares().ToString());
                        lv.SubItems.Add(liv[i].RetornaEditora());
                        lv.SubItems.Add(liv[i].RetornaIssn());
                        list_relatLivro.Items.Add(lv);
                    }
                }
                else
                {
                    if (c == "Empréstimos")
                    {
                        list_relatEmp.Items.Clear();
                        list_relatEmp.Visible = true;

                        for (int i = 0; i < Program.g3.cont_emp; i++)
                        {
                            Emprestimo[] emp = Program.g3.ListarEmprestimos();
                            Livro[] liv = Program.g1.ListarLivros();
                            int l = Program.g1.RetornaLiv_Posi(emp[i].Retornarcod());
                            ListViewItem le = new ListViewItem(emp[i].Retornarcod());
                            le.SubItems.Add(liv[l].RetornaTitulo());
                            le.SubItems.Add(emp[i].RetornaTelefone());
                            le.SubItems.Add(emp[i].RetornaNome());
                            le.SubItems.Add(emp[i].RetornaData().ToString());
                            le.SubItems.Add(emp[i].RetornaDevolucao().ToString());
                            le.SubItems.Add(emp[i].RetornarDev());
                            list_relatEmp.Items.Add(le);

                        }

                    }
                    else
                    {
                        if (c == "Empréstimos finalizados")
                        {
                            list_relatEmp.Items.Clear();
                            list_relatEmp.Visible = true;

                            for (int i = 0; i < Program.g3.cont_emp; i++)
                            {
                                Emprestimo[] emp = Program.g3.ListarEmprestimos();
                                if (emp[i].RetornarDev() == "DEVOLVIDO")
                                {
                                    Livro[] liv = Program.g1.ListarLivros();
                                    int l = Program.g1.RetornaLiv_Posi(emp[i].Retornarcod());
                                    ListViewItem le = new ListViewItem(emp[i].Retornarcod());
                                    le.SubItems.Add(liv[l].RetornaTitulo());
                                    le.SubItems.Add(emp[i].RetornaTelefone());
                                    le.SubItems.Add(emp[i].RetornaNome());
                                    le.SubItems.Add(emp[i].RetornaData().ToString());
                                    le.SubItems.Add(emp[i].RetornaDevolucao().ToString());
                                    le.SubItems.Add(emp[i].RetornarDev());
                                    list_relatEmp.Items.Add(le);
                                }

                            }
                        }
                        else
                        {
                            list_relatEmp.Items.Clear();
                            list_relatEmp.Visible = true;
                            Emprestimo[] emp = Program.g3.ListarEmprestimos();
                            for (int i = 0; i < Program.g3.cont_emp; i++)
                            {
                                if (emp[i].RetornarDev() == "EMPRESTADO")
                                {
                                    Livro[] liv = Program.g1.ListarLivros();
                                    int l = Program.g1.RetornaLiv_Posi(emp[i].Retornarcod());
                                    ListViewItem le = new ListViewItem(emp[i].Retornarcod());
                                    le.SubItems.Add(liv[l].RetornaTitulo());
                                    le.SubItems.Add(emp[i].RetornaTelefone());
                                    le.SubItems.Add(emp[i].RetornaNome());
                                    le.SubItems.Add(emp[i].RetornaData().ToString());
                                    le.SubItems.Add(emp[i].RetornaDevolucao().ToString());
                                    le.SubItems.Add(emp[i].RetornarDev());
                                    list_relatEmp.Items.Add(le);
                                }

                            }
                        }
                    }
                }
            }
        }

        private void btMenuPrincipal_Click(object sender, EventArgs e)
        {
            FormEntrada pForm = new FormEntrada();
            pForm.ShowDialog();
            this.Close();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
