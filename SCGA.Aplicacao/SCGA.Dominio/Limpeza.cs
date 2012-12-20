using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Limpeza:EntidadePadrao
    {
        public Limpeza()
        {
            this.ExecucaoLimpezas = new List<ExecucaoLimpeza>();
        }
        
        public string Descricao { get; set; }
        public System.DateTime DataExecutar { get; set; }
        public int PeriodoExecutarDias { get; set; }
        public bool ExecutarMaisUmaVez { get; set; }        
        public virtual ICollection<ExecucaoLimpeza> ExecucaoLimpezas { get; set; }
    }
}
