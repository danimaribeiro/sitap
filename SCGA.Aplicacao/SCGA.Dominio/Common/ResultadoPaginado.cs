using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCGA.Dominio.Common
{
    public class ResultadoPaginado<T>
    {
        public ResultadoPaginado(T resultado, long registros)
        {
            Resultado = resultado;
            QuantidadeRegistros = registros;
        }

        public ResultadoPaginado(T resultado, long registros, Filtro filtros)
        {
            Resultado = resultado;
            QuantidadeRegistros = registros;
            Filtros = filtros;
        }

        public T Resultado { get; set; }
        public Filtro Filtros { get; set; }
        public long QuantidadeRegistros { get; set; }
    }
}
