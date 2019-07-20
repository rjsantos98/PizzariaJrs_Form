using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PedidoDAL
    {
        Conexao banco = new Conexao();

        MySqlCommand _cmd;

        public void SalvarPedido(Pedido pedido)
        {
            string insert = @"insert to into Pedido(CD_TELEFONE, DS_OBSERVACAO, DT_EFETUADO, DT_ENTREGUE, ID_STATUS_PEDIDO, VAL_TOTAL) ";
            insert += @"values ('" + pedido.Cliente.Telefone + "', '" + pedido.Observacao + "', '" + pedido.DataEfetuada +
                      "', '" + pedido.DataEntregue + "', '" + pedido.StatusPedido.ID + "', " + pedido.ValorTotal + ")";
            try
            {
                _cmd = new MySqlCommand(insert, banco.AbrirConexao());
                _cmd.ExecuteNonQuery();

                foreach (ProdutoPedido produto in pedido.produtoPedidos)
                {
                    string insertprod = "insert into ProdutoPedido(ID_PEDIDO, ID_PRODUTO, QT_PRODUTO, VAL_UNIT)";
                    insertprod += " values(" + produto.Pedido.ID + ", " + produto.Produto.ID + ", " + produto.Quantidade + ", " + produto.Valor + ")";

                    _cmd = new MySqlCommand(insertprod, banco.AbrirConexao());

                    _cmd.ExecuteNonQuery();
                }

            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                banco.FecharConexao();
            }

        }

        public void AlterarPedido(Pedido pedido)
        {
            try
            {
                string update = @"update Pedido set CD_TELEFONE = '" + pedido.Cliente.Telefone + "', DS_OBSERVACAO = '" + pedido.Observacao +
                                "', DT_ENTREGUE = '" + pedido.DataEntregue + "', ID_STATUS_PEDIDO = '" + pedido.StatusPedido.ID +
                                "', VAL_TOTAL = " + pedido.ValorTotal + " WHERE ID_PEDIDO = " + pedido.ID;

                _cmd = new MySqlCommand(update, banco.AbrirConexao());

                _cmd.ExecuteNonQuery();

                string delete = "DELETE FROM PRODUTO_PEDIDO WHERE ID_PEDIDO = " + pedido.ID + ";";
                MySqlCommand commando = new MySqlCommand(delete, banco.AbrirConexao());
                commando.ExecuteNonQuery();

                foreach (ProdutoPedido produto in pedido.produtoPedidos)
                {
                    string insertprod = "insert into ProdutoPedido(ID_PEDIDO, ID_PRODUTO, QT_PRODUTO, VAL_UNIT)";
                    insertprod += " values(" + produto.Pedido.ID + ", " + produto.Produto.ID + ", " + produto.Quantidade + ", " + produto.Valor + ")";

                    _cmd = new MySqlCommand(insertprod, banco.AbrirConexao());

                    _cmd.ExecuteNonQuery();
                }
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

        public List<Pedido> ConsultarPedidos(string telefone)
        {
            string select = @"select PED.ID_PEDIDO, U.CD_TELEFONE, PED.DS_OBSERVACAO, PED.DT_EFETUADO, PED.DT_ENTREGUE, ST.ID_STATUS_PEDIDO, PED.VAL_TOTAL";
            select += @" FROM PEDIDO AS PED";
            select += @" JOIN CLIENTE AS U";
            select += @" JOIN STATUS_PEDIDO AS ST";
            select += @" WHERE U.CD_TELEFONE LIKE = '%" + telefone + "%'";

            List<Pedido> pedidos = new List<Pedido>();

            try
            {
                _cmd = new MySqlCommand(select, banco.AbrirConexao());

                MySqlDataReader dr;

                dr = _cmd.ExecuteReader();

                while (dr.Read())
                {
                    Pedido pedido = new Pedido
                    {
                        ID = Convert.ToInt32(dr["ID_PEDIDO"]),
                        Cliente = { Nome = dr["NM_CLIENTE"].ToString(), Telefone = dr["CD_TELEFONE"].ToString() },
                        Observacao = dr["DS_OBSERVACAO"].ToString(),
                        DataEfetuada = Convert.ToDateTime(dr["DT_EFETUADO"]),
                        DataEntregue = Convert.ToDateTime(dr["DT_ENTREGUE"]),
                        StatusPedido = { ID = Convert.ToInt32(dr["ID_STATUS"]), Nome = dr["NM_STATUS"].ToString() },
                        ValorTotal = Convert.ToDouble(dr["VAL_TOTAL"])
                    };
                    pedidos.Add(pedido);
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                banco.FecharConexao();
            }
            return pedidos;
        }

        public void ExcluirPedido(Pedido pedido)
        {
            string delete = @"DELETE FROM PEDIDO WHERE CD_TELEFONE = " + pedido.Cliente.Telefone;


            string deleteproduto = "DELETE FROM PRODUTO_PEDIDO WHERE ID_PEDIDO = " + pedido.ID + ";";
            MySqlCommand commando = new MySqlCommand(deleteproduto, banco.AbrirConexao());
            commando.ExecuteNonQuery();

            try
            {
                _cmd = new MySqlCommand(delete, banco.AbrirConexao());
                _cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
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
