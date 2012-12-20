using System;
using System.Collections.Generic;

namespace SCGA.Dominio
{
    public class Produto_Racao : EntidadePadrao
    {
        public int Racao_Id { get; set; }
        public int Produto_Id { get; set; }
        public int QtdePorUnidade { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Racao Racao { get; set; }
    }
}
