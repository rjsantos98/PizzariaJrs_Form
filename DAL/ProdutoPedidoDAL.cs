using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ProdutoPedidoDAL
    {
        Conexao banco = new Conexao();
        MySqlCommand _cmd;

        public List<ProdutoPedido> ConsultarProdutosPedidos(Pedido pedido)
        {
            try
            {
                string select = @"select pe.ID_PEDIDO, pr.ID_PRODUTO, pp.QT_PRODUTO, pp.VAL_UNIT";
                select += @" from PRODUTO_PEDIDO as pp JOIN PRODUTO as pr JOIN PEDIDO as pe";
                select += @" WHERE pe.ID_PEDIDO = " + pedido.ID + " AND pp.ID_PRODUTO = pr.ID_PRODUTO";

                _cmd = new MySqlCommand(select, banco.AbrirConexao());
                MySqlDataReader dr;
                dr = _cmd.ExecuteReader();

                while (dr.Read())
                {
                    ProdutoPedido produto = new ProdutoPedido
                    {
                        Pedido = { ID = Convert.ToInt32(dr["ID_PEDIDO"]) },
                        Produto = { ID = Convert.ToInt32(dr["ID_PRODUTO"]), Nome = dr["NM_PRODUTO"].ToString() },
                        Quantidade = Convert.ToInt32(dr["QT_PRODUTO"]),
                        Valor = Convert.ToDouble(dr["VAL_UNIT"])
                    };
                    pedido.produtoPedidos.Add(produto);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                banco.FecharConexao();
            }
            return pedido.produtoPedidos;
        }
    }
}
