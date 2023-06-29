using SistemaLoginBD.Dominio;
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
    public partial class CadastroVenda : Form
    {

        public Venda venda;
        public RepositorioFuncionario repositorioFuncionario;
        public RepositorioProduto repositorioProduto;

        private List<Produto> produtosDisponiveis;
        private List<Produto> produtosSelecionados;

        public CadastroVenda(RepositorioFuncionario repositorioFuncionario, RepositorioProduto repositorioProduto)
        {
            InitializeComponent();

            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioProduto = repositorioProduto;

            produtosDisponiveis = new List<Produto>();
            produtosSelecionados = new List<Produto>();

            CarregarFuncionarios();

            CarregarProdutosDisponiveis();

            tbValorTotal.Text = "R$ 0,00";

            if(produtosDisponiveis.Count > 0)
                gridProdutosDisponiveis.Rows[0].Selected = true;
        }

        private void CarregarFuncionarios()
        {
            List<Funcionario> funcionarios = repositorioFuncionario.SelecionarTodos();

            cbFuncionario.DisplayMember = "Nome";
            cbFuncionario.ValueMember = "Id";
            cbFuncionario.DataSource = funcionarios;
        }

        private void CarregarProdutosDisponiveis()
        {
            produtosDisponiveis = repositorioProduto.SelecionarTodos().FindAll(x => x.Quantidade > 0).ToList();

            gridProdutosDisponiveis.Rows.Clear();

            foreach (Produto produto in produtosDisponiveis)
            {
                gridProdutosDisponiveis.Rows.Add(produto.Nome, produto.Preco, produto.Quantidade);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (gridProdutosDisponiveis.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridProdutosDisponiveis.SelectedRows[0];

                string nomeProduto = Convert.ToString(selectedRow.Cells["Produto"].Value);
                decimal valorProduto = Convert.ToDecimal(selectedRow.Cells["Valor"].Value);
                int quantidadeDisponivel = Convert.ToInt32(selectedRow.Cells["Quantidade"].Value);

                int quantidadeSelecionada = (int)nQuantidade.Value;

                if (quantidadeSelecionada <= quantidadeDisponivel)
                {
                    // Verificar se o produto já existe nos produtos selecionados
                    bool produtoExistente = false;

                    foreach (DataGridViewRow row in gridProdutosSelecionados.Rows)
                    {
                        if (Convert.ToString(row.Cells["Produto1"].Value) == nomeProduto)
                        {
                            produtoExistente = true;
                            int quantidadeExistente = Convert.ToInt32(row.Cells["Quantidade1"].Value);
                            int novaQuantidade = quantidadeExistente + quantidadeSelecionada;
                            row.Cells["Quantidade1"].Value = novaQuantidade;
                            break;
                        }
                    }

                    if (!produtoExistente)
                    {
                        // Adicionar o produto selecionado aos produtos selecionados
                        Produto produtoSelecionado = new Produto
                        {
                            Nome = nomeProduto,
                            Preco = valorProduto,
                            Quantidade = quantidadeSelecionada
                        };

                        produtosSelecionados.Add(produtoSelecionado);

                        // Adicionar o produto ao grid de produtos selecionados
                        gridProdutosSelecionados.Rows.Add(produtoSelecionado.Nome, produtoSelecionado.Preco, produtoSelecionado.Quantidade);
                    }

                    // Atualizar a quantidade disponível no grid de produtos disponíveis
                    int novaQuantidadeDisponivel = quantidadeDisponivel - quantidadeSelecionada;
                    selectedRow.Cells["Quantidade"].Value = novaQuantidadeDisponivel;

                    // Remover o produto dos produtos disponíveis se a quantidade for zero
                    if (novaQuantidadeDisponivel == 0)
                    {
                        gridProdutosDisponiveis.Rows.Remove(selectedRow);
                    }
                }
                else
                {
                    MessageBox.Show("A quantidade selecionada é maior do que a quantidade disponível.");
                }

                AtualizarValorTotal();

            }
            else
            {
                MessageBox.Show("Selecione um produto da lista de produtos disponíveis.");
            }
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            if (gridProdutosSelecionados.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridProdutosSelecionados.SelectedRows[0];

                string nomeProduto = Convert.ToString(selectedRow.Cells["Produto1"].Value);
                decimal valorProduto = Convert.ToDecimal(selectedRow.Cells["Valor1"].Value);
                int quantidadeSelecionada = Convert.ToInt32(selectedRow.Cells["Quantidade1"].Value);

                int quantidadeRemover = (int)nQuantidade.Value;

                if (quantidadeRemover > quantidadeSelecionada)
                {
                    MessageBox.Show("A quantidade a ser removida é maior do que a quantidade do produto ja selecionada.");
                }
                else if (quantidadeRemover < quantidadeSelecionada)
                {
                    int novaQuantidade = quantidadeSelecionada - quantidadeRemover;
                    selectedRow.Cells["Quantidade1"].Value = novaQuantidade;

                    // Incrementar a quantidade no grid de produtos disponíveis
                    DataGridViewRow rowExistente = null;

                    foreach (DataGridViewRow row in gridProdutosDisponiveis.Rows)
                    {
                        if (Convert.ToString(row.Cells["Produto"].Value) == nomeProduto)
                        {
                            rowExistente = row;
                            break;
                        }
                    }

                    if (rowExistente != null)
                    {
                        int quantidadeExistente = Convert.ToInt32(rowExistente.Cells["Quantidade"].Value);
                        int novaQuantidadeDisponivel = quantidadeExistente + quantidadeRemover;
                        rowExistente.Cells["Quantidade"].Value = novaQuantidadeDisponivel;
                    }
                }
                else
                {
                    // Remover o produto dos produtos selecionados
                    Produto produtoRemovido = null;

                    foreach (Produto produto in produtosSelecionados)
                    {
                        if (produto.Nome == nomeProduto)
                        {
                            produtoRemovido = produto;
                            break;
                        }
                    }

                    if (produtoRemovido != null)
                    {
                        produtosSelecionados.Remove(produtoRemovido);
                    }

                    // Adicionar o produto de volta aos produtos disponíveis
                    Produto produtoExistente = null;

                    foreach (Produto produto in produtosDisponiveis)
                    {
                        if (produto.Nome == nomeProduto)
                        {
                            produtoExistente = produto;
                            break;
                        }
                    }

                    if (produtoExistente != null)
                    {
                        produtoExistente.Quantidade += quantidadeRemover;
                    }
                    else
                    {
                        // Se o produto não estiver mais disponível, adicionar aos produtos disponíveis novamente
                        Produto novoProdutoDisponivel = new Produto
                        {
                            Nome = nomeProduto,
                            Preco = valorProduto,
                            Quantidade = quantidadeRemover
                        };

                        produtosDisponiveis.Add(novoProdutoDisponivel);

                        // Adicionar o produto ao grid de produtos disponíveis
                        gridProdutosDisponiveis.Rows.Add(novoProdutoDisponivel.Nome, novoProdutoDisponivel.Preco, novoProdutoDisponivel.Quantidade);
                    }

                    // Remover o produto do grid de produtos selecionados
                    gridProdutosSelecionados.Rows.Remove(selectedRow);
                }

                // Atualizar o valor total da venda
                AtualizarValorTotal();
            } else
            {
                MessageBox.Show("Selecione um produto da lista de produtos selecionados.");

            }
        }

            private void AtualizarValorTotal()
        {
            decimal valorTotal = 0;

            foreach (DataGridViewRow row in gridProdutosSelecionados.Rows)
            {
                decimal valorItem = Convert.ToDecimal(row.Cells["Valor1"].Value);
                int quantidadeItem = Convert.ToInt32(row.Cells["Quantidade1"].Value);

                valorTotal += valorItem * quantidadeItem;
            }

            tbValorTotal.Text = $"R$ {valorTotal.ToString()}";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cbFuncionario.SelectedItem == null)
            {
                MessageBox.Show("Selecione um funcionário.");
                return;
            }

            if (produtosSelecionados.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um produto à venda.");
                return;
            }

            venda = new Venda
            {
                Funcionario = (Funcionario)cbFuncionario.SelectedItem,
                DataVenda = DateTime.Now,
                Produtos = produtosSelecionados,
                ValorTotal = Convert.ToDecimal(tbValorTotal.Text.Replace("R$ ", ""))
            };

        }

        private void gridProdutosDisponiveis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gridProdutosDisponiveis.Rows[e.RowIndex].Selected = true;
            }
        }

        private void gridProdutosSelecionados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gridProdutosSelecionados.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
