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
    public partial class FrmClientes : Form
    {
        private ClienteBLL clienteBLL;
        private Cliente cliente;
        private int modoabertura;
        private string antigoNumero;
        private FrmPedidos frmPedidos;
        public FrmClientes(int modo)
        {
            InitializeComponent();
            clienteBLL = new ClienteBLL();
            cliente = new Cliente();
            AtualizarGrid();
            modoabertura = modo;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            gpClientes.Text = "Cadastrar Cliente";
            gpClientes.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cliente.Nome == "" || cliente.Nome is null)
                MessageBox.Show("Selecione um cliente para alterar os dados");
            else
            {
                gpClientes.Text = "Alterar Cliente";
                gpClientes.Show();
                txtNome.Text = cliente.Nome;
                txtTelefone.Text = cliente.Telefone;
                txtCEP.Text = cliente.CEP;
                txtBairro.Text = cliente.Bairro;
                txtEndereco.Text = cliente.Endereco;
                txtNumero.Text = cliente.Numero;
                txtComplemento.Text = cliente.Complemento;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtBairro.Text == "" || txtTelefone.Text == "" || txtCEP.Text == "" || txtEndereco.Text == "" || txtNumero.Text == "" || txtComplemento.Text == "")
                MessageBox.Show("Todos os campos precisam estar preenchidos");
            else
            {
                cliente.Nome = txtNome.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.CEP = txtCEP.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Numero = txtNumero.Text;
                cliente.Complemento = txtComplemento.Text;

                if (gpClientes.Text == "Cadastrar Cliente")
                    clienteBLL.SalvarCliente(cliente);
                else if (gpClientes.Text == "Alterar Cliente")
                    clienteBLL.AlterarCliente(cliente, antigoNumero);
                MessageBox.Show("Dados salvo com sucesso");
                AtualizarGrid();
                gpClientes.Hide();
                if (modoabertura == 1)
                {
                    frmPedidos.DadosAtualizados(cliente);
                    Close();
                }
                Limpar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (modoabertura == 0)
                {
                    Limpar();
                    gpClientes.Hide();
                }
                else if (modoabertura == 1)
                {
                    gpClientes.Hide();
                    Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clienteBLL.ExcluirCliente(cliente.Telefone);
                AtualizarGrid();
            }
        }

        private void ConsultarCliente(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void Limpar()
        {
            cliente = new Cliente();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCEP.Clear();
            txtBairro.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
        }

        private void AtualizarGrid()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clienteBLL.ConsultarClientes(txtConsTel.Text);
            dgvClientes.Columns["Endereco"].HeaderText = "Endereço";
        }

        private void SelecionarCliente(object sender, DataGridViewCellEventArgs e)
        {
            cliente = new Cliente();
            cliente.Nome = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
            cliente.Telefone = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[1].Value);
            cliente.CEP = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[2].Value);
            cliente.Bairro = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[3].Value);
            cliente.Endereco = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[4].Value);
            cliente.Numero = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[5].Value);
            cliente.Complemento = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[6].Value);
            antigoNumero = cliente.Telefone;
        }
        public void GPClientes(Cliente cliente, FrmPedidos form)
        {
            frmPedidos = new FrmPedidos(null);
            frmPedidos = form;
            antigoNumero = cliente.Telefone;
            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone;
            txtCEP.Text = cliente.CEP;
            txtBairro.Text = cliente.Bairro;
            txtEndereco.Text = cliente.Endereco;
            txtNumero.Text = cliente.Numero;
            txtComplemento.Text = cliente.Complemento;
            gpClientes.Text = "Alterar Cliente";
            gpClientes.Show();
        }

        private void SearchCEP(object sender, EventArgs e)
        {
            var ws = new WSCorreios.AtendeClienteClient();
            var resposta = ws.consultaCEP(txtCEP.Text);
            txtEndereco.Text = resposta.end;
            txtBairro.Text = resposta.bairro;
        }
    }
}
