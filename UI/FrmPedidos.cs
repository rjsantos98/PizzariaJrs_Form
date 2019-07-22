using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace UI
{
    public partial class FrmPedidos : Form
    {
        private Form principal;
        private PedidoBLL pedidoBLL;
        private Pedido pedido;
        private ProdutoPedidoBLL produtoPedidoBLL;
        private ProdutoPedido produtoPedido;
        private ProdutoBLL produtoBLL;
        private Produto produto;
        private string modo;

        public FrmPedidos(Form frmPrincipal)
        {
            InitializeComponent();
            principal = new Form();
            principal = frmPrincipal;
            pedidoBLL = new PedidoBLL();
            pedido = new Pedido();
            produtoPedidoBLL = new ProdutoPedidoBLL();
            produtoPedido = new ProdutoPedido();
            produtoBLL = new ProdutoBLL();
            produto = new Produto();
            GridPedidos();
            GridProdutos();
            GridProdutosPedidos();
        }

        private void FrmPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            lblData.Text = dia + "/" + mes + "/" + ano;
            string hora = DateTime.Now.Hour.ToString();
            string minuto = DateTime.Now.Minute.ToString();
            string segundo = DateTime.Now.Second.ToString();
            lblHorario.Text = hora + ":" + minuto + ":" + segundo;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            modo = "cadastrar";
            gpPedidos.Show();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            modo = "alterar";
            txtID.Text = pedido.ID.ToString();
            txtTelefonePedido.Text = pedido.Cliente.Telefone;
            txtNomePedido.Text = pedido.Cliente.Nome;
            txtObservacao.Text = pedido.Observacao;
            txtDtEfetuada.Text = pedido.DataEfetuada.ToString();
            txtDtEntrega.Text = pedido.DataEntregue.ToString();
            txtValorTotal.Text = pedido.ValorTotal.ToString();
            cmbStatus.Text = pedido.StatusPedido.Nome;
            GridProdutosPedidos();
            gpPedidos.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gpPedidos.Hide();
        }

        private void lblDetalhes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes(1);
            frmClientes.Show();
            frmClientes.GPClientes();
        }

        private void btnMaisProdutos_Click(object sender, EventArgs e)
        {
            gpProdutosPedidos.Show();
        }

        private void CancelarProdutos_Click(object sender, EventArgs e)
        {
            gpProdutosPedidos.Hide();
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            gpProdutosPedidos.Hide();
        }

        private void GridPedidos()
        {
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = pedidoBLL.ConsultarPedidos(pedido);
        }
        private void GridProdutos()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtoBLL.ConsultarProdutor(produto.Nome);
        }

        private void GridProdutosPedidos()
        {
            dgvProdutosPedidos.DataSource = null;
            dgvProdutosPedidos.DataSource = pedido.produtoPedidos;
            dgvListaProdutos.DataSource = null;
            dgvListaProdutos.DataSource = pedido.produtoPedidos;
        }

        private void SelecionarPedido(object sender, DataGridViewCellEventArgs e)
        {
            pedido.ID = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells[0].Value);
            pedido = pedidoBLL.ConsultarPedidos(pedido).Find(n => n.ID == pedido.ID);
            pedido = produtoPedidoBLL.ConsultarProdutosPedidos(pedido);
        }
    }
}
