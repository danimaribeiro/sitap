using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Exame:EntidadePadrao
    {
        public int Animal_Id { get; set; }
        public int Doenca_Id { get; set; }
        public System.DateTime DataExame { get; set; }
        public bool Resultado { get; set; }
        public string Observacao { get; set; }        
        public virtual Animal Animal { get; set; }
        public virtual Doenca Doenca { get; set; }
    }
}
