using SistemaLoginBD.Apresentação;
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

namespace SistemaLoginBD
{
    public partial class FormLogin : Form
    {
        public RepositorioUsuario repositorioUsuario;
        public Usuario usuarioLogado;

        public FormLogin()
        {
            InitializeComponent();
            repositorioUsuario = new RepositorioUsuario();
        }

        private void lbCastrese_Click(object sender, EventArgs e)
        {
            var telaCadastro = new TelaCadastro(repositorioUsuario);
            telaCadastro.Location = this.Location;
            telaCadastro.StartPosition = FormStartPosition.Manual;
            telaCadastro.FormClosing += delegate { this.Show(); };
            telaCadastro.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string senha = tbSenha.Text;

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Digite seu login");
                return;
            }

            if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Digite sua senha");
                return;
            }

            usuarioLogado = repositorioUsuario.Login(login, senha);

            if (usuarioLogado == null)
            {
                MessageBox.Show("Usuário não cadastrado!");
                return;
            }

            var telaInicial = new TelaInicial(usuarioLogado);
            this.Hide();
            telaInicial.Show();
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked) 
                tbSenha.UseSystemPasswordChar = false;
            else
                tbSenha.UseSystemPasswordChar= true;
        }
    }
}
