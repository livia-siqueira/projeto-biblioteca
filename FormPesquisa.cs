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
    public partial class FormPesquisa : Form
    {
        public FormPesquisa()
        {
            InitializeComponent();
            ControlPesq.Controls.Remove(tabPesLivro);
            ControlPesq.Controls.Remove(PesqUser);
            paneluser.Visible = false;
            panellivro.Visible = false;
        }

        private void Bpesq_cpf_Click(object sender, EventArgs e)
        {

            Usuarios po = Program.g2.PesquisaUsuario(mask_cpfP.Text);
            if (po != null)
            {
                paneluser.Visible = true;
                lb_nome.Text = po.RetornaNome();
                lb_CPF.Text = po.RetornaCPF();
                lb_EMAIL.Text = po.RetornaEmail();
                lb_FUNCAO.Text = po.RetornaFuncao();
                lb_TELEFONE.Text = po.RetornaTelefone();
            }
            else
            {
                MessageBox.Show("USUÁRIO NÃO CADASTRADO");
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

        private void bBPesq_Click(object sender, EventArgs e)
        {
            Livro lv = Program.g1.PesquisaLivro(txtCODpesq.Text);
            if (lv != null)
            {
                panellivro.Visible = true;
                paneluser.Visible = true;
                lbAt.Text = lv.RetornaAutor();
                lbCod.Text = lv.RetornaCOD();
                lbExe.Text = lv.RetornaExemplares().ToString();
                lbISSN.Text = lv.RetornaIssn();
                lbpag.Text = lv.RetornaPaginas();
                lbTitulo.Text = lv.RetornaTitulo();
                lbED.Text = lv.RetornaEditora();

            }
            else
            {
                MessageBox.Show("LIVRO NÃO CADASTRADO");
            }
        }
    }
}
