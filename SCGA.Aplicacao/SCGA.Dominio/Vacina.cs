using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Vacina:EntidadePadrao
    {
        public Vacina()
        {
            this.Animal_Vacina = new List<Animal_Vacina>();
        }

        public string Descricao { get; set; }        
        public virtual ICollection<Animal_Vacina> Animal_Vacina { get; set; }
    }
}
