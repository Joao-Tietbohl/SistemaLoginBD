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

namespace SistemaLoginBD.Apresentação.Vendas
{
    public partial class ListagemVenda : UserControl, IListagem
    {
        RepositorioVenda repositorioVenda;

        public ListagemVenda(RepositorioVenda repositorio)
        {
            InitializeComponent();

            repositorioVenda = repositorio;

            gridVendas.Columns.Add("Id", "Id");
            gridVendas.Columns.Add("Data", "Data");
            gridVendas.Columns.Add("Valor Total", "Valor Total");
            gridVendas.Columns.Add("Funcionário", "Funcionário");

            AtualizarGrid();

            int quantidadeLinhas = gridVendas.Rows.Count;

            if (quantidadeLinhas > 0)
                gridVendas.Rows[0].Selected = true;

        }

        public void AtualizarGrid()
        {
            var vendas = repositorioVenda.SelecionarTodos();

            gridVendas.Rows.Clear();

            foreach (var venda in vendas)
            {
                gridVendas.Rows.Add(venda.Id, venda.DataVenda, venda.ValorTotal, venda.Funcionario.Nome);
            }
        }

        public int SelecionarEntidadePorIdGrid()
        {
            if (gridVendas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridVendas.SelectedRows[0];

                return Convert.ToInt32(selectedRow.Cells["Id"].Value);
            }
            else
                return -1;
        }

        private void gridVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gridVendas.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
