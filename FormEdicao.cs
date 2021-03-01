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
    public partial class FormEdicao : Form
    {
        public int escolha; //1-altera titulo livro, nome func 2- altera email func e autor livro 3- altera nºpag livro, altera tel func 4-altera exemplar livro, altera funcao func 5-altera editora livro
        public FormEdicao()
        {
            InitializeComponent();
            Edicao.Controls.Remove(EditarLivro);
            Edicao.Controls.Remove(EditaUser);
            paEditaLivro.Visible = false;
            btOKEDICAO.Visible = false;
            pEditUser.Visible = false;
            cFuncao.DropDownStyle = ComboBoxStyle.DropDownList;
            cExemplares.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        // DEIXA INVISIVEL OS BUTTONS "ENVIAR"
        public void DeixarInvisivelbt()
        {
            bEditaTitulo.Visible = false;
            bEditaEditora.Visible = false;
            bNPag.Visible = false;
            bEditaExemplares.Visible = false;
            bEditaAutor.Visible = false;
        }
        //DEIXA VISIVEL LB
        public void DeixarVisivellb()
        {
            bEditaTitulo.Visible = true;
            bEditaEditora.Visible = true;
            bNPag.Visible = true;
            bEditaExemplares.Visible = true;
            bEditaAutor.Visible = true;
        }
        // DEIXA INVISIVEL OS TEXTBOX LUVRO
        public void DeixarInvisiveltxt()
        {
            txtTitulo.Visible = false;
            txtAutor.Visible = false;
            txtEditora.Visible = false;
            txtNpag.Visible = false;
            cExemplares.Visible = false;
            txtISSN.Visible = false;
            txtCOD.Visible = false;
        }
        //DEIXA VISIVEL TXT
        public void DeixaVisivelTxt()
        {
            txtTitulo.Visible = true;
            txtAutor.Visible = true;
            txtEditora.Visible = true;
            txtNpag.Visible = true;
            cExemplares.Visible = true;
            txtISSN.Visible = true;
            txtCOD.Visible = true;
        }
        // DEIXA INACESSIVEL OS TEXTBOX LIVRO
        public void DeixarInacessivelLivro()
        {
            txtTitulo.Enabled = false;
            txtAutor.Enabled = false;
            txtEditora.Enabled = false;
            txtNpag.Enabled = false;
            cExemplares.Enabled = false;
            txtISSN.Enabled = false;
            txtCOD.Enabled = false;
        }
        // DEIXA INACESSIVEL OS TEXTBOX USUARIO
        public void DeixarInacessivelUsuario()
        {
            txtCPF.Enabled = false;
            txtNome.Enabled = false;
            masktel.Enabled = false;
            cFuncao.Enabled = false;
            txtEmail.Enabled = false;
        }
        // DEIXA INVISIVEL OS LABELS DOS USUARIOS
        public void DeixarInvisivellbUs()
        {
            lbCPF.Visible = false;
            lEmail.Visible = false;
            lTelefone.Visible = false;
            lFuncao.Visible = false;
            lNome.Visible = false;
        }
        //DEIXA VISIVEL 
        public void DeixarVisivel()
        {
            lbCPF.Visible = true;
            lEmail.Visible = true;
            lTelefone.Visible = true;
            lFuncao.Visible = true;
            lNome.Visible = true;
        }
        // DEIXA BUTTONS INVISIVEIS
        public void ButtonsInvisiveis()
        {
            bEditaEmail.Visible = false;
            bEditaNome.Visible = false;
            bEditaFunc.Visible = false;
            bEditaTel.Visible = false;
        }
        // DEIXA TXT DO USER INVISIVEL
        public void DeixatxtInvisivel()
        {
            txtNome.Visible = false;
            masktel.Visible = false;
            cFuncao.Visible = false;
            txtCPF.Visible = false;
            txtEmail.Visible = false;
        }
        // DEIXA TXT VISIVEL 
        public void DeixatxtVisivel()
        {
            txtNome.Visible = true;
            masktel.Visible = true;
            cFuncao.Visible = true;
            txtCPF.Visible = true;
            txtEmail.Visible = true;
        }
        // DEIXA INVISIVEL LABELS LIVROS 
        public void DeixarInvisivellb()
        {
            lbTit.Visible = false;
            lbEditora.Visible = false;
            lbExemplares.Visible = false;
            lbIssn.Visible = false;
            lbAu.Visible = false;
            lbNumeroPaginas.Visible = false;
            lCOD.Visible = false;
        }
        private void BBuscarLivro_Click(object sender, EventArgs e)
        {
            if (Program.g1.VerificaLivro(txtCODB.Text) == 1)
            {
                // retornando os dados para o usuario decidir o que alterar
                AtualizarTextBoxLivro();
            }
            else
            {
                MessageBox.Show("Livro não cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private void bEditaTitulo_Click(object sender, EventArgs e)
        {
            
        }
        public void AtualizarTextBoxUser()
        {
            Usuarios nUsuario = Program.g2.PesquisaUsuario(txtBCPF.Text);
            pEditaUser.Visible = false;
            pEditUser.Visible = true;
            txtCPF.Text = txtBCPF.Text;
            txtNome.Text = nUsuario.RetornaNome();
            masktel.Text = nUsuario.RetornaTelefone();
            txtEmail.Text = nUsuario.RetornaEmail();
            cFuncao.Text = nUsuario.RetornaFuncao().ToString();
            // deixando o textbox inacessivel 
            DeixarInacessivelUsuario();
        }
        public void AtualizarTextBoxLivro()
        {
            Livro lv = Program.g1.PesquisaLivro(txtCODB.Text);
            paEditaLivro.Visible = true;
            pEditaDados.Visible = false;
            txtISSN.Text = lv.RetornaIssn();
            txtNpag.Text = lv.RetornaPaginas();
            txtTitulo.Text = lv.RetornaTitulo();
            txtEditora.Text = lv.RetornaEditora();
            txtAutor.Text = lv.RetornaAutor();
            cExemplares.Text = lv.RetornaExemplares().ToString();
            DeixarInacessivelLivro();
        }
        private void btOKEDICAO_Click(object sender, EventArgs e)
        {
            
            if (escolha == 1) // altera nome usuario, altera titulo livro
            {
                if (Program.escolha == 2)
                {
                    Program.g1.AlteraTitulo(txtTitulo.Text, txtCODB.Text);
                }
                else
                {
                    Program.g2.AlterarNome(txtNome.Text, txtBCPF.Text);
                }
            }
            else
            {
                if (escolha == 2) // altera autor livro, altera email usuario
                {
                    if (Program.escolha == 2)
                    {
                        Program.g1.AlteraAutor(txtAutor.Text, txtCODB.Text);
                    }
                    else
                    {
                        Program.g2.AlterarEmail(txtEmail.Text, txtBCPF.Text);
                    }
                }
                else
                {
                    if (escolha == 3) //altera numero de paginas, altera telefone user
                    {
                        if (Program.escolha == 2)
                        {
                            Program.g1.AlteraNPaginas(txtNpag.Text, txtCODB.Text);
                        }
                        else
                        {
                            Program.g2.AlterarTelefone(masktel.Text, txtBCPF.Text);
                        }
                    }
                    else
                    {
                        if (escolha == 4) // altera exemplar livro, altera funcao usuario
                        {
                            if (Program.escolha == 2)
                            {
                                int Exemplar = int.Parse(cExemplares.SelectedItem.ToString());
                                Program.g1.AlterarExemplares(Exemplar, txtCODB.Text);
                            }
                            else
                            {
                                Program.g2.AlterarFuncao(cFuncao.Text, txtBCPF.Text);
                            }
                        }
                        else
                        {
                            if ((escolha == 5))
                            {
                                {
                                    //altera editora
                                    Program.g1.AlteraEditora(txtEditora.Text, txtCODB.Text);
                                }
                            }
                        }
                    }
                }
            }
            var ms = MessageBox.Show("ALTERAÇÕES REALIZADAS COM SUCESSO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (ms == DialogResult.OK)
            {
                FormEntrada formEntrada = new FormEntrada();
                this.Hide();
                formEntrada.Show();
            }
        }

       

        private void bEditaAutor_Click(object sender, EventArgs e)
        {
            escolha = 2;
       
            DeixarInvisivelbt();
            DeixarInvisivellb();
            DeixarInvisiveltxt();
            txtAutor.Enabled = true;
            txtAutor.Visible = true;
            txtAutor.Focus();
            btOKEDICAO.Visible = true;
            lbAu.Visible = true;
            lbAu.Text = "Novo autor:";
            lbAu.Location = new Point(85,29);
            txtAutor.Location = new Point(120,52);
        }

        private void bNPag_Click(object sender, EventArgs e)
        {
            escolha = 3;
            DeixarInvisivelbt();
            DeixarInvisivellb();
            DeixarInvisiveltxt();
            txtNpag.Enabled = true;
            txtNpag.Visible = true;
            txtNpag.Focus();
            btOKEDICAO.Visible = true;
            lbNumeroPaginas.Visible = true;
            lbNumeroPaginas.Text = "Novo número:";
            lbNumeroPaginas.Location = new Point(85,29);
            txtNpag.Location = new Point(120,52);
        }

        private void bEditaExemplares_Click(object sender, EventArgs e)
        {
            escolha = 4;
         
            DeixarInacessivelLivro();
            DeixarInvisivelbt();
            DeixarInvisivellb();
            DeixarInvisiveltxt();
            cExemplares.Focus();
            btOKEDICAO.Visible = true;
            cExemplares.Visible = true;
            cExemplares.Enabled = true;
            lbExemplares.Visible = true;
            lbExemplares.Text = "Nova quantidade:";
            lbExemplares.Location = new Point(85,29);
            cExemplares.Location = new Point(120,52);
        }

        private void bEditaEditora_Click(object sender, EventArgs e)
        {
            escolha = 5;
            DeixarInacessivelLivro();
            DeixarInvisivelbt();
            DeixarInvisivellb();
            DeixarInvisiveltxt();
            btOKEDICAO.Visible = true;
            txtEditora.Visible = true;
            txtEditora.Enabled = true;
            lbEditora.Text = "Nova editora:";
            lbEditora.Visible = true;
            txtEditora.Focus();
            lbEditora.Location = new Point(85,29);
            txtEditora.Location = new Point(120,52);
        }

        private void bEditaNome_Click(object sender, EventArgs e)
        {
            escolha = 1;
            DeixarInacessivelUsuario();
            DeixarInvisivellbUs();
            ButtonsInvisiveis();
            DeixatxtInvisivel();
            btOKEDICAO.Visible = true;
            txtNome.Visible = true;
            txtNome.Enabled = true;
            lNome.Visible = true;
            txtNome.Focus();
            lNome.Text = "Novo Nome:";
            lNome.Location = new Point(85, 29);
            txtNome.Location = new Point(120, 52);
        }

        private void bEditaEmail_Click(object sender, EventArgs e)
        {
            escolha = 2;
            
            DeixarInacessivelUsuario();
            DeixarInvisivellbUs();
            ButtonsInvisiveis();
            DeixatxtInvisivel();
            btOKEDICAO.Visible = true;
            txtEmail.Visible = true;
            lEmail.Visible = true;
            txtEmail.Enabled = true;
            txtEmail.Focus();
            lEmail.Location = new Point(85,29);
            txtEmail.Location = new Point(120,52);
            lEmail.Text = "Novo email:";
        }

        private void bEditaTel_Click(object sender, EventArgs e)
        {
            escolha = 3;
            DeixarInacessivelUsuario();
            DeixarInvisivellbUs();
            ButtonsInvisiveis();
            DeixatxtInvisivel();
            masktel.Enabled = true;
            btOKEDICAO.Visible = true;
            masktel.Visible = true;
            masktel.Focus();
            lTelefone.Visible = true;
            lTelefone.Location = new Point(85,29);
            masktel.Location = new Point(120,52);
            lTelefone.Text = "Novo telefone:";
        }

        private void bEditaFunc_Click(object sender, EventArgs e)
        {
            escolha = 4;
            DeixarInacessivelUsuario();
            DeixarInvisivellbUs();
            ButtonsInvisiveis();
            DeixatxtInvisivel();
            cFuncao.Focus();
            btOKEDICAO.Visible = true;
            cFuncao.Visible = true;
            lFuncao.Visible = true;
            cFuncao.Enabled = true;
            lFuncao.Location = new Point(85,29);
            cFuncao.Location = new Point(120,52);
            lFuncao.Text = "Nova Função:";
        }

        private void bEditaTitulo_Click_1(object sender, EventArgs e)
        {
            escolha = 1;
          
            DeixarInvisivelbt();
            DeixarInvisiveltxt();
            DeixarInvisivellb();
            txtTitulo.Enabled = true;
            txtTitulo.Visible = true;
            txtTitulo.Focus();
            btOKEDICAO.Visible = true;
            lbTit.Text = "Novo Titulo: ";
            lbTit.Location = new Point(85,29);
            txtTitulo.Location = new Point(120,52);
            lbTit.Visible = true;
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

        private void evento_pesquisa(object sender, KeyPressEventArgs e)
        {
            string pesquisa = txtCODB.Text;

        }

        private void BBuscaUser_Click(object sender, EventArgs e)
        {
            if (Program.g2.VerificaUsuario(txtBCPF.Text) == 1)
            {
                AtualizarTextBoxUser();
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
