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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void picProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.Show();
        }
        private void lblProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.Show();
        }

        private void picClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes(0);
            frmClientes.Show();
        }
        private void lblClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes(0);
            frmClientes.Show();
        }

        private void picPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedidos = new FrmPedidos(this);
            frmPedidos.Show();
            this.Hide();
        }

        private void lblPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedidos = new FrmPedidos(this);
            frmPedidos.Show();
            this.Hide();
        }
    }
}
