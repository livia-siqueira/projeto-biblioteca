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
    public partial class FormEscolha : Form
    {
        public FormEscolha()
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

        private void btEscolhaUser_Click(object sender, EventArgs e)
        {
            FormCadastra FormCadastra = new FormCadastra();
            //FormEdicao edicaoForm = new FormEdicao();
            if (rbtCadastro.Checked == true)
            {
                if (Program.escolha == 1)
                {
                    FormCadastra.ControlCadastra.TabPages.Add(FormCadastra.CadastroUsuario);
                    
                }
                else
                {
                    FormCadastra.ControlCadastra.TabPages.Add(FormCadastra.CadastroLivros);
                    
                }
                this.Hide();
                FormCadastra.Show();

            }
            else
            {
                if(rbtAlteracao.Checked == true)
                {
                    FormEdicao formed = new FormEdicao();
                    if (Program.escolha == 1)
                    {
                        formed.Edicao.Controls.Add(formed.EditaUser);

                    }
                    else
                    {
                        formed.Edicao.Controls.Add(formed.EditarLivro);
                    }
                    this.Hide();
                    formed.Show();
                }
                else
                {
                    FormPesquisa fpesq = new FormPesquisa();
                    if(Program.escolha == 1)
                    {
                        fpesq.ControlPesq.Controls.Add(fpesq.PesqUser);
                    }
                    else
                    {
                        fpesq.ControlPesq.Controls.Add(fpesq.tabPesLivro);
                    }
                    this.Hide();
                    fpesq.Show();
                }
            }
        }

        private void btMenuPrincipal_Click(object sender, EventArgs e)
        {
            FormEntrada pForm = new FormEntrada();
            pForm.Show();
            this.Close();
        }
    }
}
