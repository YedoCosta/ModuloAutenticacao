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
    public partial class TelaNivel : Form
    {
        public TelaNivel()
        {
            InitializeComponent();
        }

        private void TelaNivel_Load(object sender, EventArgs e)
        {
            // NivelDAO nivel = new NivelDAO();
            // MessageBox.Show(nivel.Inserir(txtNome.Text));
            // NivelDAO np = new NivelDAO();
            // MessageBox.Show(np.Pesquisar());
            CarregarResponsabilidades();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
          //  NivelDAO nivel = new NivelDAO();
          //  MessageBox.Show(nivel.Inserir(txtNome.Text));
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNome.Text));
            CarregarResponsabilidades();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
         //   NivelDAO np = new NivelDAO();
            //MessageBox.Show(np.Pesquisar());
         //   dgvNivel.DataSource = np;


        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void CarregarResponsabilidades()
        {
            NivelDAO nivelPesquisa = new NivelDAO();

            dgvNivel.DataSource = nivelPesquisa.Pesquisar();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_MouseClick(object sender, MouseEventArgs e)
        {
            txtNome.Focus();
            txtNome.Clear();
        }
    }
}
