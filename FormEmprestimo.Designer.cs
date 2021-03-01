namespace projeto_biblioteca_LiviaSiqueira
{
    partial class FormEmprestimo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmprestimo));
            this.panel9 = new System.Windows.Forms.Panel();
            this.btMenuPrincipal = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabEmprestimo = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.CalendEmp = new System.Windows.Forms.MonthCalendar();
            this.btAdicionaEmp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maskDt = new System.Windows.Forms.MaskedTextBox();
            this.list_Emp = new System.Windows.Forms.ListView();
            this.coCodLivro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coDev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maskCPF_emp = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCOD_emp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDevolucao = new System.Windows.Forms.TabPage();
            this.rich1 = new System.Windows.Forms.RichTextBox();
            this.CalendDev = new System.Windows.Forms.MonthCalendar();
            this.btCadastraDev = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.datadev = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lis_Dev = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabEmprestimo.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.tabDevolucao.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.CadetBlue;
            this.panel9.Controls.Add(this.btMenuPrincipal);
            this.panel9.Controls.Add(this.pictureBox2);
            this.panel9.Location = new System.Drawing.Point(0, 41);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(149, 371);
            this.panel9.TabIndex = 8;
            // 
            // btMenuPrincipal
            // 
            this.btMenuPrincipal.BackColor = System.Drawing.Color.CadetBlue;
            this.btMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMenuPrincipal.FlatAppearance.BorderSize = 0;
            this.btMenuPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btMenuPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuPrincipal.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenuPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btMenuPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("btMenuPrincipal.Image")));
            this.btMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMenuPrincipal.Location = new System.Drawing.Point(3, 284);
            this.btMenuPrincipal.Name = "btMenuPrincipal";
            this.btMenuPrincipal.Size = new System.Drawing.Size(145, 78);
            this.btMenuPrincipal.TabIndex = 16;
            this.btMenuPrincipal.Text = "MENU PRINCIPAL";
            this.btMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMenuPrincipal.UseVisualStyleBackColor = false;
            this.btMenuPrincipal.Click += new System.EventHandler(this.btMenuPrincipal_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-22, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabEmprestimo
            // 
            this.tabEmprestimo.Controls.Add(this.tabCadastro);
            this.tabEmprestimo.Controls.Add(this.tabDevolucao);
            this.tabEmprestimo.Location = new System.Drawing.Point(146, 25);
            this.tabEmprestimo.Name = "tabEmprestimo";
            this.tabEmprestimo.SelectedIndex = 0;
            this.tabEmprestimo.Size = new System.Drawing.Size(712, 387);
            this.tabEmprestimo.TabIndex = 9;
            this.tabEmprestimo.Enter += new System.EventHandler(this.evento_dev);
            // 
            // tabCadastro
            // 
            this.tabCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.tabCadastro.Controls.Add(this.CalendEmp);
            this.tabCadastro.Controls.Add(this.btAdicionaEmp);
            this.tabCadastro.Controls.Add(this.label3);
            this.tabCadastro.Controls.Add(this.maskDt);
            this.tabCadastro.Controls.Add(this.list_Emp);
            this.tabCadastro.Controls.Add(this.maskCPF_emp);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Controls.Add(this.textCOD_emp);
            this.tabCadastro.Controls.Add(this.label1);
            this.tabCadastro.ForeColor = System.Drawing.Color.CadetBlue;
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(704, 360);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastro";
            // 
            // CalendEmp
            // 
            this.CalendEmp.Location = new System.Drawing.Point(34, 63);
            this.CalendEmp.Name = "CalendEmp";
            this.CalendEmp.TabIndex = 5;
            this.CalendEmp.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendEmp_DateChanged);
            // 
            // btAdicionaEmp
            // 
            this.btAdicionaEmp.BackColor = System.Drawing.Color.Transparent;
            this.btAdicionaEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdicionaEmp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btAdicionaEmp.FlatAppearance.BorderSize = 0;
            this.btAdicionaEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionaEmp.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionaEmp.Image")));
            this.btAdicionaEmp.Location = new System.Drawing.Point(435, 58);
            this.btAdicionaEmp.Name = "btAdicionaEmp";
            this.btAdicionaEmp.Size = new System.Drawing.Size(55, 52);
            this.btAdicionaEmp.TabIndex = 3;
            this.btAdicionaEmp.UseVisualStyleBackColor = false;
            this.btAdicionaEmp.Click += new System.EventHandler(this.btAdicionaEmp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Realização:";
            // 
            // maskDt
            // 
            this.maskDt.Location = new System.Drawing.Point(104, 44);
            this.maskDt.Mask = "00/00/0000";
            this.maskDt.Name = "maskDt";
            this.maskDt.Size = new System.Drawing.Size(66, 20);
            this.maskDt.TabIndex = 2;
            this.maskDt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskDt.ValidatingType = typeof(System.DateTime);
            this.maskDt.Enter += new System.EventHandler(this.evento_enterCalend);
            // 
            // list_Emp
            // 
            this.list_Emp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coCodLivro,
            this.coTitulo,
            this.coTel,
            this.coUsuario,
            this.coData,
            this.coDev,
            this.coStatus});
            this.list_Emp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Emp.GridLines = true;
            this.list_Emp.HideSelection = false;
            this.list_Emp.Location = new System.Drawing.Point(0, 132);
            this.list_Emp.Name = "list_Emp";
            this.list_Emp.Size = new System.Drawing.Size(705, 232);
            this.list_Emp.TabIndex = 4;
            this.list_Emp.UseCompatibleStateImageBehavior = false;
            this.list_Emp.View = System.Windows.Forms.View.Details;
            // 
            // coCodLivro
            // 
            this.coCodLivro.Text = "COD ";
            this.coCodLivro.Width = 48;
            // 
            // coTitulo
            // 
            this.coTitulo.Text = "TITULO";
            this.coTitulo.Width = 119;
            // 
            // coTel
            // 
            this.coTel.Text = "TELEFONE";
            this.coTel.Width = 90;
            // 
            // coUsuario
            // 
            this.coUsuario.Text = "USUÁRIO";
            this.coUsuario.Width = 145;
            // 
            // coData
            // 
            this.coData.Text = "DATA DE CADASTRO";
            this.coData.Width = 111;
            // 
            // coDev
            // 
            this.coDev.Text = "DATA DE DEVOLUÇÃO";
            this.coDev.Width = 112;
            // 
            // coStatus
            // 
            this.coStatus.Text = "STATUS";
            this.coStatus.Width = 285;
            // 
            // maskCPF_emp
            // 
            this.maskCPF_emp.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskCPF_emp.Location = new System.Drawing.Point(345, 18);
            this.maskCPF_emp.Mask = "000.000.000-00";
            this.maskCPF_emp.Name = "maskCPF_emp";
            this.maskCPF_emp.Size = new System.Drawing.Size(90, 20);
            this.maskCPF_emp.TabIndex = 1;
            this.maskCPF_emp.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(255, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF do Usuário:";
            // 
            // textCOD_emp
            // 
            this.textCOD_emp.Location = new System.Drawing.Point(96, 19);
            this.textCOD_emp.Name = "textCOD_emp";
            this.textCOD_emp.Size = new System.Drawing.Size(130, 20);
            this.textCOD_emp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Livro:";
            // 
            // tabDevolucao
            // 
            this.tabDevolucao.BackColor = System.Drawing.SystemColors.Control;
            this.tabDevolucao.Controls.Add(this.rich1);
            this.tabDevolucao.Controls.Add(this.CalendDev);
            this.tabDevolucao.Controls.Add(this.btCadastraDev);
            this.tabDevolucao.Controls.Add(this.label6);
            this.tabDevolucao.Controls.Add(this.datadev);
            this.tabDevolucao.Controls.Add(this.label5);
            this.tabDevolucao.Controls.Add(this.lis_Dev);
            this.tabDevolucao.Controls.Add(this.txtBEmp);
            this.tabDevolucao.Controls.Add(this.label4);
            this.tabDevolucao.Location = new System.Drawing.Point(4, 22);
            this.tabDevolucao.Name = "tabDevolucao";
            this.tabDevolucao.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevolucao.Size = new System.Drawing.Size(704, 361);
            this.tabDevolucao.TabIndex = 1;
            this.tabDevolucao.Text = "DEVOLUCAO";
            // 
            // rich1
            // 
            this.rich1.Location = new System.Drawing.Point(484, 0);
            this.rich1.Name = "rich1";
            this.rich1.Size = new System.Drawing.Size(146, 117);
            this.rich1.TabIndex = 12;
            this.rich1.Text = "Ex: Livro está molhado";
            this.rich1.Enter += new System.EventHandler(this.evento_limp);
            // 
            // CalendDev
            // 
            this.CalendDev.Location = new System.Drawing.Point(34, 63);
            this.CalendDev.Name = "CalendDev";
            this.CalendDev.TabIndex = 11;
            this.CalendDev.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendDev_DateChanged);
            // 
            // btCadastraDev
            // 
            this.btCadastraDev.BackColor = System.Drawing.Color.Transparent;
            this.btCadastraDev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastraDev.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btCadastraDev.FlatAppearance.BorderSize = 0;
            this.btCadastraDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastraDev.Image = ((System.Drawing.Image)(resources.GetObject("btCadastraDev.Image")));
            this.btCadastraDev.Location = new System.Drawing.Point(265, 65);
            this.btCadastraDev.Name = "btCadastraDev";
            this.btCadastraDev.Size = new System.Drawing.Size(55, 52);
            this.btCadastraDev.TabIndex = 10;
            this.btCadastraDev.UseVisualStyleBackColor = false;
            this.btCadastraDev.Click += new System.EventHandler(this.btCadastraDev_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Informações Adicionais:";
            // 
            // datadev
            // 
            this.datadev.Location = new System.Drawing.Point(133, 33);
            this.datadev.Mask = "00/00/0000";
            this.datadev.Name = "datadev";
            this.datadev.Size = new System.Drawing.Size(66, 20);
            this.datadev.TabIndex = 7;
            this.datadev.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.datadev.ValidatingType = typeof(System.DateTime);
            this.datadev.Enter += new System.EventHandler(this.evento_devolucao);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data da Devolução: ";
            // 
            // lis_Dev
            // 
            this.lis_Dev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.lis_Dev.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lis_Dev.GridLines = true;
            this.lis_Dev.HideSelection = false;
            this.lis_Dev.Location = new System.Drawing.Point(-4, 123);
            this.lis_Dev.Name = "lis_Dev";
            this.lis_Dev.Size = new System.Drawing.Size(708, 245);
            this.lis_Dev.TabIndex = 5;
            this.lis_Dev.UseCompatibleStateImageBehavior = false;
            this.lis_Dev.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "COD ";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titulo";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Usuário";
            this.columnHeader4.Width = 145;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data de Devolução";
            this.columnHeader6.Width = 255;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Status";
            this.columnHeader7.Width = 285;
            // 
            // txtBEmp
            // 
            this.txtBEmp.Location = new System.Drawing.Point(124, 5);
            this.txtBEmp.Name = "txtBEmp";
            this.txtBEmp.Size = new System.Drawing.Size(172, 20);
            this.txtBEmp.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código do Livro: ";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tabEmprestimo);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(858, 412);
            this.panel10.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btMinimizar);
            this.panel1.Controls.Add(this.btFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 44);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btMinimizar
            // 
            this.btMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMinimizar.BackgroundImage")));
            this.btMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Location = new System.Drawing.Point(771, 15);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(32, 29);
            this.btMinimizar.TabIndex = 3;
            this.btMinimizar.UseVisualStyleBackColor = false;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click_1);
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.Transparent;
            this.btFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFechar.BackgroundImage")));
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Location = new System.Drawing.Point(809, 15);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(32, 29);
            this.btFechar.TabIndex = 0;
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click_1);
            // 
            // FormEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestimo";
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabEmprestimo.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.tabDevolucao.ResumeLayout(false);
            this.tabDevolucao.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btMenuPrincipal;
        private System.Windows.Forms.TextBox textCOD_emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskCPF_emp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskDt;
        private System.Windows.Forms.ListView list_Emp;
        private System.Windows.Forms.ColumnHeader coCodLivro;
        private System.Windows.Forms.ColumnHeader coTitulo;
        private System.Windows.Forms.ColumnHeader coUsuario;
        private System.Windows.Forms.ColumnHeader coData;
        private System.Windows.Forms.ColumnHeader coDev;
        private System.Windows.Forms.ColumnHeader coStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btAdicionaEmp;
        private System.Windows.Forms.ColumnHeader coTel;
        private System.Windows.Forms.MonthCalendar CalendEmp;
        private System.Windows.Forms.TextBox txtBEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lis_Dev;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TabControl tabEmprestimo;
        public System.Windows.Forms.TabPage tabCadastro;
        public System.Windows.Forms.TabPage tabDevolucao;
        private System.Windows.Forms.Button btCadastraDev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox datadev;
        private System.Windows.Forms.MonthCalendar CalendDev;
        private System.Windows.Forms.RichTextBox rich1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Button btFechar;
    }
}