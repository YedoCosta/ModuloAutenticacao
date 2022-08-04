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
        // Método TelaNivel_Load
        private void TelaNivel_Load(object sender, EventArgs e)
        {
            CarregarTabelaNive();
            // NivelDAO nivel = new NivelDAO();
            // MessageBox.Show(nivel.Inserir(txtNome.Text));
            //NivelDAO np = new NivelDAO();
            //MessageBox.Show(np.Pesquisar());
            //  NivelDAO na = new NivelDAO();
            //  MessageBox.Show(na.Alterar());
            //NivelDAO nd = new NivelDAO();
            //MessageBox.Show(nd.Deletar());
            //NivelDAO pn = new NivelDAO();
            //MessageBox.Show(pn.Pesquisar("jose"));

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNome.Text));
            CarregarTabelaNive();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            NivelDAO pn = new NivelDAO();
            dgvNivel.DataSource = pn.PesquisarPorNome(txtNome.Text);
      
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            NivelDAO na = new NivelDAO();
            MessageBox.Show(na.Alterar());
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            NivelDAO nd = new NivelDAO();
            MessageBox.Show(nd.Deletar());
        }

        // Método CarregarTabelaNivel
        private void CarregarTabelaNive()
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

        private void dgvNivel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNivel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtId.Text = dgvNivel.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvNivel.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
