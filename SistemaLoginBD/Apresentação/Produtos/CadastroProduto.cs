using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLoginBD.Dominio;

namespace SistemaLoginBD.Apresentação.Produtos
{
    public partial class CadastroProduto : Form
    {
        public Produto produto;

        public CadastroProduto()
        {
            InitializeComponent();
        }

        public CadastroProduto(Produto produto)
        {
            InitializeComponent();
            this.produto = produto;
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            tbNome.Text = produto.Nome;
            nPreco.Value = produto.Preco;
            nQuantidade.Value = produto.Quantidade;
        }


        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            decimal preco = nPreco.Value;
            int quantidade = Convert.ToInt32(nQuantidade.Value);

            if (String.IsNullOrEmpty(nome) || preco == 0 || quantidade == 0)
            {
                MessageBox.Show("Todos os campos são obrigatórios");
                return;
            }

            produto = new Produto
            {
                Nome = nome,
                Preco = preco,
                Quantidade = quantidade
            };
        }
    }
}