
using System;
using System.Security.AccessControl;

namespace MaisGanha.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int ItensPorPagina { get; set; }
        public int ItensTotal { get; set; }
        public int PaginaAtual { get; set; }

        public int TotalPaginas
        {
            get { return (int) Math.Ceiling((decimal) ItensTotal/ItensPorPagina); }
            
        }
    }
}