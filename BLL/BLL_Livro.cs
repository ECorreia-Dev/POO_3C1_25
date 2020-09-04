using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using POO_3C1_25.DAL;
using POO_3C1_25.DTO;

namespace POO_3C1_25.BLL
{
    class BLL_Livro
    {

        private DAL_Livro DaoLivro = new DAL_Livro();

        public DataTable PesquisarLivros(string condicao)
        {
            string sql = string.Format($@"select * from tbl_livro where " + condicao);
            return DaoLivro.executarConsulta(sql);
        }

        public DataTable ListarLivros()
        {
            string sql = string.Format($@"select * from tbl_livro");
            return DaoLivro.executarConsulta(sql);
        }

        public void InserirLivros(DTO_Livro ObjLivro)
        {
            string sql = string.Format($@"INSERT INTO tbl_livro VALUES (NULL,'{ObjLivro.IdAutor}',
                                                                          '{ObjLivro.IdEditora}',
                                                                          '{ObjLivro.Titulo}',
                                                                          '{ObjLivro.NumPaginas}',
                                                                           '{ObjLivro.Valor}');");
            DaoLivro.executarComando(sql);

        }

        public void AlterarLivros(DTO_Livro objLivro)
        {
            string sql = string.Format($@"UPDATE tbl_livro set idAutor = '{objLivro.IdAutor}',
                                                               idEditora = '{objLivro.IdEditora}',
                                                               titulo = '{objLivro.Titulo}',
                                                               numPaginas ='{objLivro.NumPaginas}',
                                                               valor ='{objLivro.Valor}'
                                                 where idLivro = '{objLivro.IdLivro}';");
            DaoLivro.executarComando(sql);

        }

        public void ExcluirLivros(DTO_Livro objLivro)
        {
            string sql = string.Format($@"DELETE FROM tbl_Livro where idLivro = {objLivro.IdLivro};");
            DaoLivro.executarComando(sql);
        }



    }
}
