using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Veterinario:EntidadePadrao 
    {
        public Veterinario()
        {
            this.Animal_Vacina = new List<Animal_Vacina>();
        }

        
        public string Nome { get; set; }        
        public string Crmv { get; set; }
        public string Telefone { get; set; }        
        public virtual ICollection<Animal_Vacina> Animal_Vacina { get; set; }
    }
}
