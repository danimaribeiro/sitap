using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Racao:EntidadePadrao
    {
        public Racao()
        {
            this.Produto_Racao = new List<Produto_Racao>();
        }
                
        public string Descricao { get; set; }
        public int PeriodoValidade { get; set; }
        public int UnidadeMedida_Id { get; set; }        
        public virtual ICollection<Produto_Racao> Produto_Racao { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
    }
}
