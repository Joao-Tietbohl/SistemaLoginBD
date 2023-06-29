using SistemaLoginBD.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginBD.Infra
{
    public class RepositorioProduto : RepositorioBase
    {
        public void Inserir(Produto novoProduto)
        {
            string sqlInsercao =
             @"INSERT INTO [dbo].[Produto]
                      ([Nome]
                      ,[Preco]
                      ,[Quantidade])
                VALUES
                      (@Nome, 
                       @Preco,
                       @Quantidade)";

            using (SqlConnection conexaoComBanco = new SqlConnection(connectionString))
            {
                SqlCommand comandoInserir = new SqlCommand(sqlInsercao, conexaoComBanco);

                comandoInserir.Parameters.AddWithValue("@Nome", novoProduto.Nome);
                comandoInserir.Parameters.AddWithValue("@Preco", novoProduto.Preco);
                comandoInserir.Parameters.AddWithValue("@Quantidade", novoProduto.Quantidade);

                conexaoComBanco.Open();

                comandoInserir.ExecuteNonQuery();
            }
        }

        public void Editar(Produto produto)
        {
            string sqlAtualizar =
             @"UPDATE Produto
                SET Nome = @Nome,
                    Preco = @Preco,
                    Quantidade = @Quantidade
                WHERE Id = @Id";

            using (SqlConnection conexaoComBanco = new SqlConnection(connectionString))
            {
                SqlCommand comandoAtualizar = new SqlCommand(sqlAtualizar, conexaoComBanco);

                comandoAtualizar.Parameters.AddWithValue("@Nome", produto.Nome);
                comandoAtualizar.Parameters.AddWithValue("@Preco", produto.Preco);
                comandoAtualizar.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                comandoAtualizar.Parameters.AddWithValue("@Id", produto.Id);

                conexaoComBanco.Open();

                comandoAtualizar.ExecuteNonQuery();
            }
        }

        public void Excluir(int id)
        {
            string sqlExcluir =
             @"DELETE FROM Produto WHERE Id = @Id";

            using (SqlConnection conexaoComBanco = new SqlConnection(connectionString))
            {
                SqlCommand comandoExluir = new SqlCommand(sqlExcluir, conexaoComBanco);

                comandoExluir.Parameters.AddWithValue("@Id", id);

                conexaoComBanco.Open();

                comandoExluir.ExecuteNonQuery();
            }
        }

        public List<Produto> SelecionarTodos()
        {
            List<Produto> produtos = new List<Produto>();

            using (SqlConnection conexaoComBanco = new SqlConnection(connectionString))
            {
                string querySelecionarTodos = "SELECT * FROM Produto";

                SqlCommand comandoSelecionarTodos = new SqlCommand(querySelecionarTodos, conexaoComBanco);

                conexaoComBanco.Open();

                SqlDataReader reader = comandoSelecionarTodos.ExecuteReader();

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
            }

            return produtos;
        }

        public Produto SelecionarPorId(int id)
        {
            using (SqlConnection conexaoComBanco = new SqlConnection(connectionString))
            {
                string querySelecionarPorId = @"SELECT [Id],
                                                   [Nome],
                                                   [Preco],
                                                   [Quantidade]
                                            FROM Produto WHERE Id = @Id";

                SqlCommand comandoSelecionarPorId = new SqlCommand(querySelecionarPorId, conexaoComBanco);

                comandoSelecionarPorId.Parameters.AddWithValue("@Id", id);

                conexaoComBanco.Open();

                SqlDataReader reader = comandoSelecionarPorId.ExecuteReader();

                Produto produto = null;

                if (reader.Read())
                {
                    produto = new Produto
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Preco = reader.GetDecimal(2),
                        Quantidade = reader.GetInt32(3)
                    };
                }
                reader.Close();

                return produto;
            }
        }

        public void DiminuiQuantidadeProduto(int id, int quantidadeNaVenda)
        {
            string sqlAtualizar =
                @"UPDATE Produto
                    SET Quantidade = Quantidade - @QuantidadeNaVenda
                    WHERE Id = @Id";

            using (SqlConnection conexaoComBanco = new SqlConnection(connectionString))
            {
                SqlCommand comandoAtualizar = new SqlCommand(sqlAtualizar, conexaoComBanco);

                comandoAtualizar.Parameters.AddWithValue("@QuantidadeNaVenda", quantidadeNaVenda);
                comandoAtualizar.Parameters.AddWithValue("@Id", id);

                conexaoComBanco.Open();

                comandoAtualizar.ExecuteNonQuery();
            }
        }

        public int DescobrirIdPeloNome(string nome)
        {
            string sqlSelect =
                @"Select Id
                    from Produto
                    WHERE Nome = @Nome";

            using (SqlConnection conexaoComBanco = new SqlConnection(connectionString))
            {
                SqlCommand comandoAtualizar = new SqlCommand(sqlSelect, conexaoComBanco);

                comandoAtualizar.Parameters.AddWithValue("@Nome", nome);

                conexaoComBanco.Open();

                int id = (int)comandoAtualizar.ExecuteScalar();

                return id;
            }
        }
    }

}
