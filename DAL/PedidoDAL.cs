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
            string insert = @"insert into Pedido(ID_PEDIDO, CD_TELEFONE_CLIENTE, DS_OBSERVACAO, DT_EFETUADO, ID_STATUS_PEDIDO, VAL_TOTAL) ";
            insert += @"values ('" + pedido.ID + "', '" + pedido.Cliente.Telefone + "', '" + pedido.Observacao + "', '" + pedido.DataEfetuada +
                      "', '" + pedido.StatusPedido.ID + "', " + pedido.ValorTotal + ")";
            try
            {
                _cmd = new MySqlCommand(insert, banco.AbrirConexao());
                _cmd.ExecuteNonQuery();

                foreach (ProdutoPedido produto in pedido.listProdutoPedidos)
                {
                    string insertprod = "insert into PRODUTO_PEDIDO(ID_PEDIDO, ID_PRODUTO, QT_PRODUTO, VAL_UNIT)";
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
                string update = @"update Pedido set CD_TELEFONE_CLIENTE = '" + pedido.Cliente.Telefone + "', DS_OBSERVACAO = '" + pedido.Observacao +
                "', "+DataReturn(pedido.DataEntregue)+" ID_STATUS_PEDIDO = '" + pedido.StatusPedido.ID +
                "', VAL_TOTAL = " + pedido.ValorTotal + " WHERE ID_PEDIDO = " + pedido.ID;

                _cmd = new MySqlCommand(update, banco.AbrirConexao());

                _cmd.ExecuteNonQuery();

                string delete = "DELETE FROM PRODUTO_PEDIDO WHERE ID_PEDIDO = " + pedido.ID + ";";
                MySqlCommand commando = new MySqlCommand(delete, banco.AbrirConexao());
                commando.ExecuteNonQuery();

                foreach (ProdutoPedido produto in pedido.listProdutoPedidos)
                {
                    string insertprod = "insert into Produto_Pedido(ID_PEDIDO, ID_PRODUTO, QT_PRODUTO, VAL_UNIT)";
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
        public List<Pedido> ConsultarPedidosPorData(string data)
        {
            string select = @"SELECT PE.ID_PEDIDO, CL.NM_CLIENTE, CL.CD_TELEFONE, PE.DS_OBSERVACAO, PE.DT_EFETUADO, PE.DT_ENTREGUE, ST.ID_STATUS, ST.NM_STATUS, PE.VAL_TOTAL ";
            select += "FROM PEDIDO AS PE ";
            select += "JOIN CLIENTE AS CL ";
            select += "JOIN STATUS_PEDIDO AS ST ";
            select += "ON PE.CD_TELEFONE_CLIENTE = CL.CD_TELEFONE AND PE.ID_STATUS_PEDIDO = ST.ID_STATUS ";
            select += "WHERE PE.DT_EFETUADO BETWEEN '" + data + " 00:00:00' AND '" + data + " 23:59:59'";

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
                        Cliente = { Nome = dr["NM_CLIENTE"].ToString(), Telefone = dr["CD_TELEFONE"].ToString(), CEP = "", Bairro = "", Endereco = "", Numero = "", Complemento = "" },
                        Observacao = dr["DS_OBSERVACAO"].ToString(),
                        DataEfetuada = Convert.ToString(dr["DT_EFETUADO"]),
                        DataEntregue = Convert.ToString(dr["DT_ENTREGUE"]),
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

        public List<Pedido> ConsultarPedidosPorTelefone(Pedido pedid)
        {
            string select = @"SELECT PE.ID_PEDIDO, CL.NM_CLIENTE, CL.CD_TELEFONE, PE.DS_OBSERVACAO, PE.DT_EFETUADO, PE.DT_ENTREGUE, ST.ID_STATUS, ST.NM_STATUS, PE.VAL_TOTAL ";
            select += "FROM PEDIDO AS PE ";
            select += "JOIN CLIENTE AS CL ";
            select += "JOIN STATUS_PEDIDO AS ST ";
            select += "ON PE.CD_TELEFONE_CLIENTE = CL.CD_TELEFONE AND PE.ID_STATUS_PEDIDO = ST.ID_STATUS ";
            select += "WHERE PE.CD_TELEFONE_CLIENTE LIKE '%" + pedid.Cliente.Telefone + "%' OR PE.ID_PEDIDO = " + pedid.ID;

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
                        Cliente = { Nome = dr["NM_CLIENTE"].ToString(), Telefone = dr["CD_TELEFONE"].ToString(), CEP = "", Bairro = "", Endereco = "", Numero = "", Complemento = "" },
                        Observacao = dr["DS_OBSERVACAO"].ToString(),
                        DataEfetuada = Convert.ToString(dr["DT_EFETUADO"]),
                        DataEntregue = Convert.ToString(dr["DT_ENTREGUE"]),
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

        public int GetID()
        {
            int codped = -1;
            string SQL;

            try
            {
                SQL = "SELECT IFNULL(MAX(ID_PEDIDO)+1, 1) FROM Pedido;";
                MySqlCommand comando = new MySqlCommand(SQL, banco.AbrirConexao());
                codped = Convert.ToInt32(comando.ExecuteScalar());

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                banco.FecharConexao();
            }

            return codped;
        }
        
        private string DataReturn(string dataEntregue)
        {
            if (dataEntregue == null)
                return null;
            else
                return "DT_ENTREGUE = '" + dataEntregue + "', ";
            
        }
    }
}
