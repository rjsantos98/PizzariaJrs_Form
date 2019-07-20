using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmPedidos : Form
    {
        Form principal;
        public FrmPedidos(Form frmPrincipal)
        {
            InitializeComponent();
            principal = new Form();
            principal = frmPrincipal;
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
    }
}
