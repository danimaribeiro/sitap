using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCGA.Dominio.Common
{
    public class Filtro
    {
        public Filtro(string filtrarPor) : this(filtrarPor, 1, 10) { }
        public Filtro(string filtrarPor, int pagina) : this(filtrarPor, pagina, 10) { }
        public Filtro(string filtrarPor, int pagina, int quantidadePagina)
        {
            Pagina = pagina;
            QuantidadePagina = quantidadePagina;
            FiltrarPor = filtrarPor;
        }

        public int Pagina { get; set; }
        public int QuantidadePagina { get; set; }
        public string FiltrarPor { get; set; }
    }
}
