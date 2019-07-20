using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Pedido
    {
        public int ID { get; set; }
        public Cliente Cliente { get; set; }
        public string Observacao { get; set; }
        public DateTime DataEfetuada { get; set; }
        public DateTime DataEntregue { get; set; }
        public Status StatusPedido { get; set; }
        public double ValorTotal { get; set; }

        public List<ProdutoPedido> produtoPedidos = new List<ProdutoPedido>();
    }
}
