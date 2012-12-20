using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Animal:EntidadePadrao
    {
        public Animal()
        {
            this.Animal_Vacina = new List<Animal_Vacina>();
            this.Exames = new List<Exame>();
        }
        
        public string Identificacao { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public bool MorteAbate { get; set; }
        public decimal Peso { get; set; }
        public int Localizacao_Id { get; set; }
        public string Nome { get; set; }
        public int FaseCriacao_Id { get; set; }
        public int UnidadeMedida_Id { get; set; }
        public int Lote_Id { get; set; }
        public virtual FaseCriacao FaseCriacao { get; set; }
        public virtual Localizacao Localizacao { get; set; }
        public virtual Lote Lote { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
        public virtual ICollection<Animal_Vacina> Animal_Vacina { get; set; }
        public virtual ICollection<Exame> Exames { get; set; }
    }
}
