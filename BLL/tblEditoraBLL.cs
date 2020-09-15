using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using POO3B14045.DAL;
using POO3B14045.DTO;

namespace POO3B14045.BLL
{
    public class tblEditoraBLL
    {
        private DALMysql dal = new DALMysql();
        public DataTable listarEditoras()
        {
            string sql = string.Format($@"SELECT * FROM tbl_editora");
            return dal.executarConsulta(sql);
        }

        public void criarEditora(tblEditoraDTO dados)
        {
            string sql = string.Format($@"INSERT INTO tbl_editora VALUES (NULL, '{dados.nomeEditora}', '{dados.enderecoEditora}', '{dados.ufEditora}');");
            dal.executarConsulta(sql);
        }

        public void deletarEditora(tblEditoraDTO dados)
        {
            string query = string.Format($@"DELETE FROM tbl_editora where id = {dados.idEditora};");
            dal.executarComando(query);
        }

        public void atualizarEditora(tblEditoraDTO dados)
        {
            string query = string.Format($@"UPDATE tbl_editora SET nome = '{dados.nomeEditora}', endereco = '{dados.enderecoEditora}', UF = '{dados.ufEditora}' ) WHERE id = {dados.idEditora};");
            dal.executarComando(query);
        }
    }   
}