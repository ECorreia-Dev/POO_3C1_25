using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO_3C1_25.BLL;
using POO_3C1_25.DTO;

namespace POO_3C1_25
{
    public partial class Form1 : Form
    {

        BLL_Livro bllLivro = new BLL_Livro();
        DTO_Livro dtoLivro = new DTO_Livro();


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            dtg_Livros.DataSource = bllLivro.ListarLivros();
        } 
        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                // Passagem dos dados da UI para o DTO
                dtoLivro.IdAutor = int.Parse(txt_idAutor.Text);
                dtoLivro.IdEditora = int.Parse(txt_idEditora.Text);
                dtoLivro.Titulo = txt_Titulo.Text.ToString();
                dtoLivro.DataCadastro = dtp_Datacad.Value; // Erro
                dtoLivro.NumPaginas = int.Parse(txt_Numpag.Text);
                dtoLivro.Valor = int.Parse(txt_Valor.Text);


                bllLivro.InserirLivros(dtoLivro);
                MessageBox.Show("Livro inserido com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_Livros.DataSource = bllLivro.ListarLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Passagem dos dados da UI para o DTO
                dtoLivro.IdAutor = int.Parse(txt_idAutor.Text);
                dtoLivro.IdEditora = int.Parse(txt_idEditora.Text);
                dtoLivro.Titulo = txt_Titulo.Text.ToString();
                dtoLivro.DataCadastro = dtp_Datacad.Value; // Erro
                dtoLivro.NumPaginas = int.Parse(txt_Numpag.Text);
                dtoLivro.Valor = int.Parse(txt_Valor.Text);


                bllLivro.InserirLivros(dtoLivro);
                MessageBox.Show("Livro alterado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_Livros.DataSource = bllLivro.ListarLivros();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeita, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoLivro.IdLivro = Convert.ToInt32(txt_idLivro.Text);
                    bllLivro.ExcluirLivros(dtoLivro);
                    dtg_Livros.DataSource = bllLivro.ListarLivros();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtg_Livros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idLivro.Text = dtg_Livros.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_idAutor.Text = dtg_Livros.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_idEditora.Text = dtg_Livros.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Titulo.Text = dtg_Livros.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtp_Datacad.Text = dtg_Livros.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Numpag.Text = dtg_Livros.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_Valor.Text = dtg_Livros.Rows[e.RowIndex].Cells[6].Value.ToString();
            // Habilitar o botao Excluir
            this.btnDeletar.Enabled = true;
            btnEditar.Enabled = true;
        }
    }
}
