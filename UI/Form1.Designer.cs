namespace POO_3C1_25
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.dtg_Livros = new System.Windows.Forms.DataGridView();
            this.lbl_idlivro = new System.Windows.Forms.Label();
            this.txt_idLivro = new System.Windows.Forms.TextBox();
            this.lbl_idAutor = new System.Windows.Forms.Label();
            this.lbl_idEditora = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.txt_Numpag = new System.Windows.Forms.TextBox();
            this.lbl_numpag = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.cbx_idAutor = new System.Windows.Forms.ComboBox();
            this.cbx_idEditora = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.lbl_Pesquisa = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Livros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(274, 64);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(274, 104);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(274, 148);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 23);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // dtg_Livros
            // 
            this.dtg_Livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Livros.Location = new System.Drawing.Point(12, 202);
            this.dtg_Livros.Name = "dtg_Livros";
            this.dtg_Livros.Size = new System.Drawing.Size(585, 184);
            this.dtg_Livros.TabIndex = 4;
            this.dtg_Livros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Livros_CellContentClick);
            // 
            // lbl_idlivro
            // 
            this.lbl_idlivro.AutoSize = true;
            this.lbl_idlivro.Location = new System.Drawing.Point(12, 48);
            this.lbl_idlivro.Name = "lbl_idlivro";
            this.lbl_idlivro.Size = new System.Drawing.Size(48, 13);
            this.lbl_idlivro.TabIndex = 5;
            this.lbl_idlivro.Text = "Id - Livro";
            // 
            // txt_idLivro
            // 
            this.txt_idLivro.Enabled = false;
            this.txt_idLivro.Location = new System.Drawing.Point(12, 64);
            this.txt_idLivro.Name = "txt_idLivro";
            this.txt_idLivro.Size = new System.Drawing.Size(100, 20);
            this.txt_idLivro.TabIndex = 6;
            // 
            // lbl_idAutor
            // 
            this.lbl_idAutor.AutoSize = true;
            this.lbl_idAutor.Location = new System.Drawing.Point(12, 90);
            this.lbl_idAutor.Name = "lbl_idAutor";
            this.lbl_idAutor.Size = new System.Drawing.Size(50, 13);
            this.lbl_idAutor.TabIndex = 7;
            this.lbl_idAutor.Text = "Id - Autor";
            // 
            // lbl_idEditora
            // 
            this.lbl_idEditora.AutoSize = true;
            this.lbl_idEditora.Location = new System.Drawing.Point(12, 132);
            this.lbl_idEditora.Name = "lbl_idEditora";
            this.lbl_idEditora.Size = new System.Drawing.Size(58, 13);
            this.lbl_idEditora.TabIndex = 8;
            this.lbl_idEditora.Text = "Id - Editora";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(141, 48);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(35, 13);
            this.lbl_Titulo.TabIndex = 11;
            this.lbl_Titulo.Text = "Título";
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Location = new System.Drawing.Point(144, 64);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(100, 20);
            this.txt_Titulo.TabIndex = 12;
            // 
            // txt_Numpag
            // 
            this.txt_Numpag.Location = new System.Drawing.Point(144, 104);
            this.txt_Numpag.Name = "txt_Numpag";
            this.txt_Numpag.Size = new System.Drawing.Size(100, 20);
            this.txt_Numpag.TabIndex = 14;
            // 
            // lbl_numpag
            // 
            this.lbl_numpag.AutoSize = true;
            this.lbl_numpag.Location = new System.Drawing.Point(141, 90);
            this.lbl_numpag.Name = "lbl_numpag";
            this.lbl_numpag.Size = new System.Drawing.Size(75, 13);
            this.lbl_numpag.TabIndex = 16;
            this.lbl_numpag.Text = "Nº de Páginas";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(145, 132);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_Valor.TabIndex = 17;
            this.lbl_Valor.Text = "Valor";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(144, 148);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 18;
            // 
            // cbx_idAutor
            // 
            this.cbx_idAutor.FormattingEnabled = true;
            this.cbx_idAutor.Location = new System.Drawing.Point(12, 103);
            this.cbx_idAutor.Name = "cbx_idAutor";
            this.cbx_idAutor.Size = new System.Drawing.Size(100, 21);
            this.cbx_idAutor.TabIndex = 20;
            // 
            // cbx_idEditora
            // 
            this.cbx_idEditora.FormattingEnabled = true;
            this.cbx_idEditora.Location = new System.Drawing.Point(12, 148);
            this.cbx_idEditora.Name = "cbx_idEditora";
            this.cbx_idEditora.Size = new System.Drawing.Size(100, 21);
            this.cbx_idEditora.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(393, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 143);
            this.panel1.TabIndex = 22;
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Location = new System.Drawing.Point(12, 25);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(232, 20);
            this.txt_Pesquisar.TabIndex = 23;
            // 
            // lbl_Pesquisa
            // 
            this.lbl_Pesquisa.AutoSize = true;
            this.lbl_Pesquisa.Location = new System.Drawing.Point(12, 9);
            this.lbl_Pesquisa.Name = "lbl_Pesquisa";
            this.lbl_Pesquisa.Size = new System.Drawing.Size(56, 13);
            this.lbl_Pesquisa.TabIndex = 24;
            this.lbl_Pesquisa.Text = "Pesquisar:";
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(274, 25);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(100, 23);
            this.btn_Pesquisar.TabIndex = 25;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 398);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.lbl_Pesquisa);
            this.Controls.Add(this.txt_Pesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_idEditora);
            this.Controls.Add(this.cbx_idAutor);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.lbl_numpag);
            this.Controls.Add(this.txt_Numpag);
            this.Controls.Add(this.txt_Titulo);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_idEditora);
            this.Controls.Add(this.lbl_idAutor);
            this.Controls.Add(this.txt_idLivro);
            this.Controls.Add(this.lbl_idlivro);
            this.Controls.Add(this.dtg_Livros);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Livros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridView dtg_Livros;
        private System.Windows.Forms.Label lbl_idlivro;
        private System.Windows.Forms.TextBox txt_idLivro;
        private System.Windows.Forms.Label lbl_idAutor;
        private System.Windows.Forms.Label lbl_idEditora;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.TextBox txt_Numpag;
        private System.Windows.Forms.Label lbl_numpag;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.ComboBox cbx_idAutor;
        private System.Windows.Forms.ComboBox cbx_idEditora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.Label lbl_Pesquisa;
        private System.Windows.Forms.Button btn_Pesquisar;
    }
}

