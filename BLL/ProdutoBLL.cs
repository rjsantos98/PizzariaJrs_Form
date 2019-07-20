using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ProdutoBLL
    {
        private ProdutoDAL produtoDAL;

        public ProdutoBLL()
        {
            produtoDAL = new ProdutoDAL();
        }

        public void SalvarProduto(Produto produto)
        {
            produtoDAL.SalvarProduto(produto);
        }

        public List<Produto> ConsultarProdutor(string nome)
        {
            return produtoDAL.ConsultarProdutos(nome);
        }

        public void AlterarProduto(Produto produto)
        {
            produtoDAL.AlterarProduto(produto);
        }

        public void DeletarProduto(int id)
        {
            produtoDAL.ExcluirProduto(id);
        }
    }
}
