using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginBD.Dominio
{
    public class Venda : EntidadeBase
    {
        public Funcionario Funcionario { get; set; }
        public List<Produto> Produtos { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataVenda { get; set; }

        public Venda()
        {
            Produtos = new List<Produto>();
        }
    }
}
