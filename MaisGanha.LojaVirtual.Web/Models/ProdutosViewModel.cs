using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MaisGanha.LojaVirtual.Dominio.Entidades;

namespace MaisGanha.LojaVirtual.Web.Models
{
    public class ProdutosViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }

        public Paginacao paginacao { get; set; }
    }
}