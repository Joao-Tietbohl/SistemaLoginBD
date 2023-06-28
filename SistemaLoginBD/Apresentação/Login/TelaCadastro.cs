using SistemaLoginBD.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaLoginBD
{
    public partial class TelaCadastro : Form
    {
        RepositorioUsuario  repositorioUsuario;
        public TelaCadastro(RepositorioUsuario repositorio)
        {
            repositorioUsuario = repositorio;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string senha = tbSenha.Text;
            string confirmarSenha = tbConfirmarSenha.Text;
            string email = tbEmail.Text;

            var mensagemErro = Validar(login, senha, confirmarSenha, email);

            if (mensagemErro != DialogResult.Yes)
                return;

            Usuario usuario = new Usuario() 
            {
                Login = login,
                Senha = senha,
                Email = email,
            };

            if (repositorioUsuario.BuscaSeUsuarioJaEstaCadastrado(usuario))
                MessageBox.Show("Usuario já cadastrado!");
            else 
            { 
                repositorioUsuario.Inserir(usuario);
                this.Close();
            }

        }
        
        public DialogResult Validar(string login, string senha, string confirmarSenha, string email)
        {
            DialogResult mensagemErro;

            if (string.IsNullOrEmpty(login)
            || string.IsNullOrEmpty(senha)
            || string.IsNullOrEmpty(confirmarSenha)
            || string.IsNullOrEmpty(email))
            {
               return mensagemErro = MessageBox.Show("Todos os campos devem ser preenchidos!");
            }

             if (!string.Equals(senha, confirmarSenha))
             {
               return mensagemErro = MessageBox.Show("As duas senhas digitadas não são iguais!");
             }

            return DialogResult.Yes;
         }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked)
            {
                tbSenha.UseSystemPasswordChar = false;
                tbConfirmarSenha.UseSystemPasswordChar = false;
            }
            else
            {
                tbSenha.UseSystemPasswordChar = true;
                tbConfirmarSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
