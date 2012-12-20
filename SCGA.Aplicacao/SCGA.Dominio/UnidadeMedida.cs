using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class UnidadeMedida:EntidadePadrao
    {
        public UnidadeMedida()
        {
            this.Animals = new List<Animal>();
            this.FaseCriacaos = new List<FaseCriacao>();
            this.Lotes = new List<Lote>();
            this.Produtoes = new List<Produto>();
            this.Racaos = new List<Racao>();
        }
        
        public string Descricao { get; set; }
        public string Sigla { get; set; }        
        public virtual ICollection<Animal> Animals { get; set; }
        public virtual ICollection<FaseCriacao> FaseCriacaos { get; set; }
        public virtual ICollection<Lote> Lotes { get; set; }
        public virtual ICollection<Produto> Produtoes { get; set; }
        public virtual ICollection<Racao> Racaos { get; set; }
    }
}
