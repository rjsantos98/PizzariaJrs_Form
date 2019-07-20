using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ClienteBLL
    {
        private ClienteDAL clienteDAL;

        public ClienteBLL()
        {
            clienteDAL = new ClienteDAL();
        }

        public void SalvarCliente(Cliente cliente)
        {
            clienteDAL.SalvarCliente(cliente);
        }

        public void AlterarCliente(Cliente cliente, string antigotelefone)
        {
            clienteDAL.AlterarCliente(cliente, antigotelefone);
        }

        public List<Cliente> GetClientes(string telefone)
        {
            return clienteDAL.ConsultarClientes(telefone);
        }

        public void ExcluirCliente(string telefone)
        {
            clienteDAL.ExcluirCliente(telefone);
        }

    }
}
