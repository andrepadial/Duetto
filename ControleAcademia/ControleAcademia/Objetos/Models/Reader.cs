using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleAcademia.Objetos.Models
{
    public class Reader<T>
    {
        /// <summary>
        /// Número de páginas retornadas no registro
        /// </summary>
        public int total { get; set; }
        /// <summary>
        /// Página atual que a Grid exibirá
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// Número total de registros na base.
        /// </summary>
        public int records { get; set; }
        /// <summary>
        /// Lista com cada registro.
        /// </summary>
        public List<T> rows { get; set; }

        /// <summary>
        /// Construtor recebe a lista e faz a paginação virtual.
        /// </summary>
        /// <param name="lista">Lista com os registros</param>
        /// <param name="paginaAtual">Página atual.</param>
        /// <param name="totalPorPagina">Total de registros por páginas</param>
        /// 

        public Reader(List<T> lista, int paginaAtual, int totalPorPagina)
        {

            var totalRegistros = lista.Count();
            page = paginaAtual;
            var ini = (page - 1) * totalPorPagina;
            var fim = totalRegistros > totalPorPagina ? totalPorPagina : totalRegistros;

            if (ini > 0)
            {
                fim = totalPorPagina;
                fim = fim - 10 >= 0 ? totalRegistros % totalPorPagina : fim;
            }
            var totalPags = totalRegistros / totalPorPagina;
            if (totalRegistros % totalPorPagina > 0)
            {
                totalPags++;
            }
            total = totalPags;
            page = page;
            records = totalRegistros;
            rows = lista.ToList().GetRange(ini, fim);
        }
    }
}