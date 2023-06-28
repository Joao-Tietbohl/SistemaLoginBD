using SistemaLoginBD.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginBD.Apresentação
{
    public interface IListagem
    {
        void AtualizarGrid();

        int SelecionarEntidadePorIdGrid();
    }
}
