using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using calculadoramvc.Models;

namespace ContactoController.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult Enviar(Calculadora objCalculadora){
            if ("+".Equals(objCalculadora.Accion)){
                objCalculadora.Respuesta = objCalculadora.Operador1 + objCalculadora.Operador2;
            }
            if ("-".Equals(objCalculadora.Accion)){
                objCalculadora.Respuesta = objCalculadora.Operador1 - objCalculadora.Operador2;
            }
            if ("*".Equals(objCalculadora.Accion)){
                objCalculadora.Respuesta = objCalculadora.Operador1 * objCalculadora.Operador2;
            }
            if ("/".Equals(objCalculadora.Accion)){
                objCalculadora.Respuesta = objCalculadora.Operador1 / objCalculadora.Operador2;
            }
            return View("index", objCalculadora);
        }*/
    }
}
