using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using POO3B14045.DAL;
using POO3B14045.DTO;

namespace POO3B14045.BLL
{
    public class tblLivroBLL
    {
        private DALMysql dal = new DALMysql();
        public DataTable listarLivros()
        {
            string sql = string.Format($@"SELECT * FROM tbl_livro");
            return dal.executarConsulta(sql);
        }

        public void criarLivro(tblLivroDTO dados)
        {
            string sql = string.Format($@"INSERT INTO tbl_livro VALUES(NULL, '{dados.idAutor}', '{dados.idEditora}', '{dados.tituloLivro}', '{dados.dataCadastro.ToString("yyyy-MM-dd")}', '{dados.numPaginas}', '{dados.valorLivro}');");
            dal.executarComando(sql);
        }

        public void deletarLivro(tblLivroDTO dados)
        {
            string sql = string.Format($@"DELETE FROM tbl_livro where idLivro = {dados.idLivro};");
            dal.executarComando(sql);
        }

        public void atualizarLivro(tblLivroDTO dados)
        {
            string sql = string.Format($@"UPDATE tbl_livro SET idAutor = '{dados.idAutor}', idEditora = '{dados.idEditora}', titulo = '{dados.tituloLivro}', dataCadastro = '{dados.dataCadastro.ToString("yyyy-MM-dd")}', numPaginas = '{dados.numPaginas}', valor = '{dados.valorLivro}' WHERE idLivro = '{dados.idLivro}';");
            dal.executarComando(sql);
        }
    }
}