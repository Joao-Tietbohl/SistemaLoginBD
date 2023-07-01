using SistemaLoginBD.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginBD.Infra
{
    public class RepositorioVenda : RepositorioBase
    {
        public void Inserir(Venda novaVenda)
        {
            string sqlInsercaoVenda =
                @"INSERT INTO [dbo].[Venda]
                        ([DataVenda]
                        ,[ValorTotal]
                        ,[FuncionarioId])
                    VALUES
                        (@DataVenda,
                        @ValorTotal,
                        @FuncionarioId);
                    SELECT SCOPE_IDENTITY();"; 

            SqlConnection conexaoComBanco = new SqlConnection(connectionString);

            SqlCommand comandoInserirVenda = new SqlCommand(sqlInsercaoVenda, conexaoComBanco);

            comandoInserirVenda.Parameters.AddWithValue("@DataVenda", novaVenda.DataVenda);
            comandoInserirVenda.Parameters.AddWithValue("@ValorTotal", novaVenda.ValorTotal);
            comandoInserirVenda.Parameters.AddWithValue("@FuncionarioId", novaVenda.Funcionario.Id);

            conexaoComBanco.Open();

            int vendaId = Convert.ToInt32(comandoInserirVenda.ExecuteScalar());

            foreach (Produto produto in novaVenda.Produtos)
            {

                string sqlInsercaoVendaProduto =
                    @"INSERT INTO [dbo].[VendaProduto]
                            ([VendaId]
                            ,[ProdutoId]
                            ,[quantidade])
                        VALUES
                            (@VendaId,
                             @ProdutoId,
                             @Quantidade)";

                SqlCommand comandoInserirVendaProduto = new SqlCommand(sqlInsercaoVendaProduto, conexaoComBanco);

                comandoInserirVendaProduto.Parameters.AddWithValue("@VendaId", vendaId);
                comandoInserirVendaProduto.Parameters.AddWithValue("@ProdutoId", produto.Id);
                comandoInserirVendaProduto.Parameters.AddWithValue("@Quantidade", produto.Quantidade);

                comandoInserirVendaProduto.ExecuteNonQuery();
            }

            conexaoComBanco.Close();
        }

        public List<Venda> SelecionarTodos()
        {
            List<Venda> vendas = new List<Venda>();

            string sqlSelecionarTodos =
                @"SELECT V.Id, V.FuncionarioId, V.DataVenda, P.Id AS ProdutoId, P.Nome AS ProdutoNome, VP.Quantidade, V.ValorTotal, P.Preco
                FROM Venda V
                INNER JOIN VendaProduto VP ON V.Id = VP.VendaId
                INNER JOIN Produto P ON VP.ProdutoId = P.Id";

            using (SqlConnection conexaoComBanco = new SqlConnection(connectionString))
            {
                conexaoComBanco.Open();

                using (SqlCommand comandoSelecionarTodos = new SqlCommand(sqlSelecionarTodos, conexaoComBanco))
                {
                    SqlDataReader reader = comandoSelecionarTodos.ExecuteReader();

                    while (reader.Read())
                    {
                        int vendaId = reader.GetInt32(0);
                        int funcionarioId = reader.GetInt32(1);
                        DateTime dataVenda = reader.GetDateTime(2);
                        int produtoId = reader.GetInt32(3);
                        string produtoNome = reader.GetString(4);
                        int quantidade = reader.GetInt32(5);
                        decimal ValorTotal = reader.GetDecimal(6);
                        decimal preco = reader.GetDecimal(7);

                        Venda vendaExistente = vendas.Find(v => v.Id == vendaId);

                        if (vendaExistente == null)
                        {
                            vendaExistente = new Venda
                            {
                                Id = vendaId,
                                Funcionario = ObterFuncionarioPorId(funcionarioId),
                                DataVenda = dataVenda,
                                Produtos = new List<Produto>(),
                                ValorTotal = ValorTotal
                            };

                            vendas.Add(vendaExistente);
                        }

                        Produto produto = new Produto
                        {
                            Id = produtoId,
                            Nome = produtoNome,
                            Quantidade = quantidade,
                            Preco = preco
                        };

                        vendaExistente.Produtos.Add(produto);
                    }

                    reader.Close();
                }
            }

            return vendas;
        }

        internal void Excluir(int id)
        {
            string sqlExcluir =
             @"Delete from VendaProduto where VendaID = @Id
               Delete from Venda where Id = @Id";

            SqlConnection conexaoComBanco = new SqlConnection(connectionString);

            SqlCommand comandoExluir = new SqlCommand(sqlExcluir, conexaoComBanco);

            comandoExluir.Parameters.AddWithValue("Id", id);

            conexaoComBanco.Open();

            comandoExluir.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        private Funcionario ObterFuncionarioPorId(int funcionarioId)
        {
            RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario();

            return repositorioFuncionario.SelecionarPorId(funcionarioId);
        }

        private List<Produto> ObterProdutosDaVenda(int vendaId)
        {
            List<Produto> produtos = new List<Produto>();

            SqlConnection conexaoComBanco = new SqlConnection(connectionString);

            string querySelecionarProdutosDaVenda = @"SELECT p.[Id],
                                                               p.[Nome],
                                                               p.[Preco],
                                                               p.[Quantidade]
                                                        FROM Produto p
                                                        INNER JOIN Venda_Produto vp ON p.Id = vp.produto_id
                                                        WHERE vp.venda_id = @VendaId";

            SqlCommand comandoSelecionarProdutosDaVenda = new SqlCommand(querySelecionarProdutosDaVenda, conexaoComBanco);

            comandoSelecionarProdutosDaVenda.Parameters.AddWithValue("@VendaId", vendaId);

            conexaoComBanco.Open();

            SqlDataReader reader = comandoSelecionarProdutosDaVenda.ExecuteReader();

            while (reader.Read())
            {
                Produto produto = new Produto
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Preco = reader.GetDecimal(2),
                    Quantidade = reader.GetInt32(3)
                };

                produtos.Add(produto);
            }

            reader.Close();

            return produtos;
        }
    }
}
