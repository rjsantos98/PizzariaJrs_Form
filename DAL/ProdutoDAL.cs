using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ProdutoDAL
    {
        Conexao banco = new Conexao();

        MySqlCommand _cmd;

        public void SalvarProduto(Produto produto)
        {
            try
            {
                string insert = @"insert into Produto(NM_PRODUTO, DS_PRODUTO, VAL_PRODUTO) values (UPPER('" + produto.Nome + "'), UPPER('" + produto.Descricao + "'),'" + produto.Valor.ToString() + "')";

                _cmd = new MySqlCommand(insert, banco.AbrirConexao());

                _cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
        public void AlterarProduto(Produto produto)
        {
            try
            {
                string update = @"Update Produto SET NM_PRODUTO = UPPER('" + produto.Nome + "'), DS_PRODUTO = UPPER('" + produto.Descricao + "'), VAL_PRODUTO = '" + produto.Valor + "' WHERE ID_PRODUTO = " + produto.ID.ToString();

                _cmd = new MySqlCommand(update, banco.AbrirConexao());

                _cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
        public List<Produto> ConsultarProdutos(string nome)
        {
            string select = @"Select ID_PRODUTO, NM_PRODUTO, DS_PRODUTO, VAL_PRODUTO FROM PRODUTO WHERE NM_PRODUTO like '%" + nome + "%'";
            List<Produto> produtos = new List<Produto>();

            try
            {

                _cmd = new MySqlCommand(select, banco.AbrirConexao());

                MySqlDataReader dr;

                dr = _cmd.ExecuteReader();

                while (dr.Read())
                {
                    Produto produto = new Produto
                    {
                        ID = Convert.ToInt32(dr["ID_PRODUTO"]),
                        Nome = dr["NM_PRODUTO"].ToString(),
                        Descricao = dr["DS_PRODUTO"].ToString(),
                        Valor = Convert.ToDouble(dr["VAL_PRODUTO"])
                    };

                    produtos.Add(produto);
                }
            }
            finally
            {
                banco.FecharConexao();
            }
            return produtos;
        }
        public void ExcluirProduto(int idProduto)
        {
            try
            {
                string delete = @"DELETE FROM PRODUTO WHERE ID_PRODUTO = " + idProduto.ToString();

                _cmd = new MySqlCommand(delete, banco.AbrirConexao());
                _cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
    }
}
