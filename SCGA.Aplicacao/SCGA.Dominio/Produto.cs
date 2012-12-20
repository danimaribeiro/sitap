using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Produto:EntidadePadrao
    {
        public Produto()
        {
            this.Produto_Racao = new List<Produto_Racao>();
        }
        
        public string Nome { get; set; }        
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public int UnidadeMedida_Id { get; set; }        
        public int Grupo_Id { get; set; }
        public virtual Grupo Grupo { get; set; }
        public virtual ICollection<Produto_Racao> Produto_Racao { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
    }
}
