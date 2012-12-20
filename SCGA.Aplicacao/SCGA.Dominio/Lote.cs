using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Lote:EntidadePadrao
    {
        public Lote()
        {
            this.Animals = new List<Animal>();
        }
        
        public string Descricao { get; set; }
        public System.DateTime DataInicio { get; set; }
        public decimal Duracao { get; set; }
        public int FaseCriacao_Id { get; set; }
        public int UnidadeMedida_Id { get; set; }
        public int Localizacao_Id { get; set; }        
        public virtual ICollection<Animal> Animals { get; set; }
        public virtual FaseCriacao FaseCriacao { get; set; }
        public virtual Localizacao Localizacao { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
    }
}
