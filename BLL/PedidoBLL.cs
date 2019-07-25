using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PedidoBLL
    {
        private PedidoDAL pedidoDAL;

        public PedidoBLL()
        {
            pedidoDAL = new PedidoDAL();
        }

        public void SalvarPedido(Pedido pedido)
        {
            pedidoDAL.SalvarPedido(pedido);
        }
        public List<Pedido> ConsultarPedidosPorData(string data)
        {
            return pedidoDAL.ConsultarPedidosPorData(data);
        }
        public List<Pedido> ConsultarPedidosPorTelefone(Pedido pedido)
        {
            return pedidoDAL.ConsultarPedidosPorTelefone(pedido);
        }

        public void AlterarPedido(Pedido pedido)
        {
            pedidoDAL.AlterarPedido(pedido);
        }
        public int GetID()
        {
            return pedidoDAL.GetID();
        }

    }
}
