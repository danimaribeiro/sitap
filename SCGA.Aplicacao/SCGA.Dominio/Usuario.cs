using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCGA.Dominio
{
    public class Usuario : EntidadePadrao
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public string Username { get; set; }
        public string Senha { get; set; }
        public string Sessao { get; set; }
    }
}
