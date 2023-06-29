using SistemaLoginBD.Infra;
using System;
using System.Windows.Forms;

namespace SistemaLoginBD.Apresentação
{
    public partial class ListagemFuncionario : UserControl, IListagem
    {
        RepositorioFuncionario repositorioFuncionario;

        public ListagemFuncionario(RepositorioFuncionario repositorio)
        {
            InitializeComponent();

            repositorioFuncionario = repositorio;

            gridFuncionarios.Columns.Add("Id", "Id");
            gridFuncionarios.Columns.Add("Nome", "Nome");
            gridFuncionarios.Columns.Add("Cargo", "Cargo");
            gridFuncionarios.Columns.Add("Salario", "Salario");
            gridFuncionarios.Columns.Add("Endereço", "Endereço");

            AtualizarGrid();

            int quantidadeLinhas = gridFuncionarios.Rows.Count;

            if (quantidadeLinhas > 0)
                gridFuncionarios.Rows[0].Selected = true;


        }

        public void AtualizarGrid()
        {
            var funcionarios = repositorioFuncionario.SelecionarTodos();

            gridFuncionarios.Rows.Clear();

            foreach (var f in funcionarios)
            {
                gridFuncionarios.Rows.Add(f.Id, f.Nome, f.Cargo, f.Salario, f.Endereco);
            }

        }

        public int SelecionarEntidadePorIdGrid()
        {
            if (gridFuncionarios.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridFuncionarios.SelectedRows[0];

                return Convert.ToInt32(selectedRow.Cells["Id"].Value);
            }
            else
                return -1;
        }

        private void gridFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gridFuncionarios.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
