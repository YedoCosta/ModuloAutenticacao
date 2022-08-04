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
        //               =========== EVENTO TELA NIVEL  ============
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
        //               =========== EVENTO INSERIR ============
        private void btnInserir_Click(object sender, EventArgs e)
        {
            NivelDAO ni = new NivelDAO();
            MessageBox.Show(ni.Inserir(txtNome.Text));
            CarregarTabelaNive();
        }
        //               =========== EVENTO PESQUISAR POR NOME ============
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            NivelDAO npn = new NivelDAO();
            dgvNivel.DataSource = npn.PesquisarPorNome(txtNome.Text);

            if (txtNome.Text.Equals(""))
            {
                CarregarTabelaNive();
                txtId.Clear();
            }
        }
        //               =========== EVENTO ALTERAR ============
        private void btnAlterar_Click(object sender, EventArgs e)
        {
          
            NivelDAO na = new NivelDAO();
            MessageBox.Show(na.Alterar(txtId.Text, txtNome.Text));
            CarregarTabelaNive();
        }
        //               =========== EVENTO DELETAR ============
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            NivelDAO nd = new NivelDAO();
            MessageBox.Show(nd.Deletar(txtId.Text));
            CarregarTabelaNive();
        }

        //               =========== METODO CARREGAR TABELA NIVEL ============
        private void CarregarTabelaNive()
        {
            NivelDAO nivelPesquisa = new NivelDAO();
            dgvNivel.DataSource = nivelPesquisa.Pesquisar();
            txtId.Clear();
            txtNome.Clear();
            txtNome.Focus();
        }


        //               =========== EVENTO RECUPERAR DADOS DA LISTA CLICANDO ============
        private void dgvNivel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtId.Text = dgvNivel.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvNivel.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
