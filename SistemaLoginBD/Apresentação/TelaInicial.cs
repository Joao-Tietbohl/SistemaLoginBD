using SistemaLoginBD.Apresentação.Funcionarios;
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

        public TelaInicial(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            lbBemVindo.Text = $"Seja Bem Vindo(a) {usuarioLogado.Login}";
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
                    CadastroFuncionario telaCadastro = new CadastroFuncionario();

                    DialogResult resultado = telaCadastro.ShowDialog();

                    if (resultado != DialogResult.OK)
                        return;

                    repositorioFuncionario.Inserir(telaCadastro.funcionario);
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

                    int id = listagemAtual.SelecionarEntidadePorIdGrid();

                    if (id == -1)
                    {
                        MessageBox.Show("Selecione um funcionário.");
                        return;
                    }

                    var funcionario = repositorioFuncionario.SelecionarPorId(id);

                    CadastroFuncionario telaCadastro = new CadastroFuncionario(funcionario);

                    DialogResult resultado = telaCadastro.ShowDialog();

                    if (resultado != DialogResult.OK)
                        return;

                    telaCadastro.funcionario.Id = funcionario.Id;
                    repositorioFuncionario.Editar(telaCadastro.funcionario);
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

                    int id = listagemAtual.SelecionarEntidadePorIdGrid();

                    if (id == -1)
                    {
                        MessageBox.Show("Selecione um funcionário.");
                        return;
                    }

                    repositorioFuncionario.Excluir(id);

                    listagemAtual.AtualizarGrid();
                    break;
            }
        }
    }
}
