using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCGA.Dominio
{
    public class EntidadePadrao
    {
        public long Id { get; set; }
        public int Codigo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
    }
}
