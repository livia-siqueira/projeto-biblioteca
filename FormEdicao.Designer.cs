namespace projeto_biblioteca_LiviaSiqueira
{
    partial class FormEdicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdicao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btMenuPrincipal = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Edicao = new System.Windows.Forms.TabControl();
            this.EditarLivro = new System.Windows.Forms.TabPage();
            this.pEditaDados = new System.Windows.Forms.Panel();
            this.BBuscarLivro = new System.Windows.Forms.Button();
            this.txtCODB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paEditaLivro = new System.Windows.Forms.Panel();
            this.txtCOD = new System.Windows.Forms.TextBox();
            this.lCOD = new System.Windows.Forms.Label();
            this.bEditaAutor = new System.Windows.Forms.Button();
            this.bNPag = new System.Windows.Forms.Button();
            this.bEditaExemplares = new System.Windows.Forms.Button();
            this.bEditaEditora = new System.Windows.Forms.Button();
            this.bEditaTitulo = new System.Windows.Forms.Button();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.cExemplares = new System.Windows.Forms.ComboBox();
            this.txtNpag = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtISSN = new System.Windows.Forms.TextBox();
            this.lbEditora = new System.Windows.Forms.Label();
            this.lbExemplares = new System.Windows.Forms.Label();
            this.lbNumeroPaginas = new System.Windows.Forms.Label();
            this.lbAu = new System.Windows.Forms.Label();
            this.lbTit = new System.Windows.Forms.Label();
            this.lbIssn = new System.Windows.Forms.Label();
            this.EditaUser = new System.Windows.Forms.TabPage();
            this.pEditUser = new System.Windows.Forms.Panel();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.bEditaFunc = new System.Windows.Forms.Button();
            this.bEditaTel = new System.Windows.Forms.Button();
            this.bEditaEmail = new System.Windows.Forms.Button();
            this.masktel = new System.Windows.Forms.MaskedTextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.cFuncao = new System.Windows.Forms.ComboBox();
            this.bEditaNome = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.lTelefone = new System.Windows.Forms.Label();
            this.lFuncao = new System.Windows.Forms.Label();
            this.pEditaUser = new System.Windows.Forms.Panel();
            this.txtBCPF = new System.Windows.Forms.MaskedTextBox();
            this.BBuscaUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btOKEDICAO = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Edicao.SuspendLayout();
            this.EditarLivro.SuspendLayout();
            this.pEditaDados.SuspendLayout();
            this.paEditaLivro.SuspendLayout();
            this.EditaUser.SuspendLayout();
            this.pEditUser.SuspendLayout();
            this.pEditaUser.SuspendLayout();
            this.panel11.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(625, 43);
            this.panel1.TabIndex = 3;
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
            this.btMinimizar.Location = new System.Drawing.Point(548, 12);
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
            this.btFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Location = new System.Drawing.Point(583, 12);
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
            this.panel9.Location = new System.Drawing.Point(0, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(143, 384);
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
            this.btMenuPrincipal.Location = new System.Drawing.Point(0, 264);
            this.btMenuPrincipal.Name = "btMenuPrincipal";
            this.btMenuPrincipal.Size = new System.Drawing.Size(145, 108);
            this.btMenuPrincipal.TabIndex = 16;
            this.btMenuPrincipal.Text = "MENU PRINCIPAL";
            this.btMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMenuPrincipal.UseVisualStyleBackColor = false;
            this.btMenuPrincipal.Click += new System.EventHandler(this.btMenuPrincipal_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-14, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 218);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Edicao
            // 
            this.Edicao.Controls.Add(this.EditarLivro);
            this.Edicao.Controls.Add(this.EditaUser);
            this.Edicao.Location = new System.Drawing.Point(3, -31);
            this.Edicao.Name = "Edicao";
            this.Edicao.SelectedIndex = 0;
            this.Edicao.Size = new System.Drawing.Size(476, 359);
            this.Edicao.TabIndex = 9;
            // 
            // EditarLivro
            // 
            this.EditarLivro.BackColor = System.Drawing.SystemColors.Control;
            this.EditarLivro.Controls.Add(this.pEditaDados);
            this.EditarLivro.Controls.Add(this.paEditaLivro);
            this.EditarLivro.Location = new System.Drawing.Point(4, 22);
            this.EditarLivro.Name = "EditarLivro";
            this.EditarLivro.Padding = new System.Windows.Forms.Padding(3);
            this.EditarLivro.Size = new System.Drawing.Size(468, 333);
            this.EditarLivro.TabIndex = 1;
            this.EditarLivro.Text = "tabPage2";
            // 
            // pEditaDados
            // 
            this.pEditaDados.Controls.Add(this.BBuscarLivro);
            this.pEditaDados.Controls.Add(this.txtCODB);
            this.pEditaDados.Controls.Add(this.label2);
            this.pEditaDados.Location = new System.Drawing.Point(-3, 7);
            this.pEditaDados.Name = "pEditaDados";
            this.pEditaDados.Size = new System.Drawing.Size(478, 53);
            this.pEditaDados.TabIndex = 9;
            // 
            // BBuscarLivro
            // 
            this.BBuscarLivro.BackColor = System.Drawing.Color.CadetBlue;
            this.BBuscarLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscarLivro.FlatAppearance.BorderSize = 0;
            this.BBuscarLivro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BBuscarLivro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BBuscarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarLivro.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarLivro.ForeColor = System.Drawing.Color.White;
            this.BBuscarLivro.Location = new System.Drawing.Point(279, 10);
            this.BBuscarLivro.Name = "BBuscarLivro";
            this.BBuscarLivro.Size = new System.Drawing.Size(75, 33);
            this.BBuscarLivro.TabIndex = 3;
            this.BBuscarLivro.Text = "Buscar";
            this.BBuscarLivro.UseVisualStyleBackColor = false;
            this.BBuscarLivro.Click += new System.EventHandler(this.BBuscarLivro_Click);
            // 
            // txtCODB
            // 
            this.txtCODB.Location = new System.Drawing.Point(192, 11);
            this.txtCODB.Name = "txtCODB";
            this.txtCODB.Size = new System.Drawing.Size(81, 20);
            this.txtCODB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "CÓD DO LIVRO:";
            // 
            // paEditaLivro
            // 
            this.paEditaLivro.Controls.Add(this.txtCOD);
            this.paEditaLivro.Controls.Add(this.lCOD);
            this.paEditaLivro.Controls.Add(this.bEditaAutor);
            this.paEditaLivro.Controls.Add(this.bNPag);
            this.paEditaLivro.Controls.Add(this.bEditaExemplares);
            this.paEditaLivro.Controls.Add(this.bEditaEditora);
            this.paEditaLivro.Controls.Add(this.bEditaTitulo);
            this.paEditaLivro.Controls.Add(this.txtEditora);
            this.paEditaLivro.Controls.Add(this.cExemplares);
            this.paEditaLivro.Controls.Add(this.txtNpag);
            this.paEditaLivro.Controls.Add(this.txtAutor);
            this.paEditaLivro.Controls.Add(this.txtTitulo);
            this.paEditaLivro.Controls.Add(this.txtISSN);
            this.paEditaLivro.Controls.Add(this.lbEditora);
            this.paEditaLivro.Controls.Add(this.lbExemplares);
            this.paEditaLivro.Controls.Add(this.lbNumeroPaginas);
            this.paEditaLivro.Controls.Add(this.lbAu);
            this.paEditaLivro.Controls.Add(this.lbTit);
            this.paEditaLivro.Controls.Add(this.lbIssn);
            this.paEditaLivro.Location = new System.Drawing.Point(0, 66);
            this.paEditaLivro.Name = "paEditaLivro";
            this.paEditaLivro.Size = new System.Drawing.Size(472, 267);
            this.paEditaLivro.TabIndex = 8;
            // 
            // txtCOD
            // 
            this.txtCOD.Location = new System.Drawing.Point(88, 3);
            this.txtCOD.Name = "txtCOD";
            this.txtCOD.Size = new System.Drawing.Size(110, 20);
            this.txtCOD.TabIndex = 40;
            // 
            // lCOD
            // 
            this.lCOD.AutoSize = true;
            this.lCOD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCOD.Location = new System.Drawing.Point(6, 3);
            this.lCOD.Name = "lCOD";
            this.lCOD.Size = new System.Drawing.Size(76, 17);
            this.lCOD.TabIndex = 39;
            this.lCOD.Text = "CÓDIGO:";
            // 
            // bEditaAutor
            // 
            this.bEditaAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditaAutor.FlatAppearance.BorderSize = 0;
            this.bEditaAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditaAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditaAutor.ForeColor = System.Drawing.Color.Blue;
            this.bEditaAutor.Location = new System.Drawing.Point(329, 82);
            this.bEditaAutor.Name = "bEditaAutor";
            this.bEditaAutor.Size = new System.Drawing.Size(54, 30);
            this.bEditaAutor.TabIndex = 38;
            this.bEditaAutor.Text = "Editar";
            this.bEditaAutor.UseVisualStyleBackColor = true;
            this.bEditaAutor.Click += new System.EventHandler(this.bEditaAutor_Click);
            // 
            // bNPag
            // 
            this.bNPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNPag.FlatAppearance.BorderSize = 0;
            this.bNPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNPag.ForeColor = System.Drawing.Color.Blue;
            this.bNPag.Location = new System.Drawing.Point(345, 118);
            this.bNPag.Name = "bNPag";
            this.bNPag.Size = new System.Drawing.Size(54, 30);
            this.bNPag.TabIndex = 37;
            this.bNPag.Text = "Editar";
            this.bNPag.UseVisualStyleBackColor = true;
            this.bNPag.Click += new System.EventHandler(this.bNPag_Click);
            // 
            // bEditaExemplares
            // 
            this.bEditaExemplares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditaExemplares.FlatAppearance.BorderSize = 0;
            this.bEditaExemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditaExemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditaExemplares.ForeColor = System.Drawing.Color.Blue;
            this.bEditaExemplares.Location = new System.Drawing.Point(292, 146);
            this.bEditaExemplares.Name = "bEditaExemplares";
            this.bEditaExemplares.Size = new System.Drawing.Size(54, 30);
            this.bEditaExemplares.TabIndex = 36;
            this.bEditaExemplares.Text = "Editar";
            this.bEditaExemplares.UseVisualStyleBackColor = true;
            this.bEditaExemplares.Click += new System.EventHandler(this.bEditaExemplares_Click);
            // 
            // bEditaEditora
            // 
            this.bEditaEditora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditaEditora.FlatAppearance.BorderSize = 0;
            this.bEditaEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditaEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditaEditora.ForeColor = System.Drawing.Color.Blue;
            this.bEditaEditora.Location = new System.Drawing.Point(326, 188);
            this.bEditaEditora.Name = "bEditaEditora";
            this.bEditaEditora.Size = new System.Drawing.Size(54, 30);
            this.bEditaEditora.TabIndex = 35;
            this.bEditaEditora.Text = "Editar";
            this.bEditaEditora.UseVisualStyleBackColor = true;
            this.bEditaEditora.Click += new System.EventHandler(this.bEditaEditora_Click);
            // 
            // bEditaTitulo
            // 
            this.bEditaTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditaTitulo.FlatAppearance.BorderSize = 0;
            this.bEditaTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditaTitulo.ForeColor = System.Drawing.Color.Blue;
            this.bEditaTitulo.Location = new System.Drawing.Point(329, 42);
            this.bEditaTitulo.Name = "bEditaTitulo";
            this.bEditaTitulo.Size = new System.Drawing.Size(54, 30);
            this.bEditaTitulo.TabIndex = 34;
            this.bEditaTitulo.Text = "Editar";
            this.bEditaTitulo.UseVisualStyleBackColor = true;
            this.bEditaTitulo.Click += new System.EventHandler(this.bEditaTitulo_Click_1);
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(156, 191);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(164, 20);
            this.txtEditora.TabIndex = 27;
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
            this.cExemplares.Location = new System.Drawing.Point(171, 149);
            this.cExemplares.Name = "cExemplares";
            this.cExemplares.Size = new System.Drawing.Size(121, 21);
            this.cExemplares.TabIndex = 26;
            // 
            // txtNpag
            // 
            this.txtNpag.Location = new System.Drawing.Point(225, 123);
            this.txtNpag.Name = "txtNpag";
            this.txtNpag.Size = new System.Drawing.Size(114, 20);
            this.txtNpag.TabIndex = 25;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(135, 89);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(188, 20);
            this.txtAutor.TabIndex = 24;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(135, 52);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(188, 20);
            this.txtTitulo.TabIndex = 23;
            // 
            // txtISSN
            // 
            this.txtISSN.Location = new System.Drawing.Point(266, 3);
            this.txtISSN.Name = "txtISSN";
            this.txtISSN.Size = new System.Drawing.Size(110, 20);
            this.txtISSN.TabIndex = 22;
            // 
            // lbEditora
            // 
            this.lbEditora.AutoSize = true;
            this.lbEditora.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditora.Location = new System.Drawing.Point(85, 191);
            this.lbEditora.Name = "lbEditora";
            this.lbEditora.Size = new System.Drawing.Size(65, 17);
            this.lbEditora.TabIndex = 21;
            this.lbEditora.Text = "Editora: ";
            // 
            // lbExemplares
            // 
            this.lbExemplares.AutoSize = true;
            this.lbExemplares.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExemplares.Location = new System.Drawing.Point(85, 153);
            this.lbExemplares.Name = "lbExemplares";
            this.lbExemplares.Size = new System.Drawing.Size(95, 17);
            this.lbExemplares.TabIndex = 20;
            this.lbExemplares.Text = "Exemplares: ";
            // 
            // lbNumeroPaginas
            // 
            this.lbNumeroPaginas.AutoSize = true;
            this.lbNumeroPaginas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroPaginas.Location = new System.Drawing.Point(85, 123);
            this.lbNumeroPaginas.Name = "lbNumeroPaginas";
            this.lbNumeroPaginas.Size = new System.Drawing.Size(140, 17);
            this.lbNumeroPaginas.TabIndex = 19;
            this.lbNumeroPaginas.Text = "Número de Páginas:";
            // 
            // lbAu
            // 
            this.lbAu.AutoSize = true;
            this.lbAu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAu.Location = new System.Drawing.Point(85, 92);
            this.lbAu.Name = "lbAu";
            this.lbAu.Size = new System.Drawing.Size(51, 17);
            this.lbAu.TabIndex = 18;
            this.lbAu.Text = "Autor:";
            // 
            // lbTit
            // 
            this.lbTit.AutoSize = true;
            this.lbTit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTit.Location = new System.Drawing.Point(85, 52);
            this.lbTit.Name = "lbTit";
            this.lbTit.Size = new System.Drawing.Size(56, 17);
            this.lbTit.TabIndex = 17;
            this.lbTit.Text = "Titulo: ";
            // 
            // lbIssn
            // 
            this.lbIssn.AutoSize = true;
            this.lbIssn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssn.Location = new System.Drawing.Point(218, 3);
            this.lbIssn.Name = "lbIssn";
            this.lbIssn.Size = new System.Drawing.Size(50, 17);
            this.lbIssn.TabIndex = 16;
            this.lbIssn.Text = "ISSN: ";
            // 
            // EditaUser
            // 
            this.EditaUser.BackColor = System.Drawing.SystemColors.Control;
            this.EditaUser.Controls.Add(this.pEditUser);
            this.EditaUser.Controls.Add(this.pEditaUser);
            this.EditaUser.Location = new System.Drawing.Point(4, 22);
            this.EditaUser.Name = "EditaUser";
            this.EditaUser.Padding = new System.Windows.Forms.Padding(3);
            this.EditaUser.Size = new System.Drawing.Size(471, 296);
            this.EditaUser.TabIndex = 0;
            this.EditaUser.Text = "tabPage1";
            // 
            // pEditUser
            // 
            this.pEditUser.Controls.Add(this.txtCPF);
            this.pEditUser.Controls.Add(this.bEditaFunc);
            this.pEditUser.Controls.Add(this.bEditaTel);
            this.pEditUser.Controls.Add(this.bEditaEmail);
            this.pEditUser.Controls.Add(this.masktel);
            this.pEditUser.Controls.Add(this.lbCPF);
            this.pEditUser.Controls.Add(this.cFuncao);
            this.pEditUser.Controls.Add(this.bEditaNome);
            this.pEditUser.Controls.Add(this.txtNome);
            this.pEditUser.Controls.Add(this.lNome);
            this.pEditUser.Controls.Add(this.txtEmail);
            this.pEditUser.Controls.Add(this.lEmail);
            this.pEditUser.Controls.Add(this.lTelefone);
            this.pEditUser.Controls.Add(this.lFuncao);
            this.pEditUser.Location = new System.Drawing.Point(6, 64);
            this.pEditUser.Name = "pEditUser";
            this.pEditUser.Size = new System.Drawing.Size(445, 239);
            this.pEditUser.TabIndex = 72;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(109, 16);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 69;
            // 
            // bEditaFunc
            // 
            this.bEditaFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditaFunc.FlatAppearance.BorderSize = 0;
            this.bEditaFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditaFunc.ForeColor = System.Drawing.Color.Blue;
            this.bEditaFunc.Location = new System.Drawing.Point(250, 150);
            this.bEditaFunc.Name = "bEditaFunc";
            this.bEditaFunc.Size = new System.Drawing.Size(54, 30);
            this.bEditaFunc.TabIndex = 66;
            this.bEditaFunc.Text = "Editar";
            this.bEditaFunc.UseVisualStyleBackColor = true;
            this.bEditaFunc.Click += new System.EventHandler(this.bEditaFunc_Click);
            // 
            // bEditaTel
            // 
            this.bEditaTel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditaTel.FlatAppearance.BorderSize = 0;
            this.bEditaTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditaTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditaTel.ForeColor = System.Drawing.Color.Blue;
            this.bEditaTel.Location = new System.Drawing.Point(235, 114);
            this.bEditaTel.Name = "bEditaTel";
            this.bEditaTel.Size = new System.Drawing.Size(54, 30);
            this.bEditaTel.TabIndex = 67;
            this.bEditaTel.Text = "Editar";
            this.bEditaTel.UseVisualStyleBackColor = true;
            this.bEditaTel.Click += new System.EventHandler(this.bEditaTel_Click);
            // 
            // bEditaEmail
            // 
            this.bEditaEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditaEmail.FlatAppearance.BorderSize = 0;
            this.bEditaEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditaEmail.ForeColor = System.Drawing.Color.Blue;
            this.bEditaEmail.Location = new System.Drawing.Point(303, 68);
            this.bEditaEmail.Name = "bEditaEmail";
            this.bEditaEmail.Size = new System.Drawing.Size(54, 30);
            this.bEditaEmail.TabIndex = 68;
            this.bEditaEmail.Text = "Editar";
            this.bEditaEmail.UseVisualStyleBackColor = true;
            this.bEditaEmail.Click += new System.EventHandler(this.bEditaEmail_Click);
            // 
            // masktel
            // 
            this.masktel.Location = new System.Drawing.Point(134, 114);
            this.masktel.Mask = "(00)00000-0000";
            this.masktel.Name = "masktel";
            this.masktel.Size = new System.Drawing.Size(95, 20);
            this.masktel.TabIndex = 71;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(63, 16);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(46, 17);
            this.lbCPF.TabIndex = 58;
            this.lbCPF.Text = "CPF: ";
            // 
            // cFuncao
            // 
            this.cFuncao.FormattingEnabled = true;
            this.cFuncao.Items.AddRange(new object[] {
            "Professor",
            "Aluno",
            "Servidor"});
            this.cFuncao.Location = new System.Drawing.Point(123, 155);
            this.cFuncao.Name = "cFuncao";
            this.cFuncao.Size = new System.Drawing.Size(121, 21);
            this.cFuncao.TabIndex = 70;
            // 
            // bEditaNome
            // 
            this.bEditaNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditaNome.FlatAppearance.BorderSize = 0;
            this.bEditaNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditaNome.ForeColor = System.Drawing.Color.Blue;
            this.bEditaNome.Location = new System.Drawing.Point(319, 38);
            this.bEditaNome.Name = "bEditaNome";
            this.bEditaNome.Size = new System.Drawing.Size(54, 30);
            this.bEditaNome.TabIndex = 65;
            this.bEditaNome.Text = "Editar";
            this.bEditaNome.UseVisualStyleBackColor = true;
            this.bEditaNome.Click += new System.EventHandler(this.bEditaNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(125, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(188, 20);
            this.txtNome.TabIndex = 63;
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNome.Location = new System.Drawing.Point(63, 45);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(56, 17);
            this.lNome.TabIndex = 59;
            this.lNome.Text = "Nome: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(109, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 20);
            this.txtEmail.TabIndex = 64;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(63, 75);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(54, 17);
            this.lEmail.TabIndex = 60;
            this.lEmail.Text = "Email: ";
            // 
            // lTelefone
            // 
            this.lTelefone.AutoSize = true;
            this.lTelefone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefone.Location = new System.Drawing.Point(63, 114);
            this.lTelefone.Name = "lTelefone";
            this.lTelefone.Size = new System.Drawing.Size(74, 17);
            this.lTelefone.TabIndex = 61;
            this.lTelefone.Text = "Telefone: ";
            // 
            // lFuncao
            // 
            this.lFuncao.AutoSize = true;
            this.lFuncao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFuncao.Location = new System.Drawing.Point(63, 159);
            this.lFuncao.Name = "lFuncao";
            this.lFuncao.Size = new System.Drawing.Size(55, 17);
            this.lFuncao.TabIndex = 62;
            this.lFuncao.Text = "Função";
            // 
            // pEditaUser
            // 
            this.pEditaUser.Controls.Add(this.txtBCPF);
            this.pEditaUser.Controls.Add(this.BBuscaUser);
            this.pEditaUser.Controls.Add(this.label1);
            this.pEditaUser.Location = new System.Drawing.Point(35, 6);
            this.pEditaUser.Name = "pEditaUser";
            this.pEditaUser.Size = new System.Drawing.Size(381, 52);
            this.pEditaUser.TabIndex = 57;
            // 
            // txtBCPF
            // 
            this.txtBCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtBCPF.Location = new System.Drawing.Point(197, 17);
            this.txtBCPF.Mask = "000.000.000-00";
            this.txtBCPF.Name = "txtBCPF";
            this.txtBCPF.Size = new System.Drawing.Size(100, 20);
            this.txtBCPF.TabIndex = 40;
            this.txtBCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // BBuscaUser
            // 
            this.BBuscaUser.BackColor = System.Drawing.Color.CadetBlue;
            this.BBuscaUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscaUser.FlatAppearance.BorderSize = 0;
            this.BBuscaUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BBuscaUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BBuscaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscaUser.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscaUser.ForeColor = System.Drawing.Color.White;
            this.BBuscaUser.Location = new System.Drawing.Point(303, 8);
            this.BBuscaUser.Name = "BBuscaUser";
            this.BBuscaUser.Size = new System.Drawing.Size(75, 33);
            this.BBuscaUser.TabIndex = 3;
            this.BBuscaUser.Text = "Buscar";
            this.BBuscaUser.UseVisualStyleBackColor = false;
            this.BBuscaUser.Click += new System.EventHandler(this.BBuscaUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF DO USUÁRIO:";
            // 
            // btOKEDICAO
            // 
            this.btOKEDICAO.BackColor = System.Drawing.Color.CadetBlue;
            this.btOKEDICAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOKEDICAO.FlatAppearance.BorderSize = 0;
            this.btOKEDICAO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btOKEDICAO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btOKEDICAO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOKEDICAO.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOKEDICAO.ForeColor = System.Drawing.Color.White;
            this.btOKEDICAO.Location = new System.Drawing.Point(366, 334);
            this.btOKEDICAO.Name = "btOKEDICAO";
            this.btOKEDICAO.Size = new System.Drawing.Size(104, 41);
            this.btOKEDICAO.TabIndex = 41;
            this.btOKEDICAO.Text = "SALVAR";
            this.btOKEDICAO.UseVisualStyleBackColor = false;
            this.btOKEDICAO.Click += new System.EventHandler(this.btOKEDICAO_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btOKEDICAO);
            this.panel11.Controls.Add(this.Edicao);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(143, 43);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(482, 384);
            this.panel11.TabIndex = 10;
            // 
            // FormEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 427);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEdicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEdicao";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Edicao.ResumeLayout(false);
            this.EditarLivro.ResumeLayout(false);
            this.pEditaDados.ResumeLayout(false);
            this.pEditaDados.PerformLayout();
            this.paEditaLivro.ResumeLayout(false);
            this.paEditaLivro.PerformLayout();
            this.EditaUser.ResumeLayout(false);
            this.pEditUser.ResumeLayout(false);
            this.pEditUser.PerformLayout();
            this.pEditaUser.ResumeLayout(false);
            this.pEditaUser.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox masktel;
        private System.Windows.Forms.ComboBox cFuncao;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button bEditaEmail;
        private System.Windows.Forms.Button bEditaTel;
        private System.Windows.Forms.Button bEditaFunc;
        private System.Windows.Forms.Button bEditaNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lFuncao;
        private System.Windows.Forms.Label lTelefone;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.Label lbCPF;
        public System.Windows.Forms.Panel pEditaUser;
        private System.Windows.Forms.MaskedTextBox txtBCPF;
        private System.Windows.Forms.Button BBuscaUser;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pEditaDados;
        private System.Windows.Forms.Button BBuscarLivro;
        private System.Windows.Forms.TextBox txtCODB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel paEditaLivro;
        private System.Windows.Forms.Button bEditaAutor;
        private System.Windows.Forms.Button bNPag;
        private System.Windows.Forms.Button bEditaExemplares;
        private System.Windows.Forms.Button bEditaEditora;
        private System.Windows.Forms.Button bEditaTitulo;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.ComboBox cExemplares;
        private System.Windows.Forms.TextBox txtNpag;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtISSN;
        private System.Windows.Forms.Label lbEditora;
        private System.Windows.Forms.Label lbExemplares;
        private System.Windows.Forms.Label lbNumeroPaginas;
        private System.Windows.Forms.Label lbAu;
        private System.Windows.Forms.Label lbTit;
        private System.Windows.Forms.Label lbIssn;
        private System.Windows.Forms.Panel pEditUser;
        public System.Windows.Forms.TabControl Edicao;
        public System.Windows.Forms.TabPage EditaUser;
        public System.Windows.Forms.TabPage EditarLivro;
        private System.Windows.Forms.TextBox txtCOD;
        private System.Windows.Forms.Label lCOD;
        private System.Windows.Forms.Button btMenuPrincipal;
        private System.Windows.Forms.Button btOKEDICAO;
        private System.Windows.Forms.Panel panel11;
    }
}