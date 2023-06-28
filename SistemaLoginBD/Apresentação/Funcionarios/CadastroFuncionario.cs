using SistemaLoginBD.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLoginBD.Apresentação.Funcionarios
{
    public partial class CadastroFuncionario : Form
    {
        public Funcionario funcionario;

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        public CadastroFuncionario(Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionario = funcionario;
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            tbNome.Text = funcionario.Nome;
            tbCargo.Text = funcionario.Cargo;
            tbEndereco.Text = funcionario.Endereco;
            nSalario.Value = funcionario.Salario;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            string endereco = tbEndereco.Text;
            string cargo = tbCargo.Text;
            decimal salario = nSalario.Value;

            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(endereco) || String.IsNullOrEmpty(cargo)
                || salario == 0)
            {
                MessageBox.Show("Todos os campos são obrigatórios");
                return;
            }

            funcionario = new Funcionario
            {
                Nome = nome,
                Endereco = endereco,
                Cargo = cargo,
                Salario = salario
            };
        }
    }
}
