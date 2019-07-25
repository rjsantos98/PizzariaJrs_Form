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
        public string DataEfetuada { get; set; }
        public string DataEntregue { get; set; }
        public Status StatusPedido { get; set; }
        public double ValorTotal { get; set; }
        public List<ProdutoPedido> listProdutoPedidos;

        public Pedido()
        {
            Cliente = new Cliente{ };
            StatusPedido = new Status { };
            listProdutoPedidos = new List<ProdutoPedido>();
        }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
