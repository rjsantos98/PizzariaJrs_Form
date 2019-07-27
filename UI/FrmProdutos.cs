using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace UI
{
    public partial class FrmProdutos : Form
    {
        private ProdutoBLL produtoBLL;
        private Produto produto;
        public FrmProdutos()
        {
            InitializeComponent();
            produtoBLL = new ProdutoBLL();
            produto = new Produto();
            txtFormat.Text = "R$ ";
            AtualizarGrid();
        }

        private void ConsultarProduto_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            gpProdutos.Text = "Cadastrar Produto";
            gpProdutos.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (produto.ID != 0)
            {
                gpProdutos.Text = "Alterar Produto";
                gpProdutos.Show();
                txtID.Text = produto.ID.ToString();
                txtNome.Text = produto.Nome.ToString();
                txtDescricao.Text = produto.Descricao.ToString();
                txtValor.Text += produto.Valor.ToString("F2");
            }
            else if(produto.ID == 0)
            {
                MessageBox.Show("Selecione um produto para ser alterado");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtNome.Text is null)
                MessageBox.Show("O campo Nome está sem valor");
            else if (txtValor.Text == "" || txtValor.Text is null)
                MessageBox.Show("O campo Valor está vazio");
            else
            {
                produto.Nome = txtNome.Text;
                produto.Descricao = txtDescricao.Text;
                produto.Valor = Convert.ToDouble(txtValor.Text);

                if (gpProdutos.Text == "Cadastrar Produto")
                {
                    produtoBLL.SalvarProduto(produto);
                    MessageBox.Show("Produto cadastrado com sucesso");
                }
                else if (gpProdutos.Text == "Alterar Produto")
                {
                    produtoBLL.AlterarProduto(produto);
                    MessageBox.Show("Produto alterado com sucesso");
                }
                AtualizarGrid();
                Limpar();
                gpProdutos.Hide();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o produto selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                produtoBLL.DeletarProduto(produto.ID);
                AtualizarGrid();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (gpProdutos.Text == "Cadastrar Produto")
            {
                if (MessageBox.Show("Deseja cancelar o cadastro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Limpar();
                    gpProdutos.Hide();
                }
            }
            else if (gpProdutos.Text == "Alterar Produto")
            {
                if (MessageBox.Show("Deseja cancelar a alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Limpar();
                    gpProdutos.Hide();
                }
            }
        }

        public void Limpar()
        {
            produto = new Produto();
            txtNome.Clear();
            txtID.Clear();
            txtDescricao.Clear();
            txtValor.Clear();
        }

        private void AtualizarGrid()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtoBLL.ConsultarProdutor(txtConsProd.Text);
            dgvProdutos.Columns["ID"].Visible = false;
            dgvProdutos.Columns["ID"].DisplayIndex = 3;
            dgvProdutos.Columns["Nome"].DisplayIndex = 0;
            dgvProdutos.Columns["Descricao"].DisplayIndex = 1;
            dgvProdutos.Columns["Descricao"].HeaderText = "Descrição";
            dgvProdutos.Columns["Valor"].DisplayIndex = 2;
            dgvProdutos.Columns["Valor"].DefaultCellStyle.Format = "C2";
        }

        private void SelecionarProduto(object sender, DataGridViewCellEventArgs e)
        {
            produto = new Produto();
            produto.ID = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells[0].Value);
            produto.Nome = Convert.ToString(dgvProdutos.Rows[e.RowIndex].Cells[1].Value);
            produto.Descricao = Convert.ToString(dgvProdutos.Rows[e.RowIndex].Cells[2].Value);
            produto.Valor = Convert.ToDouble(dgvProdutos.Rows[e.RowIndex].Cells[3].Value);
        }
    }
}
