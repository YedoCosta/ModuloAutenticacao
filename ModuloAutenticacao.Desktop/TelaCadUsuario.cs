using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAutenticacao.Desktop
{
    public partial class TelaCadUsuario : Form
    {
        public TelaCadUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadUsuario_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtLogin.Enabled = false;
            // MessageBox.Show("nome: " + txtNome.Text);
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSobrenome_Move(object sender, EventArgs e)
        {
            
        }

        private void txtSobrenome_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtSobrenome_Leave(object sender, EventArgs e)
        {
            txtLogin.Text = "O leave foi acionado";
            txtLogin.BackColor = Color.Yellow;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
         //   MessageBox.Show("nome: "+txtNome.Text);
        }
    }
}
