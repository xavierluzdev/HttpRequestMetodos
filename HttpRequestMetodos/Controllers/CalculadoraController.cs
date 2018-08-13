using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HttpRequestMetodos.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult RaizQuadrada64()
        {

            var raizQuadrada = Math.Sqrt(64);

            return Json(raizQuadrada);
        }
        [HttpGet]
        public JsonResult Acrescentar(int valor)
        {

            var retorno = 100 + valor;

            return Json(retorno);
        }
        [HttpGet]
        public JsonResult Somar(int valor1, int valor2)
        {

            var retorno = valor1 + valor2;

            return Json(retorno);
        }
    }
}
