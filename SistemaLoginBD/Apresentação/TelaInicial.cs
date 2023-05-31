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
    }
}
