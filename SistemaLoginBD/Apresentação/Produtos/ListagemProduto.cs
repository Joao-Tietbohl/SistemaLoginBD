using SistemaLoginBD.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLoginBD.Apresentação.Produtos
{
    public partial class ListagemProduto : UserControl, IListagem
    {
        RepositorioProduto repositorioProduto;

        public ListagemProduto(RepositorioProduto repositorio)
        {
            InitializeComponent();

            repositorioProduto = repositorio;

            gridProdutos.Columns.Add("Id", "Id");
            gridProdutos.Columns.Add("Nome", "Nome");
            gridProdutos.Columns.Add("Preço", "Preço");
            gridProdutos.Columns.Add("Quantidade", "Quantidade");

            AtualizarGrid();

            int quantidadeLinhas = gridProdutos.Rows.Count;

            if (quantidadeLinhas > 0)
                gridProdutos.Rows[0].Selected = true;

        }

        public void AtualizarGrid()
        {
            var produtos = repositorioProduto.SelecionarTodos();

            gridProdutos.Rows.Clear();

            foreach (var p in produtos)
            {
                gridProdutos.Rows.Add(p.Id, p.Nome, p.Preco, p.Quantidade);
            }
        }

        public int SelecionarEntidadePorIdGrid()
        {
            if (gridProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridProdutos.SelectedRows[0];

                return Convert.ToInt32(selectedRow.Cells["Id"].Value);
            }
            else
                return -1;
        }

        private void gridProdutos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gridProdutos.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
