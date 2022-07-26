
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
            }
            MessageBox.Show($"Seja bem vindo {usuario.Login} {usuario.Senha}");
            //================
            /*
            if (txtlogin.Text == "Yedo" && txtsenha.Text == "1234")
            {
                //MessageBox.Show("Bem vindo ao Sistema");
                Usuario usuario = new Usuario();
                MessageBox.Show($"Seja bem vindo {usuario.Login} {usuario.Senha}");

            }
            else
            {
                MessageBox.Show("Login ou Senha invalidos");
            }
            */
            //===============
        }
    }
}
