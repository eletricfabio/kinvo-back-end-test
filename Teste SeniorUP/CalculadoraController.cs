using CalculadoraTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CalculadoraTeste.Controllers
{
    public class CalculadoraController : Controller
    {
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CalculadoraViewModel calculadoraViewModel)
        {
            ModelState.Clear();
            if (calculadoraViewModel.Operador <= 11)
            {
                calculadoraViewModel.Resultado = ((int?)(calculadoraViewModel.Num1 - ((22.5) * (calculadoraViewModel.Num1) / 100)));
            }
            else
            if (calculadoraViewModel.Operador > 11 && calculadoraViewModel.Operador <= 23)
            {
                calculadoraViewModel.Resultado = ((int?)(calculadoraViewModel.Num1 - ((18.5) * (calculadoraViewModel.Num1) / 100)));
            }
            else
            if (calculadoraViewModel.Operador > 23)
            {
                calculadoraViewModel.Resultado = ((int?)(calculadoraViewModel.Num1 - ((15) * (calculadoraViewModel.Num1) / 100)));
            }
            return View(calculadoraViewModel);
        }
       
    }
}