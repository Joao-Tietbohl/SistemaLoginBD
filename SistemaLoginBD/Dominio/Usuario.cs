﻿using SistemaLoginBD.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginBD
{
    public class Usuario : EntidadeBase
    {
        public string Login { get; set; }
        public string Senha { get; set; }      
        public string Email { get; set; } 

    }
}
