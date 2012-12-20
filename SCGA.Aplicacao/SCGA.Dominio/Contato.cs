using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Contato:EntidadePadrao
    {
        public Contato()
        {
            this.Funcionarios = new List<Funcionario>();
        }
        
        public string Descricao { get; set; }        
        public int TipoContato_Id { get; set; }
        public virtual TipoContato TipoContato { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
