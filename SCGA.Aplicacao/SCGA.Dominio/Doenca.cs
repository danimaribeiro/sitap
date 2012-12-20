using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Doenca:EntidadePadrao
    {
        public Doenca()
        {
            this.Exames = new List<Exame>();
        }
                
        public string Descricao { get; set; }
        public int Codigo { get; set; }        
        public virtual ICollection<Exame> Exames { get; set; }
    }
}
