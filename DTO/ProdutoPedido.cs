using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProdutoPedido
    {
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public ProdutoPedido()
        {
            Pedido = new Pedido { };
            Produto = new Produto { };
        }
    }
}
