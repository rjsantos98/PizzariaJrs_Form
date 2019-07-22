using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class ProdutoPedidoBLL
    {
        ProdutoPedidoDAL produtoPedidoDAL;

        public ProdutoPedidoBLL()
        {
            produtoPedidoDAL = new ProdutoPedidoDAL();
        }

        public Pedido ConsultarProdutosPedidos(Pedido pedido)
        {
            return produtoPedidoDAL.ConsultarProdutosPedidos(pedido);
        }
    }
}
