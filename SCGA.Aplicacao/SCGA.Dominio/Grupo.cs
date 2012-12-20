using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Grupo:EntidadePadrao
    {
        public Grupo()
        {
            this.Produtoes = new List<Produto>();
        }
                
        public string Descricao { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<Produto> Produtoes { get; set; }
    }
}
