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

        public Pedido ConsultarProdutosPedidos(Pedido pedido)
        {
            try
            {
                string select = @"SELECT PP.ID_PEDIDO, PP.ID_PRODUTO, PR.NM_PRODUTO, PR.DS_PRODUTO, PR.VAL_PRODUTO, PP.QT_PRODUTO, PP.VAL_UNIT";
                select += @" FROM PRODUTO_PEDIDO AS PP JOIN PRODUTO AS PR";
                select += @" ON PP.ID_PEDIDO = " + pedido.ID + " AND PP.ID_PRODUTO = PR.ID_PRODUTO";

                _cmd = new MySqlCommand(select, banco.AbrirConexao());
                MySqlDataReader dr;
                dr = _cmd.ExecuteReader();

                while (dr.Read())
                {
                    ProdutoPedido produto = new ProdutoPedido
                    {
                        Pedido = { ID = Convert.ToInt32(dr["ID_PEDIDO"]) },
                        Produto = { ID = Convert.ToInt32(dr["ID_PRODUTO"]), Nome = dr["NM_PRODUTO"].ToString()  },
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
            return pedido;
        }
    }
}
