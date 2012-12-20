using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Funcionario:EntidadePadrao
    {
        public Funcionario()
        {
            this.ExecucaoLimpezas = new List<ExecucaoLimpeza>();
        }
        
        public string Nome { get; set; }
        public int Contato_Id { get; set; }
        
        public virtual Contato Contato { get; set; }
        public virtual ICollection<ExecucaoLimpeza> ExecucaoLimpezas { get; set; }
    }
}
