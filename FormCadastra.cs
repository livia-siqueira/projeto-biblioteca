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
    public partial class FormCadastra : Form
    {
        public FormCadastra()
        {
            InitializeComponent();
            cFuncao.DropDownStyle = ComboBoxStyle.DropDownList;
            cExemplares.DropDownStyle = ComboBoxStyle.DropDownList;
            ControlCadastra.Controls.Remove(CadastroLivros);
            ControlCadastra.Controls.Remove(CadastroUsuario);
            ListaUser();
            ListaLivro();
        }
        public void LimparDadosLivro()
        {
            txtAutor.ResetText();
            txtEditora.ResetText();
            txtNumerodePaginas.ResetText();
            txtTitulo.ResetText();
            //cExemplares.ClearSelection();
            txtISSN.ResetText();
            txtCOD.ResetText();
        }
        public void ListaUser()
        {
            list2.Items.Clear();
            Usuarios[] vet = Program.g2.ListaUsuarios();
            for (int i = 0; i < Program.g2.qUsuarios; i++)
            {
                ListViewItem lv = new ListViewItem(vet[i].RetornaCPF());
                lv.SubItems.Add(vet[i].RetornaNome());
                lv.SubItems.Add(vet[i].RetornaEmail());
                lv.SubItems.Add(vet[i].RetornaTelefone());
                lv.SubItems.Add(vet[i].RetornaFuncao());
                list2.Items.Add(lv);
            }
        }
        public void ListaLivro()
        {
            list1.Items.Clear();
            Livro[] vetLivro = Program.g1.ListarLivros();
            for (int i = 0; i < Program.g1.qLivros; i++)
            {
                ListViewItem list = new ListViewItem(vetLivro[i].RetornaCOD());
                list.SubItems.Add(vetLivro[i].RetornaTitulo());
                list.SubItems.Add(vetLivro[i].RetornaAutor());
                list.SubItems.Add(vetLivro[i].RetornaPaginas());
                list.SubItems.Add(vetLivro[i].RetornaExemplares().ToString());
                list.SubItems.Add(vetLivro[i].RetornaEditora());
                list.SubItems.Add(vetLivro[i].RetornaIssn());
                list1.Items.Add(list);

            }
        }
        public void LimparDadosUsuario()
        {
            txtCPF.ResetText();
            txtEmail.ResetText();
            txtNome.ResetText();
            masktel.ResetText();
            cFuncao.ResetText();
        }
        private void btAddLivro_Click(object sender, EventArgs e)
        {
            if (txtCOD.Text == "" || txtTitulo.Text == "" || txtISSN.Text == "" || txtEditora.Text == "" || txtAutor.Text == "" || cExemplares.Text == "" || lbnPag.Text == "")
            {
                MessageBox.Show("Preencha todos os dados corretamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Program.g1.VerificaLivro(txtCOD.Text) != 1)
                {
                    Livro liv;
                    liv = new Livro(txtCOD.Text, txtTitulo.Text, txtAutor.Text, txtNumerodePaginas.Text, txtISSN.Text, int.Parse(cExemplares.Text), txtEditora.Text);
                    Program.g1.AdicionarLivro(liv);
                    ListaLivro();
                    MessageBox.Show("Cadastro realizado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparDadosLivro();
                }
                else
                {
                    LimparDadosLivro();
                    MessageBox.Show("LIVRO JÁ CADASTRADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }



        }

        private void btAddUser_Click(object sender, EventArgs e)
        {

            bool resp = txtEmail.Text.Contains("@");
            if (Program.g2.VerificaUsuario(txtCPF.Text) != 1)
            {
                if (resp == true)
                {
                    Usuarios user;
                    user = new Usuarios(txtCPF.Text, txtNome.Text, masktel.Text, txtEmail.Text, cFuncao.Text);
                    Program.g2.AdicionarUsuario(user);
                    ListaUser();
                    MessageBox.Show("Cadastrado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimparDadosUsuario();

                }
                else
                {

                    MessageBox.Show("Preencha todos os dados corretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                LimparDadosUsuario();
                MessageBox.Show("USUÁRIO JÁ EXISTENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btMenuPrincipal_Click(object sender, EventArgs e)
        {
            FormEntrada pForm = new FormEntrada();
            pForm.ShowDialog();
            this.Close();
        }
    }
}
