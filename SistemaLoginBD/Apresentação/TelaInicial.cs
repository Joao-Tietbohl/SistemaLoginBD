using SistemaLoginBD.Apresentação.Funcionarios;
using SistemaLoginBD.Apresentação.Produtos;
using SistemaLoginBD.Apresentação.Vendas;
using SistemaLoginBD.Infra;
using System;
using System.Windows.Forms;

namespace SistemaLoginBD.Apresentação
{
    public partial class TelaInicial : Form
    {
        Usuario usuarioLogado;

        IListagem listagemAtual;

        RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario();
        RepositorioProduto repositorioProduto = new RepositorioProduto();
        RepositorioVenda repositorioVenda = new RepositorioVenda();

        public TelaInicial(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            lbBemVindo.Text = $"{usuarioLogado.Login}";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var telaLogin = new FormLogin();
            this.Hide();
            telaLogin.Show();
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {

                var listagem = pListagem.Controls[0];

                switch (listagem.Name)
                {
                    case "ListagemFuncionario":
                        CadastroFuncionario telaCadastroFuncionario = new CadastroFuncionario();

                        DialogResult resultadoFuncionario = telaCadastroFuncionario.ShowDialog();

                        if (resultadoFuncionario != DialogResult.OK)
                            return;

                        repositorioFuncionario.Inserir(telaCadastroFuncionario.funcionario);
                        listagemAtual.AtualizarGrid();
                        break;

                    case "ListagemProduto":
                        CadastroProduto telaCadastroProduto = new CadastroProduto();

                        DialogResult resultadoProduto = telaCadastroProduto.ShowDialog();

                        if (resultadoProduto != DialogResult.OK)
                            return;

                        repositorioProduto.Inserir(telaCadastroProduto.produto);
                        listagemAtual.AtualizarGrid();
                        break;

                    case "ListagemVenda":
                        CadastroVenda telaCadastroVenda = new CadastroVenda(repositorioFuncionario, repositorioProduto);

                        DialogResult resultadoVenda = telaCadastroVenda.ShowDialog();

                        if (resultadoVenda != DialogResult.OK)
                            return;

                        foreach (var produto in telaCadastroVenda.venda.Produtos)
                        {
                            int id = repositorioProduto.DescobrirIdPeloNome(produto.Nome);
                            produto.Id = id;
                        }

                        repositorioVenda.Inserir(telaCadastroVenda.venda);

                        foreach (var produto in telaCadastroVenda.venda.Produtos)
                        {
                            repositorioProduto.DiminuiQuantidadeProduto(produto.Id, produto.Quantidade);
                        }

                        listagemAtual.AtualizarGrid();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exceção: {ex.Message}");
            }
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var listagem = pListagem.Controls[0];

                switch (listagem.Name)
                {
                    case "ListagemFuncionario":

                        int idFuncionario = listagemAtual.SelecionarEntidadePorIdGrid();

                        if (idFuncionario == -1)
                        {
                            MessageBox.Show("Selecione um funcionário.");
                            return;
                        }

                        var funcionario = repositorioFuncionario.SelecionarPorId(idFuncionario);

                        CadastroFuncionario telaCadastro = new CadastroFuncionario(funcionario);

                        DialogResult resultado = telaCadastro.ShowDialog();

                        if (resultado != DialogResult.OK)
                            return;

                        telaCadastro.funcionario.Id = funcionario.Id;
                        repositorioFuncionario.Editar(telaCadastro.funcionario);
                        listagemAtual.AtualizarGrid();
                        break;

                    case "ListagemProduto":

                        int idProduto = listagemAtual.SelecionarEntidadePorIdGrid();

                        if (idProduto == -1)
                        {
                            MessageBox.Show("Selecione um produto.");
                            return;
                        }

                        var produto = repositorioProduto.SelecionarPorId(idProduto);

                        CadastroProduto telaCadastroProduto = new CadastroProduto(produto);

                        DialogResult resultadoProduto = telaCadastroProduto.ShowDialog();

                        if (resultadoProduto != DialogResult.OK)
                            return;

                        telaCadastroProduto.produto.Id = produto.Id;
                        repositorioProduto.Editar(telaCadastroProduto.produto);
                        listagemAtual.AtualizarGrid();
                        break;
                }
            } catch(Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var listagem = pListagem.Controls[0];

                switch (listagem.Name)
                {
                    case "ListagemFuncionario":

                        int idFuncionario = listagemAtual.SelecionarEntidadePorIdGrid();

                        if (idFuncionario == -1)
                        {
                            MessageBox.Show("Selecione um funcionário.");
                            return;
                        }

                        repositorioFuncionario.Excluir(idFuncionario);

                        listagemAtual.AtualizarGrid();
                        break;

                    case "ListagemProduto":

                        int idProduto = listagemAtual.SelecionarEntidadePorIdGrid();

                        if (idProduto == -1)
                        {
                            MessageBox.Show("Selecione um produto.");
                            return;
                        }

                        repositorioProduto.Excluir(idProduto);

                        listagemAtual.AtualizarGrid();
                        break;

                    case "ListagemVenda":

                        int idVenda = listagemAtual.SelecionarEntidadePorIdGrid();

                        if (idVenda == -1)
                        {
                            MessageBox.Show("Selecione uma venda.");
                            return;
                        }

                        repositorioVenda.Excluir(idVenda);

                        listagemAtual.AtualizarGrid();
                        break;
                }
            } catch(Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
           
        }
        private void btnControleFuncionarios_Click(object sender, EventArgs e)
        {
            ListagemFuncionario listagemFuncionario = new ListagemFuncionario(repositorioFuncionario);
            pListagem.Controls.Clear();
            listagemFuncionario.Dock = DockStyle.Fill;
            pListagem.Controls.Add(listagemFuncionario);
            listagemAtual = listagemFuncionario;
        }

        private void btnControleProdutos_Click(object sender, EventArgs e)
        {
            ListagemProduto listagemProduto = new ListagemProduto(repositorioProduto);
            pListagem.Controls.Clear();
            listagemProduto.Dock = DockStyle.Fill;
            pListagem.Controls.Add(listagemProduto);
            listagemAtual = listagemProduto;
        }

        private void btnControleVendas_Click(object sender, EventArgs e)
        {
            ListagemVenda listagemVenda = new ListagemVenda(repositorioVenda);
            pListagem.Controls.Clear();
            listagemVenda.Dock = DockStyle.Fill;
            pListagem.Controls.Add(listagemVenda);
            listagemAtual = listagemVenda;
        }
    }
}
