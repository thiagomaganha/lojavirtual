using System.Linq;
using System.Web.Mvc;
using MaisGanha.LojaVirtual.Dominio.Repositorio;
using MaisGanha.LojaVirtual.Web.Models;

namespace MaisGanha.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;

        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();
            ProdutosViewModel produto = new ProdutosViewModel()
            {
                Produtos = _repositorio.Produtos
                    .OrderBy(p => p.Descricao)
                    .Skip((pagina - 1)*ProdutosPorPagina)
                    .Take(ProdutosPorPagina),

                paginacao = new Paginacao()
                {
                    ItensPorPagina = 8,
                    ItensTotal = _repositorio.Produtos.Count(),
                    PaginaAtual = pagina
                }
            };
            

            return View(produto);
        }
    }
}