using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginBD.Dominio
{
    public class Funcionario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string Endereco { get; set; }
    }
}
