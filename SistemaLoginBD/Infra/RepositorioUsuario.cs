using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginBD.Infra
{
    public class RepositorioUsuario
    {
        static string connectionString = @"Data Source=localhost;Initial Catalog=SistemaLogin;Integrated Security=True;Pooling=False";


        public RepositorioUsuario()
        {
        }


        public void Inserir(Usuario novoUsuario)
        {
            string sqlInsercao =
             @"INSERT INTO [dbo].[Usuario]
                      (
                       [login]
                      ,[senha]
                      ,[email])
                VALUES
                        (@Login, 
	               		@Senha,
	               		@Email
	               	   )";

            SqlConnection conexaoComBanco = new SqlConnection(connectionString);

            SqlCommand comandoInserir = new SqlCommand(sqlInsercao, conexaoComBanco);

            ConfigurarParametrosUsuario(novoUsuario, comandoInserir);

            conexaoComBanco.Open();

            comandoInserir.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public bool BuscaSeUsuarioJaEstaCadastrado(Usuario usuario)
        {
            string sqlBuscaUsuarioJaCadastrado = @"
                    SELECT COUNT(*) FROM [dbo].[Usuario]
                        WHERE LOGIN = @LOGIN
                                                ";

            SqlConnection conexaoComBanco = new SqlConnection(connectionString);

            SqlCommand comandoBuscarUsuarioCadastrado = new SqlCommand(sqlBuscaUsuarioJaCadastrado, conexaoComBanco);

            comandoBuscarUsuarioCadastrado.Parameters.AddWithValue("Login", usuario.Login);

            conexaoComBanco.Open();

            int usuarioJaCadastrado = (int)comandoBuscarUsuarioCadastrado.ExecuteScalar();

            conexaoComBanco.Close();

            return usuarioJaCadastrado != 0;
        }

        public Usuario Login(string login, string senha)
        {
            string sqlLogin = @"
                    SELECT Id, Login, Senha, Email FROM [dbo].[Usuario]
                        WHERE LOGIN = @LOGIN AND SENHA = @SENHA
                                                ";

            SqlConnection conexaoComBanco = new SqlConnection(connectionString);

            SqlCommand comandoLogin = new SqlCommand(sqlLogin, conexaoComBanco);

            comandoLogin.Parameters.AddWithValue("Login", login);
            comandoLogin.Parameters.AddWithValue("Senha", senha);

            Usuario usuario = null;

            conexaoComBanco.Open();

            using (SqlDataReader reader = comandoLogin.ExecuteReader())
            {
                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        Id = reader.GetInt32(0),
                        Login = reader.GetString(1),
                        Senha = reader.GetString(2),
                        Email = reader.GetString(3)
                    };
                }

            }

            conexaoComBanco.Close();

            return usuario;

        }

        private void ConfigurarParametrosUsuario(Usuario usuario, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("Id", usuario.Id);
            comando.Parameters.AddWithValue("Login", usuario.Login);
            comando.Parameters.AddWithValue("Senha", usuario.Senha);
            comando.Parameters.AddWithValue("Email", usuario.Email);

        }

    }
}
