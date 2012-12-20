using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class FaseCriacao:EntidadePadrao
    {
        public FaseCriacao()
        {
            this.Animals = new List<Animal>();
            this.Lotes = new List<Lote>();
        }
                
        public string Descricao { get; set; }
        public int TempoCriacao { get; set; }
        public int UnidadeMedida_Id { get; set; }        
        public virtual ICollection<Animal> Animals { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
        public virtual ICollection<Lote> Lotes { get; set; }
    }
}
