using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Usuario :EntidadePadrao 
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public string Sessao { get; set; }
        public int PerfilUsuario_Id { get; set; }
        public virtual PerfilUsuario PerfilUsuario { get; set; }
    }
}
