
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloAutenticacao.Classes;


namespace ModuloAutenticacao.Desktop
{
    public partial class TelaAutenticacao : Form
    {
        public TelaAutenticacao()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Login = txtlogin.Text;         
            usuario.Senha = txtsenha.Text;
            if (usuario.Login.Equals(""))
            {
                MessageBox.Show("Login obrigatorio");
                txtlogin.Focus();
            }else if (usuario.Senha.Equals(""))
            {
                MessageBox.Show("Senha obrigatoria");
                txtsenha.Focus(); 
            }
            else
            {
                MessageBox.Show($"seja bem vindo { usuario.Login}");
                TelaCadUsuario tcu = new TelaCadUsuario();
                tcu.Show();
            }
            

        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaAutenticacao_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
