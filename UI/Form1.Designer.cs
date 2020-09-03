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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.dtg_Livros = new System.Windows.Forms.DataGridView();
            this.lbl_idlivro = new System.Windows.Forms.Label();
            this.txt_idLivro = new System.Windows.Forms.TextBox();
            this.lbl_idAutor = new System.Windows.Forms.Label();
            this.lbl_idEditora = new System.Windows.Forms.Label();
            this.txt_idAutor = new System.Windows.Forms.TextBox();
            this.txt_idEditora = new System.Windows.Forms.TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.txt_Numpag = new System.Windows.Forms.TextBox();
            this.lbl_datacad = new System.Windows.Forms.Label();
            this.lbl_numpag = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.dtp_Datacad = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Livros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(275, 25);
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
            this.btnEditar.Location = new System.Drawing.Point(275, 67);
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
            this.btnDeletar.Location = new System.Drawing.Point(275, 106);
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
            this.dtg_Livros.Location = new System.Drawing.Point(12, 172);
            this.dtg_Livros.Name = "dtg_Livros";
            this.dtg_Livros.Size = new System.Drawing.Size(363, 143);
            this.dtg_Livros.TabIndex = 4;
            this.dtg_Livros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Livros_CellContentClick);
            // 
            // lbl_idlivro
            // 
            this.lbl_idlivro.AutoSize = true;
            this.lbl_idlivro.Location = new System.Drawing.Point(12, 9);
            this.lbl_idlivro.Name = "lbl_idlivro";
            this.lbl_idlivro.Size = new System.Drawing.Size(48, 13);
            this.lbl_idlivro.TabIndex = 5;
            this.lbl_idlivro.Text = "Id - Livro";
            // 
            // txt_idLivro
            // 
            this.txt_idLivro.Enabled = false;
            this.txt_idLivro.Location = new System.Drawing.Point(12, 25);
            this.txt_idLivro.Name = "txt_idLivro";
            this.txt_idLivro.Size = new System.Drawing.Size(100, 20);
            this.txt_idLivro.TabIndex = 6;
            // 
            // lbl_idAutor
            // 
            this.lbl_idAutor.AutoSize = true;
            this.lbl_idAutor.Location = new System.Drawing.Point(12, 51);
            this.lbl_idAutor.Name = "lbl_idAutor";
            this.lbl_idAutor.Size = new System.Drawing.Size(50, 13);
            this.lbl_idAutor.TabIndex = 7;
            this.lbl_idAutor.Text = "Id - Autor";
            // 
            // lbl_idEditora
            // 
            this.lbl_idEditora.AutoSize = true;
            this.lbl_idEditora.Location = new System.Drawing.Point(12, 90);
            this.lbl_idEditora.Name = "lbl_idEditora";
            this.lbl_idEditora.Size = new System.Drawing.Size(58, 13);
            this.lbl_idEditora.TabIndex = 8;
            this.lbl_idEditora.Text = "Id - Editora";
            // 
            // txt_idAutor
            // 
            this.txt_idAutor.Enabled = false;
            this.txt_idAutor.Location = new System.Drawing.Point(12, 67);
            this.txt_idAutor.Name = "txt_idAutor";
            this.txt_idAutor.Size = new System.Drawing.Size(100, 20);
            this.txt_idAutor.TabIndex = 9;
            // 
            // txt_idEditora
            // 
            this.txt_idEditora.Enabled = false;
            this.txt_idEditora.Location = new System.Drawing.Point(12, 106);
            this.txt_idEditora.Name = "txt_idEditora";
            this.txt_idEditora.Size = new System.Drawing.Size(100, 20);
            this.txt_idEditora.TabIndex = 10;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(141, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(35, 13);
            this.lbl_Titulo.TabIndex = 11;
            this.lbl_Titulo.Text = "Título";
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Location = new System.Drawing.Point(144, 25);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(100, 20);
            this.txt_Titulo.TabIndex = 12;
            // 
            // txt_Numpag
            // 
            this.txt_Numpag.Location = new System.Drawing.Point(144, 106);
            this.txt_Numpag.Name = "txt_Numpag";
            this.txt_Numpag.Size = new System.Drawing.Size(100, 20);
            this.txt_Numpag.TabIndex = 14;
            // 
            // lbl_datacad
            // 
            this.lbl_datacad.AutoSize = true;
            this.lbl_datacad.Location = new System.Drawing.Point(141, 51);
            this.lbl_datacad.Name = "lbl_datacad";
            this.lbl_datacad.Size = new System.Drawing.Size(90, 13);
            this.lbl_datacad.TabIndex = 15;
            this.lbl_datacad.Text = "Data de Cadastro";
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
            this.lbl_Valor.Location = new System.Drawing.Point(141, 129);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_Valor.TabIndex = 17;
            this.lbl_Valor.Text = "Valor";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(144, 145);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 18;
            // 
            // dtp_Datacad
            // 
            this.dtp_Datacad.Location = new System.Drawing.Point(144, 66);
            this.dtp_Datacad.Name = "dtp_Datacad";
            this.dtp_Datacad.Size = new System.Drawing.Size(100, 20);
            this.dtp_Datacad.TabIndex = 19;
            this.dtp_Datacad.Value = new System.DateTime(2020, 9, 2, 22, 56, 14, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 324);
            this.Controls.Add(this.dtp_Datacad);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.lbl_numpag);
            this.Controls.Add(this.lbl_datacad);
            this.Controls.Add(this.txt_Numpag);
            this.Controls.Add(this.txt_Titulo);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.txt_idEditora);
            this.Controls.Add(this.txt_idAutor);
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
        private System.Windows.Forms.TextBox txt_idAutor;
        private System.Windows.Forms.TextBox txt_idEditora;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.TextBox txt_Numpag;
        private System.Windows.Forms.Label lbl_datacad;
        private System.Windows.Forms.Label lbl_numpag;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.DateTimePicker dtp_Datacad;
    }
}

