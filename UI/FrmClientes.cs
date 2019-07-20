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
    public partial class FrmClientes : Form
    {
        int modoabertura;
        public FrmClientes(int modo)
        {
            InitializeComponent();
            modoabertura = modo;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            gpClientes.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            gpClientes.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            gpClientes.Hide();
        }

        public void GPClientes()
        {
            gpClientes.Show();
            InitializeComponent();
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
    }
}
