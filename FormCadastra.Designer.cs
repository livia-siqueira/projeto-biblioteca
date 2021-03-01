namespace projeto_biblioteca_LiviaSiqueira
{
    partial class FormCadastra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btMenuPrincipal = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ControlCadastra = new System.Windows.Forms.TabControl();
            this.CadastroUsuario = new System.Windows.Forms.TabPage();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.list2 = new System.Windows.Forms.ListView();
            this.cCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coFuncao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.masktel = new System.Windows.Forms.MaskedTextBox();
            this.cFuncao = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddUser = new System.Windows.Forms.Button();
            this.CadastroLivros = new System.Windows.Forms.TabPage();
            this.txtCOD = new System.Windows.Forms.TextBox();
            this.lCOD = new System.Windows.Forms.Label();
            this.list1 = new System.Windows.Forms.ListView();
            this.cCOD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNPag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coExemplares = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEditora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coISSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAddLivro = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtISSN = new System.Windows.Forms.TextBox();
            this.txtNumerodePaginas = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.cExemplares = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbnPag = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ControlCadastra.SuspendLayout();
            this.CadastroUsuario.SuspendLayout();
            this.CadastroLivros.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(851, 48);
            this.panel1.TabIndex = 2;
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
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
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
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.CadetBlue;
            this.panel9.Controls.Add(this.btMenuPrincipal);
            this.panel9.Controls.Add(this.pictureBox2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 48);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(153, 379);
            this.panel9.TabIndex = 7;
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
            this.btMenuPrincipal.Location = new System.Drawing.Point(6, 280);
            this.btMenuPrincipal.Name = "btMenuPrincipal";
            this.btMenuPrincipal.Size = new System.Drawing.Size(145, 97);
            this.btMenuPrincipal.TabIndex = 15;
            this.btMenuPrincipal.Text = "MENU PRINCIPAL";
            this.btMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMenuPrincipal.UseVisualStyleBackColor = false;
            this.btMenuPrincipal.Click += new System.EventHandler(this.btMenuPrincipal_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-5, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 218);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // ControlCadastra
            // 
            this.ControlCadastra.Controls.Add(this.CadastroUsuario);
            this.ControlCadastra.Controls.Add(this.CadastroLivros);
            this.ControlCadastra.Location = new System.Drawing.Point(3, -22);
            this.ControlCadastra.Name = "ControlCadastra";
            this.ControlCadastra.SelectedIndex = 0;
            this.ControlCadastra.Size = new System.Drawing.Size(698, 470);
            this.ControlCadastra.TabIndex = 1;
            // 
            // CadastroUsuario
            // 
            this.CadastroUsuario.BackColor = System.Drawing.Color.Transparent;
            this.CadastroUsuario.Controls.Add(this.txtNome);
            this.CadastroUsuario.Controls.Add(this.txtCPF);
            this.CadastroUsuario.Controls.Add(this.list2);
            this.CadastroUsuario.Controls.Add(this.masktel);
            this.CadastroUsuario.Controls.Add(this.cFuncao);
            this.CadastroUsuario.Controls.Add(this.txtEmail);
            this.CadastroUsuario.Controls.Add(this.label5);
            this.CadastroUsuario.Controls.Add(this.label4);
            this.CadastroUsuario.Controls.Add(this.label3);
            this.CadastroUsuario.Controls.Add(this.label2);
            this.CadastroUsuario.Controls.Add(this.label1);
            this.CadastroUsuario.Controls.Add(this.btAddUser);
            this.CadastroUsuario.Location = new System.Drawing.Point(4, 22);
            this.CadastroUsuario.Name = "CadastroUsuario";
            this.CadastroUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.CadastroUsuario.Size = new System.Drawing.Size(690, 439);
            this.CadastroUsuario.TabIndex = 0;
            this.CadastroUsuario.Text = "CadastroUser";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(285, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(51, 6);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 0;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // list2
            // 
            this.list2.BackColor = System.Drawing.Color.White;
            this.list2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cCPF,
            this.cNome,
            this.cEmail,
            this.cTelefone,
            this.coFuncao});
            this.list2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list2.GridLines = true;
            this.list2.HideSelection = false;
            this.list2.Location = new System.Drawing.Point(-4, 163);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(698, 213);
            this.list2.TabIndex = 42;
            this.list2.UseCompatibleStateImageBehavior = false;
            this.list2.View = System.Windows.Forms.View.Details;
            // 
            // cCPF
            // 
            this.cCPF.Text = "CPF";
            this.cCPF.Width = 95;
            // 
            // cNome
            // 
            this.cNome.Text = "NOME";
            this.cNome.Width = 130;
            // 
            // cEmail
            // 
            this.cEmail.Text = "EMAIL";
            this.cEmail.Width = 147;
            // 
            // cTelefone
            // 
            this.cTelefone.Text = "TELEFONE";
            this.cTelefone.Width = 106;
            // 
            // coFuncao
            // 
            this.coFuncao.Text = "FUNÇÃO";
            this.coFuncao.Width = 297;
            // 
            // masktel
            // 
            this.masktel.Location = new System.Drawing.Point(79, 74);
            this.masktel.Mask = "(00)00000-0000";
            this.masktel.Name = "masktel";
            this.masktel.Size = new System.Drawing.Size(86, 20);
            this.masktel.TabIndex = 3;
            this.masktel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cFuncao
            // 
            this.cFuncao.FormattingEnabled = true;
            this.cFuncao.Items.AddRange(new object[] {
            "Professor",
            "Aluno",
            "Servidor"});
            this.cFuncao.Location = new System.Drawing.Point(73, 101);
            this.cFuncao.Name = "cFuncao";
            this.cFuncao.Size = new System.Drawing.Size(121, 21);
            this.cFuncao.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(51, 39);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Função: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Telefone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "CPF:";
            // 
            // btAddUser
            // 
            this.btAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btAddUser.FlatAppearance.BorderSize = 0;
            this.btAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btAddUser.Image")));
            this.btAddUser.Location = new System.Drawing.Point(519, 84);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(55, 52);
            this.btAddUser.TabIndex = 5;
            this.btAddUser.UseVisualStyleBackColor = false;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // CadastroLivros
            // 
            this.CadastroLivros.BackColor = System.Drawing.SystemColors.Control;
            this.CadastroLivros.Controls.Add(this.txtCOD);
            this.CadastroLivros.Controls.Add(this.lCOD);
            this.CadastroLivros.Controls.Add(this.list1);
            this.CadastroLivros.Controls.Add(this.btAddLivro);
            this.CadastroLivros.Controls.Add(this.label9);
            this.CadastroLivros.Controls.Add(this.txtISSN);
            this.CadastroLivros.Controls.Add(this.txtNumerodePaginas);
            this.CadastroLivros.Controls.Add(this.txtEditora);
            this.CadastroLivros.Controls.Add(this.cExemplares);
            this.CadastroLivros.Controls.Add(this.txtTitulo);
            this.CadastroLivros.Controls.Add(this.txtAutor);
            this.CadastroLivros.Controls.Add(this.label7);
            this.CadastroLivros.Controls.Add(this.label8);
            this.CadastroLivros.Controls.Add(this.lbnPag);
            this.CadastroLivros.Controls.Add(this.label10);
            this.CadastroLivros.Controls.Add(this.label11);
            this.CadastroLivros.Location = new System.Drawing.Point(4, 22);
            this.CadastroLivros.Name = "CadastroLivros";
            this.CadastroLivros.Padding = new System.Windows.Forms.Padding(3);
            this.CadastroLivros.Size = new System.Drawing.Size(690, 444);
            this.CadastroLivros.TabIndex = 1;
            this.CadastroLivros.Text = "CadastroLivro";
            // 
            // txtCOD
            // 
            this.txtCOD.Location = new System.Drawing.Point(71, 5);
            this.txtCOD.Name = "txtCOD";
            this.txtCOD.Size = new System.Drawing.Size(110, 20);
            this.txtCOD.TabIndex = 0;
            // 
            // lCOD
            // 
            this.lCOD.AutoSize = true;
            this.lCOD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCOD.Location = new System.Drawing.Point(5, 8);
            this.lCOD.Name = "lCOD";
            this.lCOD.Size = new System.Drawing.Size(60, 17);
            this.lCOD.TabIndex = 44;
            this.lCOD.Text = "Código:";
            // 
            // list1
            // 
            this.list1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cCOD,
            this.cTitulo,
            this.cAutor,
            this.cNPag,
            this.coExemplares,
            this.cEditora,
            this.coISSN});
            this.list1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list1.GridLines = true;
            this.list1.HideSelection = false;
            this.list1.Location = new System.Drawing.Point(-4, 159);
            this.list1.Name = "list1";
            this.list1.Scrollable = false;
            this.list1.Size = new System.Drawing.Size(695, 214);
            this.list1.TabIndex = 43;
            this.list1.UseCompatibleStateImageBehavior = false;
            this.list1.View = System.Windows.Forms.View.Details;
            // 
            // cCOD
            // 
            this.cCOD.Text = "CÓD";
            this.cCOD.Width = 48;
            // 
            // cTitulo
            // 
            this.cTitulo.Text = "TITULO";
            this.cTitulo.Width = 181;
            // 
            // cAutor
            // 
            this.cAutor.Text = "AUTOR";
            this.cAutor.Width = 125;
            // 
            // cNPag
            // 
            this.cNPag.Text = "Nº PÁG";
            // 
            // coExemplares
            // 
            this.coExemplares.Text = "EXEMPLARES";
            this.coExemplares.Width = 105;
            // 
            // cEditora
            // 
            this.cEditora.Text = "EDITORA";
            this.cEditora.Width = 66;
            // 
            // coISSN
            // 
            this.coISSN.Text = "ISSN";
            // 
            // btAddLivro
            // 
            this.btAddLivro.BackColor = System.Drawing.Color.Transparent;
            this.btAddLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddLivro.FlatAppearance.BorderSize = 0;
            this.btAddLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddLivro.Image = ((System.Drawing.Image)(resources.GetObject("btAddLivro.Image")));
            this.btAddLivro.Location = new System.Drawing.Point(473, 101);
            this.btAddLivro.Name = "btAddLivro";
            this.btAddLivro.Size = new System.Drawing.Size(55, 52);
            this.btAddLivro.TabIndex = 7;
            this.btAddLivro.UseVisualStyleBackColor = false;
            this.btAddLivro.Click += new System.EventHandler(this.btAddLivro_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "ISSN: ";
            // 
            // txtISSN
            // 
            this.txtISSN.Location = new System.Drawing.Point(58, 31);
            this.txtISSN.Name = "txtISSN";
            this.txtISSN.Size = new System.Drawing.Size(110, 20);
            this.txtISSN.TabIndex = 2;
            // 
            // txtNumerodePaginas
            // 
            this.txtNumerodePaginas.Location = new System.Drawing.Point(429, 7);
            this.txtNumerodePaginas.Name = "txtNumerodePaginas";
            this.txtNumerodePaginas.Size = new System.Drawing.Size(61, 20);
            this.txtNumerodePaginas.TabIndex = 1;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(354, 66);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(188, 20);
            this.txtEditora.TabIndex = 5;
            // 
            // cExemplares
            // 
            this.cExemplares.FormattingEnabled = true;
            this.cExemplares.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "+ 10"});
            this.cExemplares.Location = new System.Drawing.Point(384, 31);
            this.cExemplares.Name = "cExemplares";
            this.cExemplares.Size = new System.Drawing.Size(121, 21);
            this.cExemplares.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(58, 57);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(188, 20);
            this.txtTitulo.TabIndex = 4;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(58, 88);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(188, 20);
            this.txtAutor.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Editora: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(283, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Exemplares: ";
            // 
            // lbnPag
            // 
            this.lbnPag.AutoSize = true;
            this.lbnPag.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnPag.Location = new System.Drawing.Point(283, 6);
            this.lbnPag.Name = "lbnPag";
            this.lbnPag.Size = new System.Drawing.Size(140, 17);
            this.lbnPag.TabIndex = 30;
            this.lbnPag.Text = "Número de Páginas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Autor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Titulo: ";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.ControlCadastra);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(153, 48);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(698, 379);
            this.panel10.TabIndex = 43;
            // 
            // FormCadastra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 427);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIBLIOTECA VIRTUAL";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ControlCadastra.ResumeLayout(false);
            this.CadastroUsuario.ResumeLayout(false);
            this.CadastroUsuario.PerformLayout();
            this.CadastroLivros.ResumeLayout(false);
            this.CadastroLivros.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtISSN;
        private System.Windows.Forms.TextBox txtNumerodePaginas;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.ComboBox cExemplares;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbnPag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btAddLivro;
        public System.Windows.Forms.TabControl ControlCadastra;
        private System.Windows.Forms.MaskedTextBox masktel;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.ComboBox cFuncao;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddUser;
        public System.Windows.Forms.TabPage CadastroLivros;
        public System.Windows.Forms.TabPage CadastroUsuario;
        private System.Windows.Forms.ListView list2;
        private System.Windows.Forms.ColumnHeader cCPF;
        private System.Windows.Forms.ColumnHeader cNome;
        private System.Windows.Forms.ColumnHeader cEmail;
        private System.Windows.Forms.ColumnHeader cTelefone;
        private System.Windows.Forms.ColumnHeader coFuncao;
        private System.Windows.Forms.ListView list1;
        private System.Windows.Forms.ColumnHeader cCOD;
        private System.Windows.Forms.ColumnHeader cTitulo;
        private System.Windows.Forms.ColumnHeader cAutor;
        private System.Windows.Forms.ColumnHeader cNPag;
        private System.Windows.Forms.ColumnHeader coExemplares;
        private System.Windows.Forms.ColumnHeader cEditora;
        private System.Windows.Forms.TextBox txtCOD;
        private System.Windows.Forms.Label lCOD;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ColumnHeader coISSN;
        private System.Windows.Forms.Button btMenuPrincipal;
    }
}