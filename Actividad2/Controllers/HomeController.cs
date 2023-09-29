using Actividad2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(MonedaViewModel m, string moneda)
        {

            if (moneda == "MXN")
            {
                m.ConversionTotal = $"{(m.CantIngresada * 18)} pesos";
            }
            else if (moneda == "USD")
            {
                m.ConversionTotal = $"{(m.CantIngresada / 18)} dolares";
            }
            return View(m);
        }
    }
}
