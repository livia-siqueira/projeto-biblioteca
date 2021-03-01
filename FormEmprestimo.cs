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
    public partial class FormEmprestimo : Form
    {
        public DateTime data;
        public DateTime dev;
        public FormEmprestimo()
        {
            InitializeComponent();
            maskCPF_emp.Focus();
            ListaEmp();
            CalendEmp.Visible = false;
            ListaDev();
            CalendDev.Visible = false;
            maskDt.Text = DateTime.Now.ToString();
            datadev.Text = DateTime.Now.ToString();
            tabEmprestimo.Controls.Remove(tabCadastro);
            tabEmprestimo.Controls.Remove(tabDevolucao);
        }

        private void btMenuPrincipal_Click(object sender, EventArgs e)
        {
            FormEntrada pForm = new FormEntrada();
            pForm.ShowDialog();
            this.Close();
        }

        public void LimpaEmp()
        {
            textCOD_emp.ResetText();
            maskCPF_emp.ResetText();
        }
        public void LimpaDev()
        {
            txtBEmp.ResetText();
        }
        public void ListaEmp()
        {
            
            list_Emp.Items.Clear();
            Usuarios[] user = Program.g2.ListaUsuarios();
            Livro[] liv = Program.g1.ListarLivros();
            int j = Program.g2.RetornarUser_Posi(maskCPF_emp.Text);
            int l = Program.g1.RetornaLiv_Posi(textCOD_emp.Text);
            Emprestimo[] vetEmp = Program.g3.ListarEmprestimos();
            for (int i = 0; i < Program.g3.cont_emp; i++)
            {
                if (Program.g3.controle[i].RetornarDev() == "EMPRESTADO")
                {
                    ListViewItem list = new ListViewItem(vetEmp[i].Retornarcod());
                    list.SubItems.Add(liv[l].RetornaTitulo());
                    list.SubItems.Add(vetEmp[i].RetornaTelefone());
                    list.SubItems.Add(user[j].RetornaNome());
                    list.SubItems.Add(vetEmp[i].RetornaData().ToString());
                    list.SubItems.Add(vetEmp[i].RetornaDevolucao().ToString());
                    list.SubItems.Add(vetEmp[i].RetornarDev());
                    list_Emp.Items.Add(list);
                }
            }
        }
       
        public void ListaDev()
        {
            lis_Dev.Items.Clear();
            for (int i = 0; i < Program.g3.cont_emp; i++)
            {
                Emprestimo[] emp = Program.g3.ListarEmprestimos();
                Usuarios[] user = Program.g2.ListaUsuarios();
                Livro[] liv = Program.g1.ListarLivros();
                int j = Program.g2.RetornarUser_Posi(maskCPF_emp.Text);
                int l = Program.g1.RetornaLiv_Posi(textCOD_emp.Text);
                int p = Program.g3.RetornarEmp_Posi(textCOD_emp.Text);
                if (Program.g3.controle[i].RetornarDev() == "DEVOLVIDO")
                {
                    ListViewItem lv = new ListViewItem(liv[l].RetornaCOD());
                    lv.SubItems.Add(liv[l].RetornaTitulo());
                    lv.SubItems.Add(user[j].RetornaNome());
                    lv.SubItems.Add(datadev.ToString());
                    lv.SubItems.Add(emp[p].RetornarDev());
                    lis_Dev.Items.Add(lv);
                }
            }
        }
        private void btAdicionaEmp_Click(object sender, EventArgs e)
        {

            string EMP;
            if (textCOD_emp.Text == "" || maskCPF_emp.Text == "" || maskDt.Text == "")
            {
                MessageBox.Show("Preencha os dados corretamente");
            }
            else
            {
                Emprestimo emp;
                int resp = Program.g1.VerificaLivro(textCOD_emp.Text);
                int resp2 = Program.g2.VerificaUsuario(maskCPF_emp.Text);
                Usuarios user = Program.g2.PesquisaUsuario(maskCPF_emp.Text);
                if (Program.g3.RetornaqEmpUser(maskCPF_emp.Text) <= 3) //LIMITE DE 4 EMPRESTIMOS POR USUÁRIO
                {
                    if (resp != -1)
                    {
                        if (resp2 != -1)
                        {
                            if (Program.g3.VerificarLivroEmp(textCOD_emp.Text) != 1 || Program.g3.VerificaDevol(textCOD_emp.Text) == 1)
                            {
                                data = CalendEmp.SelectionStart;
                                dev = data.AddDays(8);
                                EMP = "EMPRESTADO";
                                emp = new Emprestimo(textCOD_emp.Text, user.RetornaNome(), user.RetornaTelefone(), user.RetornaCPF(), EMP, data, dev);
                                Program.g3.AdicionarEmprestismo(emp);
                                Program.g3.LivrosEmprestados(textCOD_emp.Text);
                                MessageBox.Show("Cadastrado com sucesso");
                                LimpaEmp();
                                ListaEmp();

                            }
                            else
                            {

                                MessageBox.Show("Livro não disponivel");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não cadastrado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Livro não cadastrado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("SEU USUÁRIO ATINGIU O LIMITE DE EMPRÉSTIMOS (4 LIVROS), POR FAVOR PEÇA-O PARA EFETUAR A DEVOLUÇÃO DE PELO MENOS UM LIVRO PARA CONTINUAR UTILIZANDO NOSSOS SERVIÇOS", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                }

            }
        }

        private void evento_enterCalend(object sender, EventArgs e)
        {
            CalendEmp.Visible = true;
 
        }

        private void CalendEmp_DateChanged(object sender, DateRangeEventArgs e)
        {
            maskDt.Text = CalendEmp.SelectionStart.ToString();
            CalendEmp.Visible = false;
        }
        private void btCadastraDev_Click(object sender, EventArgs e)
        {
            if (Program.g3.cont_emp > 0)
            {
                DateTime dat = CalendDev.SelectionStart;
                int i = Program.g3.VerificaDevNec(txtBEmp.Text);
                Emprestimo emp = Program.g3.RetornarEmpCod_Livro(txtBEmp.Text);
                if (i == 1)
                {
                    if (emp.RetornarDev() != "DEVOLVIDO")
                    {
                        emp.AlterarDevolucao();

                        if (emp.RetornaDevolucao() == dat || emp.RetornaDevolucao() > dat)
                        {
                            MessageBox.Show("DEVOLUÇÃO CADASTRADA");
                        }
                        else
                        {
                            MessageBox.Show("DEVOLVIDO COM ATRASO");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Livro já devolvido");
                    }
                    ListaDev();
                }
                else
                {
                    MessageBox.Show("Não há devoluções há serem cadastradas");
                }
            }
            else
            {
                MessageBox.Show("NÃO EXISTEM EMPRÉSTIMOS CADASTRADOS");
            }
        }

        private void evento_dev(object sender, EventArgs e)
        {
            
        }

        private void CalendDev_DateChanged(object sender, DateRangeEventArgs e)
        {
            datadev.Text = CalendDev.SelectionStart.ToString();
            CalendDev.Visible = false;
        }

        private void evento_devolucao(object sender, EventArgs e)
        {
            CalendDev.Visible = true;
        }

        private void evento_limp(object sender, EventArgs e)
        {
            rich1.Clear();
        }

        private void btFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }



}