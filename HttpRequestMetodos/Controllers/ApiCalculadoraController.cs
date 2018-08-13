using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HttpRequestMetodos.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HttpRequestMetodos.Controllers
{
    [Route("api/Calculadora")]
    public class ApiCalculadoraController : Controller
    {
        [Route("Subtrair")]
        [HttpGet(Name = "Subtrair")]
        public int Subtrair(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        
        [Route("Multiplicao")]
        [HttpGet(Name = "Multiplicao")]
        public int Multiplicao(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        [Route("CalcularTudo")]
        [HttpPost(Name = "CalcularTudo")]
        public IActionResult CalcularTudo([FromBody] Calcular[] calcular)
        {
            JObject retorno = new JObject();
            foreach (var _calcular in calcular) {
                JArray array = new JArray();
                var subtracao = this.Subtrair(_calcular.Valor1, _calcular.Valor2);
                array.Add(subtracao);
                retorno.Add("Subtrair", array);
                array = new JArray();
                var multiplicao = this.Multiplicao(_calcular.Valor1, _calcular.Valor2);
                array.Add(multiplicao);
                retorno.Add("Adicao", array);
                array = null;

            }
            return Json(retorno);
        }
    }
}
