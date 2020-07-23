using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CalculadoraTeste.Models
{
    public class CalculadoraViewModel
    {
        /// <summary>
        /// Valor do Resgate da Aplicação
        /// </summary>
        [Display(Name = "Valor do Resgate")]
        public double Num1 { get; set; }

        /// <summary>
        /// Valor do Resgate da Aplicação
        /// </summary>
        ///[Display(Name = "Valor do Resgate")]
        ///public int Num2 { get; set; }

        /// <summary>
        /// Operador
        /// </summary>
        [Display(Name = "Período da Aplicação")]
        public int Operador { get; set; }

        /// <summary>
        /// Resultado do Calculo IR
        /// </summary>
        [Display(Name = "Valor com desconto do IR")]
        public int? Resultado { get; set; }
    }
}