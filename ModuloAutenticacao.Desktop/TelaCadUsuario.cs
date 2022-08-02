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

        private void txtSobrenome_Leave(object sender, EventArgs e)
        {

            //=================== pega a partir da posição 5 mais 2 = posiçao 6 e 7
            int startIndex = 5;
            int length = 2;
            String substring = txtNome.Text.Substring(startIndex, length);
            //Console.WriteLine(substring);
            //=================== neste pego o primeiro nome do Nome
            string[] subsN = txtNome.Text.Split();
            String nome = subsN[0].ToLower();
            //=================== neste  eu  pego o ultimo nome do Sobrenome
            string[] subs = txtSobrenome.Text.Split();
            foreach (string sub in subs)
            {
                substring = sub.ToLower();
            }
            //===================
            //txtLogin.Text = "O leave foi acionado";
            txtLogin.Text = $"{nome}.{substring}";
            txtLogin.BackColor = Color.Yellow;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnsaircadu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfSenha_Leave(object sender, EventArgs e)
        {
            if (String.Compare(txtConfSenha.Text, txtSenha.Text) != 0) 
            {
                //Console.WriteLine($"Both strings have diferent value.");
                MessageBox.Show("Confirmação de Senha diferente de Senha. Tente novamente...");
                txtSenha.Text = "";
                txtConfSenha.Text = "";
                txtSenha.Focus();
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TelaNivel().Show();
        }
    }
}
