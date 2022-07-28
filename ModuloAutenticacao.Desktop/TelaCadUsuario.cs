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

            //=================== pega a partir da posição 5 mais 2 = posiçao 6 e 7
            int startIndex = 5;
            int length = 2;
            String substring = txtNome.Text.Substring(startIndex, length);
            Console.WriteLine(substring);
            //=================== neste construtor eu mostro cada nome
            string s = txtNome.Text;
            string[] subs = s.Split();
            foreach (string sub in subs)
            {
            //  MessageBox.Show($"Substring: {sub}");
                substring = sub;
            }
            //===================
            txtLogin.Text = "O leave foi acionado";
           
            String plinha = String.Empty;
            txtLogin.Text = substring;

            txtLogin.BackColor = Color.Yellow;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnsaircadu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
