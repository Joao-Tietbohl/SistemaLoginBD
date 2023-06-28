using SistemaLoginBD.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginBD.Infra
{
    public class RepositorioFuncionario: RepositorioBase
    {

        public void Inserir(Funcionario novoFuncionario)
        {
            string sqlInsercao =
             @"INSERT INTO [dbo].[Funcionario]
                      (
                       [nome]
                      ,[cargo]
                      ,[salario]
                      ,[endereco])
                VALUES
                        (@Nome, 
	               		@Cargo,
	               		@Salario,
                        @Endereco
	               	   )";

            SqlConnection conexaoComBanco = new SqlConnection(connectionString);

            SqlCommand comandoInserir = new SqlCommand(sqlInsercao, conexaoComBanco);

            ConfigurarParametrosFuncionario(novoFuncionario, comandoInserir);

            conexaoComBanco.Open();

            comandoInserir.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public void Editar(Funcionario funcionario)
        {
            string sqlAtualizar =
             @"UPDATE Funcionario
                SET Nome = @Nome,
                    Cargo = @Cargo,
                    Salario = @Salario,
                    Endereco = @Endereco
                WHERE Id = @Id";

            SqlConnection conexaoComBanco = new SqlConnection(connectionString);

            SqlCommand comandoAtualizar = new SqlCommand(sqlAtualizar, conexaoComBanco);

            ConfigurarParametrosFuncionario(funcionario, comandoAtualizar);

            conexaoComBanco.Open();

            comandoAtualizar.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public void Excluir(int id)
        {
            string sqlExcluir =
             @"Delete from Funcionario where Id = @Id";

            SqlConnection conexaoComBanco = new SqlConnection(connectionString);

            SqlCommand comandoExluir = new SqlCommand(sqlExcluir, conexaoComBanco);

            comandoExluir.Parameters.AddWithValue("Id", id);

            conexaoComBanco.Open();

            comandoExluir.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public List<Funcionario> SelecionarTodos()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            SqlConnection conexaoComBanco = new SqlConnection(connectionString);

            string querySelecionarTodos = "SELECT * FROM Funcionario";

            SqlCommand comandoSelecionarTodos = new SqlCommand(querySelecionarTodos, conexaoComBanco);
            
            conexaoComBanco.Open();

            SqlDataReader reader = comandoSelecionarTodos.ExecuteReader();

            while (reader.Read())
            {
                Funcionario funcionario = new Funcionario
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Cargo = reader.GetString(2),
                    Salario = reader.GetDecimal(3),
                    Endereco = reader.GetString(4)
                };

                funcionarios.Add(funcionario);
            }

            reader.Close();

            return funcionarios;
        }
        
        public Funcionario SelecionarPorId(int id)
        {
            SqlConnection conexaoComBanco = new SqlConnection(connectionString);

            string querySelecionarPorId = @"SELECT [Id],
                                                   [Nome],
                                                   [Cargo],
                                                   [Salario],
                                                   [Endereco]
                                            FROM Funcionario WHERE Id = @ID";

            SqlCommand comandoSelecionarTodos = new SqlCommand(querySelecionarPorId, conexaoComBanco);

            comandoSelecionarTodos.Parameters.AddWithValue("Id", id);

            conexaoComBanco.Open();

            SqlDataReader reader = comandoSelecionarTodos.ExecuteReader();

            Funcionario funcionario = new Funcionario();

            while (reader.Read())
            {
                funcionario = new Funcionario
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Cargo = reader.GetString(2),
                    Salario = reader.GetDecimal(3),
                    Endereco = reader.GetString(4)
                };
            }

            reader.Close();

            return funcionario;
        }

        private void ConfigurarParametrosFuncionario(Funcionario funcionario, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("Id", funcionario.Id);
            comando.Parameters.AddWithValue("Nome", funcionario.Nome);
            comando.Parameters.AddWithValue("Cargo", funcionario.Cargo);
            comando.Parameters.AddWithValue("Salario", funcionario.Salario);
            comando.Parameters.AddWithValue("Endereco", funcionario.Endereco);

        }
    }
}
