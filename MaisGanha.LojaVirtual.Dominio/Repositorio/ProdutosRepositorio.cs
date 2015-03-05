using System.Collections.Generic;
using MaisGanha.LojaVirtual.Dominio.Entidades;

namespace MaisGanha.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        protected readonly EFDBContext _context = new EFDBContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }

 
    }
}
