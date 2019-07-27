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
        private ClienteBLL clienteBLL;
        private Cliente cliente;
        private BindingList<ProdutoPedido> listarProdutosPedidos;
        string dia, mes, ano, hora, minuto, segundo;
        int modo = 0;
        public FrmPedidos(Form frmPrincipal)
        {
            InitializeComponent();
            principal = new Form();
            principal = frmPrincipal;
            pedidoBLL = new PedidoBLL();
            pedido = new Pedido();
            produtoPedidoBLL = new ProdutoPedidoBLL();
            produtoBLL = new ProdutoBLL();
            produto = new Produto();
            listarProdutosPedidos = new BindingList<ProdutoPedido>();
            rdbTelefone.Checked = true;
            GridConsultaPedidos();
            GridProdutos();
        }

        private void FrmPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }

        //GP Pedidos
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Limpar();
            txtID.Text = Convert.ToString(pedidoBLL.GetID());
            gpPedidos.Text = "Cadastrar Pedido";
            txtDtEfetuada.Text = $"{dia}/{mes}/{ano} {hora}:{minuto}:{segundo}";
            CamposAtivos();
            cmbStatus.Enabled = false;
            gpPedidos.Show();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (pedido.ID != 0)
            {
                cmbStatus.Enabled = true;
                gpPedidos.Text = "Alterar Pedido";
                txtID.Text = pedido.ID.ToString();
                txtTelefonePedido.Text = pedido.Cliente.Telefone;
                txtNomePedido.Text = pedido.Cliente.Nome;
                txtObservacao.Text = pedido.Observacao;
                txtDtEfetuada.Text = pedido.DataEfetuada.ToString();
                txtDtEntrega.Text = pedido.DataEntregue.ToString();
                txtValorTotal.Text = pedido.ValorTotal.ToString();
                cmbStatus.Text = pedido.StatusPedido.Nome;
                CamposAtivos();
                GridListarProdutos();
                gpPedidos.Show();
            }
            else if (pedido.ID == 0)
            {
                MessageBox.Show("Selecione um pedido");
            }
        }
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            clienteBLL = new ClienteBLL();
            cliente = new Cliente();
            cliente = clienteBLL.ConsultarClientePedido(txtTelefonePedido.Text);
            txtNomePedido.Text = cliente.Nome;
            if (txtTelefonePedido.Text is null || txtTelefonePedido.Text == "")
                MessageBox.Show("Digite um número de telefone para pesquisa");
            else if (txtNomePedido.Text is null || txtNomePedido.Text == "")
                MessageBox.Show("O número de informado não existe ou está incorreto");
        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            if (txtNomePedido.Text == "" || txtTelefonePedido.Text == "")
            {
                MessageBox.Show("Cliente não selecionado para pedido");
            }
            else
            {
                if (listarProdutosPedidos.Count == 0 || listarProdutosPedidos is null)
                {
                    MessageBox.Show("Lista de produtos vazia, adicione um produto para abrir o pedido");
                }
                else
                {
                    string valor;
                    valor = txtValorTotal.Text;
                    valor = valor.Remove(0, 2);
                    pedido.ID = Convert.ToInt32(txtID.Text);
                    pedido.Cliente.Telefone = txtTelefonePedido.Text;
                    pedido.Observacao = txtObservacao.Text;
                    pedido.ValorTotal = Convert.ToDouble(valor);
                    pedido.DataEfetuada = $"{ano}/{mes}/{dia} {hora}:{minuto}:{segundo}";
                    pedido.StatusPedido.ID = cmbStatus.SelectedIndex;

                    if (cmbStatus.SelectedIndex == 2 || cmbStatus.SelectedIndex == 3 || cmbStatus.SelectedIndex == 4)
                        pedido.DataEntregue = $"{ano}/{mes}/{dia} {hora}:{minuto}:{segundo}";
                    else if (cmbStatus.SelectedIndex == 1)
                        pedido.DataEntregue = null;

                    if (gpPedidos.Text == "Cadastrar Pedido")
                        pedidoBLL.SalvarPedido(pedido);
                    else if (gpPedidos.Text == "Alterar Pedido")
                    {
                        pedidoBLL.AlterarPedido(pedido);
                    }
                    MessageBox.Show("Dados do pedido salvo com sucesso");
                    Limpar();
                    GridConsultaPedidos();
                    gpPedidos.Hide();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (gpPedidos.Text == "Cadastrar Pedido")
            {
                if (MessageBox.Show("Deseja cancelar o pedido?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Limpar();
                    gpPedidos.Hide();
                }
            }
            else if (gpPedidos.Text == "Alterar Pedido")
            {
                if (MessageBox.Show("Deseja cancelar as alterações do pedido?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Limpar();
                    gpPedidos.Hide();
                }
            }
        }

        private void lblDetalhes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes(1);
            frmClientes.Show();
            frmClientes.GPClientes(cliente, this);
        }

        private void btnMaisProdutos_Click(object sender, EventArgs e)
        {
            if (txtNomePedido.Text == "" || txtNomePedido.Text == null)
            {
                MessageBox.Show("Selecione o cliente");
            }
            else
            {
                listarProdutosPedidos = new BindingList<ProdutoPedido>(pedido.listProdutoPedidos);
                dgvProdutosPedidos.DataSource = null;
                dgvProdutosPedidos.DataSource = listarProdutosPedidos;
                dgvProdutosPedidos.Columns["Valor"].DefaultCellStyle.Format = "C2";
                dgvProdutosPedidos.Columns["Pedido"].Visible = false;
                gpProdutosPedidos.Show();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pedido.StatusPedido.Nome != cmbStatus.Text)
            {
                if (cmbStatus.SelectedIndex == 2 || cmbStatus.SelectedIndex == 3 || cmbStatus.SelectedIndex == 4)
                {
                    txtDtEntrega.Text = $"{dia}/{mes}/{ano} {hora}:{minuto}:{segundo}";
                    DialogResultCerteza();
                    CamposAtivos();
                }
            }
        }

        //GP Produto_Pedido 
        private void GridListarProdutos()
        {
            dgvListaProdutos.DataSource = null;
            dgvListaProdutos.DataSource = pedido.listProdutoPedidos;
            dgvListaProdutos.Columns["Valor"].DefaultCellStyle.Format = "C2";
            dgvListaProdutos.Columns["Pedido"].Visible = false;
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            modo = 0;
            produtoPedido = new ProdutoPedido();
            gpProdutosPedidos.Hide();
            GridListarProdutos();
        }

        private void btnIncluirProdutos_Click(object sender, EventArgs e)
        {
            if (modo != 1)
                MessageBox.Show("Selecione um produto para incluir");
            else
            {
                if (produtoPedido == null || produtoPedido is null || produtoPedido.Produto.ID == 0)
                    MessageBox.Show("Selecione um produto para incluir");
                else
                {
                    bool existe = false;
                    foreach (ProdutoPedido produtoInclude in listarProdutosPedidos)
                    {
                        if (produtoInclude.Produto.ID == produtoPedido.Produto.ID)
                        {
                            existe = true;
                            produtoInclude.Quantidade += 1;
                            produtoInclude.Valor = produtoPedido.Produto.Valor * produtoInclude.Quantidade;
                            break;
                        }
                        else
                        {
                            existe = false;
                        }
                    }
                    if (listarProdutosPedidos.Count < 1)
                    {
                        existe = false;
                    }
                    if (existe == false)
                    {
                        listarProdutosPedidos.Add(produtoPedido);
                    }
                    dgvProdutosPedidos.DataSource = null;
                    dgvProdutosPedidos.DataSource = listarProdutosPedidos;
                    dgvProdutosPedidos.Columns["Valor"].DefaultCellStyle.Format = "C2";
                    dgvProdutosPedidos.Columns["Pedido"].Visible = false;
                }
            }
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (modo != 2)
                MessageBox.Show("Selecione um produto para remover");
            else
            {
                if (produtoPedido == null || produtoPedido is null || produtoPedido.Produto.Nome == "")
                    MessageBox.Show("Selecione um produto para remover");
                else
                {
                    int i = -1;
                    foreach (ProdutoPedido prod in listarProdutosPedidos)
                    {
                        if (prod.Produto.Nome == produtoPedido.Produto.Nome)
                        {
                            i = listarProdutosPedidos.IndexOf(prod);
                            double valor = prod.Valor / prod.Quantidade;
                            if (prod.Quantidade > 1)
                            {
                                prod.Quantidade -= 1;
                                prod.Valor = valor * prod.Quantidade;
                            }
                            else
                            {
                                listarProdutosPedidos.RemoveAt(i);
                            }
                            break;
                        }
                    }
                    dgvProdutosPedidos.DataSource = null;
                    dgvProdutosPedidos.DataSource = listarProdutosPedidos;
                    dgvProdutosPedidos.Columns["Valor"].DefaultCellStyle.Format = "C2";
                    dgvProdutosPedidos.Columns["Pedido"].Visible = false;
                }
            }
        }
        private void GridProdutos()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtoBLL.ConsultarProdutor(produto.Nome);
            dgvProdutos.Columns["ID"].Visible = false;
            dgvProdutos.Columns["Valor"].DefaultCellStyle.Format = "C2";
            dgvProdutos.Columns["Descricao"].HeaderText = "Descrição";
        }
        private void SelecionarProdutoIncluir_ClickSelector(object sender, DataGridViewCellEventArgs e)
        {
            modo = 1;
            produtoPedido = new ProdutoPedido();
            produtoPedido.Pedido.ID = Convert.ToInt32(txtID.Text);
            produtoPedido.Produto.ID = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells[0].Value);
            produtoPedido.Produto.Nome = Convert.ToString(dgvProdutos.Rows[e.RowIndex].Cells[1].Value);
            produtoPedido.Produto.Valor = Convert.ToDouble(dgvProdutos.Rows[e.RowIndex].Cells[3].Value);
            produtoPedido.Valor = produtoPedido.Produto.Valor;
            produtoPedido.Quantidade = 1;
        }
        private void SelecionarProdutosRemover_ClickSelector(object sender, DataGridViewCellEventArgs e)
        {
            modo = 2;
            produtoPedido = new ProdutoPedido();
            produtoPedido.Pedido.ID = Convert.ToInt32(txtID.Text);
            produtoPedido.Produto.Nome = Convert.ToString(dgvProdutosPedidos.Rows[e.RowIndex].Cells[1].Value);
            produtoPedido.Quantidade = Convert.ToInt32(dgvProdutosPedidos.Rows[e.RowIndex].Cells[2].Value);
            produtoPedido.Valor = Convert.ToDouble(dgvProdutosPedidos.Rows[e.RowIndex].Cells[3].Value);
        }

        //Grid Pedidos e Consultar
        private void rdbTelefone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTelefone.Checked)
            {
                txtConsData.Clear();
                txtConsData.Enabled = false;
                txtConsTel.Enabled = true;
            }
        }

        private void rdbData_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbData.Checked)
            {
                txtConsTel.Clear();
                txtConsTel.Enabled = false;
                txtConsData.Enabled = true;
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            pedido = new Pedido();

            if (rdbTelefone.Checked)
            {
                pedido.Cliente.Telefone = txtConsTel.Text;
                GridConsultaPedidos();
            }
            else if (rdbData.Checked)
            {
                string[] dataOrdem = txtConsData.Text.Split('/');
                string dataConsulta = $"{dataOrdem[2]}/{dataOrdem[1]}/{dataOrdem[0]}";
                GridConsultaData(dataConsulta);
            }
        }
        private void GridConsultaData(string data)
        {
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = pedidoBLL.ConsultarPedidosPorData(data);
            dgvPedidos.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            dgvPedidos.Columns["ValorTotal"].HeaderText = "Valor Total";
            dgvPedidos.Columns["DataEfetuada"].HeaderText = "Data Efetuada";
            dgvPedidos.Columns["DataEntregue"].HeaderText = "Data de Entrega";
            dgvPedidos.Columns["StatusPedido"].HeaderText = "Status";
            dgvPedidos.Columns["Observacao"].HeaderText = "Observação";
            dgvPedidos.Columns["ID"].Visible = false;
        }
        private void GridConsultaPedidos()
        {
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = pedidoBLL.ConsultarPedidosPorTelefone(pedido);
            dgvPedidos.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            dgvPedidos.Columns["ValorTotal"].HeaderText = "Valor Total";
            dgvPedidos.Columns["DataEfetuada"].HeaderText = "Data Efetuada";
            dgvPedidos.Columns["DataEntregue"].HeaderText = "Data de Entrega";
            dgvPedidos.Columns["StatusPedido"].HeaderText = "Status";
            dgvPedidos.Columns["Observacao"].HeaderText = "Observação";
            dgvPedidos.Columns["ID"].Visible = false;
        }
        private void SelecionarPedido(object sender, DataGridViewCellEventArgs e)
        {
            clienteBLL = new ClienteBLL();
            cliente = new Cliente();
            pedido.ID = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells[0].Value);
            pedido = pedidoBLL.ConsultarPedidosPorTelefone(pedido).Find(n => n.ID == pedido.ID);
            pedido = produtoPedidoBLL.ConsultarProdutosPedidos(pedido);
            cliente = clienteBLL.ConsultarClientePedido(pedido.Cliente.Telefone);
        }

        //Funções programaticas
        private void Limpar()
        {
            pedido = new Pedido();
            listarProdutosPedidos = new BindingList<ProdutoPedido>();
            dgvListaProdutos.DataSource = null;
            txtTelefonePedido.Clear();
            txtNomePedido.Clear();
            txtID.Clear();
            cmbStatus.Enabled = true;
            cmbStatus.SelectedItem = "ABERTO";
            txtObservacao.Clear();
            txtDtEntrega.Clear();
            txtValorTotal.Clear();
        }
        private void CamposAtivos()
        {
            if (cmbStatus.Text == "CANCELADO" || cmbStatus.Text == "ENTREGUE")
            {
                txtTelefonePedido.Enabled = false;
                txtObservacao.Enabled = false;
                btnMaisProdutos.Enabled = false;
                btnPesquisar.Enabled = false;
                cmbStatus.Enabled = false;
            }
            else if (cmbStatus.Text == "ABERTO")
            {
                txtTelefonePedido.Enabled = true;
                txtObservacao.Enabled = true;
                btnMaisProdutos.Enabled = true;
                btnPesquisar.Enabled = true;
                cmbStatus.Enabled = true;
            }
            else if (cmbStatus.Text == "EM ENTREGA")
            {
                cmbStatus.Enabled = true;
                txtTelefonePedido.Enabled = false;
                txtObservacao.Enabled = false;
                btnMaisProdutos.Enabled = false;
                btnPesquisar.Enabled = false;
            }
        }
        private void DialogResultCerteza()
        {
            if (cmbStatus.SelectedIndex == 3)
            {
                if (MessageBox.Show("Tem certeza que deseja cancelar o Pedido?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    cmbStatus.SelectedItem = pedido.StatusPedido.Nome;
                }
            }
            else if (cmbStatus.SelectedIndex == 4)
            {
                if (MessageBox.Show("Tem certeza que o Pedido foi entregue?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    cmbStatus.SelectedItem = pedido.StatusPedido.Nome;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            dia = DateTime.Now.Day.ToString();
            mes = DateTime.Now.Month.ToString();
            ano = DateTime.Now.Year.ToString();
            lblData.Text = dia + "/" + mes + "/" + ano;
            hora = DateTime.Now.Hour.ToString();
            minuto = DateTime.Now.Minute.ToString();
            segundo = DateTime.Now.Second.ToString();
            lblHorario.Text = hora + ":" + minuto + ":" + segundo;

            if (txtNomePedido.Text == null || txtNomePedido.Text == "")
                lblDetalhes.Enabled = false;
            else
                lblDetalhes.Enabled = true;

            double subtotal = 0;
            if (dgvListaProdutos.DataSource == null)
                txtValorTotal.Text = "0,00";
            else
            {
                foreach (ProdutoPedido prod in pedido.listProdutoPedidos)
                {
                    subtotal += prod.Valor;
                }
                txtValorTotal.Text = subtotal.ToString("C");
            }
        }

        public void DadosAtualizados(Cliente clienteAtualizado)
        {
            cliente = clienteAtualizado;
            txtTelefonePedido.Text = cliente.Telefone;
            txtNomePedido.Text = cliente.Nome;
        }
    }
}
