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
        private string modo;
        private string antigoNumero;
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
            modo = "cadastrar";
            gpClientes.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            gpClientes.Text = "Alterar Cliente";
            modo = "alterar";
            gpClientes.Show();
            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone;
            txtCEP.Text = cliente.CEP;
            txtBairro.Text = cliente.Bairro;
            txtEndereco.Text = cliente.Endereco;
            txtNumero.Text = cliente.Numero;
            txtComplemento.Text = cliente.Complemento;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.CEP = txtCEP.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = txtNumero.Text;
            cliente.Complemento = txtComplemento.Text;
            if (modo == "cadastrar")
                clienteBLL.SalvarCliente(cliente);
            else if (modo == "alterar")
                clienteBLL.AlterarCliente(cliente, antigoNumero);

            Limpar();
            AtualizarGrid();
            gpClientes.Hide();
            if (modoabertura == 1)
                Close();
        }

        public void GPClientes()
        {
            gpClientes.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (modoabertura == 0)
            {
                gpClientes.Hide();
            }
            else if(modoabertura == 1)
            {
                gpClientes.Hide();
                Close();
            }
        }

        private void Limpar()
        {
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
            dgvClientes.DataSource = clienteBLL.GetClientes(txtConsTel.Text);
            dgvClientes.Columns["Endereco"].HeaderText = "Endereço";
        }

        private void SelecionarCliente(object sender, DataGridViewCellEventArgs e)
        {
            cliente.Nome = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
            cliente.Telefone = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[1].Value);
            cliente.CEP = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[2].Value);
            cliente.Bairro = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[3].Value);
            cliente.Endereco = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[4].Value);
            cliente.Numero = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[5].Value);
            cliente.Complemento = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[6].Value);
            antigoNumero = cliente.Telefone;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            clienteBLL.ExcluirCliente(cliente.Telefone);
            AtualizarGrid();
        }

        private void ConsultarCliente(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
    }
}
