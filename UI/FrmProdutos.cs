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
        private string modo;
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
            produtoBLL.ConsultarProdutor(txtConsProd.Text);
            AtualizarGrid();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            gpProdutos.Text = "Cadastrar Produto";
            modo = "cadastrar";
            gpProdutos.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            gpProdutos.Text = "Alterar Produto";
            modo = "alterar";
            gpProdutos.Show();
            txtID.Text = produto.ID.ToString();
            txtNome.Text = produto.Nome.ToString();
            txtDescricao.Text = produto.Descricao.ToString();
            txtValor.Text += produto.Valor.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Valor = Convert.ToDouble(txtValor.Text);

            if (modo == "cadastrar")
                produtoBLL.SalvarProduto(produto);
            else if (modo == "alterar")
                produtoBLL.AlterarProduto(produto);

            AtualizarGrid();
            Limpar();
            gpProdutos.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            produtoBLL.DeletarProduto(produto.ID);
            AtualizarGrid();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            gpProdutos.Hide();
        }

        public void Limpar()
        {
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
            produto.ID = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells[0].Value);
            produto.Nome = Convert.ToString(dgvProdutos.Rows[e.RowIndex].Cells[1].Value);
            produto.Descricao = Convert.ToString(dgvProdutos.Rows[e.RowIndex].Cells[2].Value);
            produto.Valor = Convert.ToDouble(dgvProdutos.Rows[e.RowIndex].Cells[3].Value);
        }
    }
}
