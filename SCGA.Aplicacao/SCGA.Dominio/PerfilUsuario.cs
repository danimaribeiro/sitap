using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class PerfilUsuario:EntidadePadrao
    {
        public PerfilUsuario()
        {
            this.Usuarios = new List<Usuario>();
        }
                
        public string Descricao { get; set; }        
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
