using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class TipoContato:EntidadePadrao
    {
        public TipoContato()
        {
            this.Contatoes = new List<Contato>();
        }
                
        public string Descricao { get; set; }        
        public virtual ICollection<Contato> Contatoes { get; set; }
    }
}
