using System;
using System.Linq;
using System.Web.Mvc;
using MaisGanha.LojaVirtual.Web.HtmlHelpers;
using MaisGanha.LojaVirtual.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaisGanha.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestMaisGanha
    {
        [TestMethod]
        public void Take()
        {
            int[] numeros = {5,4,1,3,9,8,6,7,2,0};

            var resultado = from num in numeros.Take(5) select num;

            int[] teste = {5, 4, 1, 3, 9};

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }
        
        [TestMethod]
        public void Skip()
        {
            int[] numeros =  {5,4,1,3,9,8,6,7,2,0};

            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = {1, 3, 9};

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }

        [TestMethod]
        public void TestaPaginacao()
        {
            //Arrange
            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao
            {
                ItensPorPagina = 10,
                ItensTotal = 28,
                PaginaAtual = 2
            };

            Func<int, string> PaginaUrl = p => "Pagina" + p.ToString();

           //Act
            MvcHtmlString resultado = html.PageLinks(paginacao, PaginaUrl);

            //Assert
            Assert.AreEqual(
                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>"
                , resultado.ToString());
        }
    }
}
