using SistemaLoginBD.Apresentação.Funcionarios;
using SistemaLoginBD.Apresentação.Produtos;
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

namespace SistemaLoginBD.Apresentação
{
    public partial class TelaInicial : Form
    {
        Usuario usuarioLogado;

        IListagem listagemAtual;

        RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario();
        RepositorioProduto repositorioProduto = new RepositorioProduto();

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

        private void btnControleFuncionarios_Click(object sender, EventArgs e)
        {
            ListagemFuncionario listagemFuncionario = new ListagemFuncionario(repositorioFuncionario);
            pListagem.Controls.Clear();
            listagemFuncionario.Dock = DockStyle.Fill;
            pListagem.Controls.Add(listagemFuncionario);
            listagemAtual = listagemFuncionario;
        }

        private void btnInserir_Click(object sender, EventArgs e)
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
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
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
        }

        private void btnExcluir_Click(object sender, EventArgs e)
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
            }
        }

        private void btnControleProdutos_Click(object sender, EventArgs e)
        {
            ListagemProduto listagemProduto = new ListagemProduto(repositorioProduto);
            pListagem.Controls.Clear();
            listagemProduto.Dock = DockStyle.Fill;
            pListagem.Controls.Add(listagemProduto);
            listagemAtual = listagemProduto;
        }
    }
}
