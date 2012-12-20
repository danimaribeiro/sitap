using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class ExecucaoLimpeza:EntidadePadrao
    {   
        public int Limpeza_Id { get; set; }
        public int Localizacao_Id { get; set; }
        public int Funcionario_Id { get; set; }
        public System.DateTime DataExecucao { get; set; }
        public string Observacao { get; set; }        
        public virtual Funcionario Funcionario { get; set; }
        public virtual Limpeza Limpeza { get; set; }
        public virtual Localizacao Localizacao { get; set; }
    }
}
