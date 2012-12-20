using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Animal_Vacina:EntidadePadrao
    {
        public int Animal_Id { get; set; }
        public int Vacina_Id { get; set; }
        public System.DateTime DataVacinacao { get; set; }        
        public int Veterinario_Id { get; set; }
        public string Observacao { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual Vacina Vacina { get; set; }
        public virtual Veterinario Veterinario { get; set; }
    }
}
