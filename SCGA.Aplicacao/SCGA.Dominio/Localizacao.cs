using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Localizacao:EntidadePadrao
    {
        public Localizacao()
        {
            this.Animals = new List<Animal>();
            this.ExecucaoLimpezas = new List<ExecucaoLimpeza>();
            this.Lotes = new List<Lote>();
        }

        public string Descricao { get; set; }
        public string Local { get; set; }        
        public virtual ICollection<Animal> Animals { get; set; }
        public virtual ICollection<ExecucaoLimpeza> ExecucaoLimpezas { get; set; }
        public virtual ICollection<Lote> Lotes { get; set; }
    }
}
