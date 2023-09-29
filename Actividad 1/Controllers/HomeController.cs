using Actividad_1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Actividad_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IndexViewModel vm = new()
            {
                NombreDeMateria = "Programacion Web",
                Semestre = 7,
                Periodo = "Agosto-Diciembre",
                NombreDeEs ="Angel Eduardo Perez Ferrer"


            };
            return View(vm);
        }

        public IActionResult MiPerfil() 
        {
            PerfilViewModel vm = new()
            {
                NombreDeEstudiante = "Angel Eduardo Perez Ferrer",
                Semestre = 7,
                NumeroControl = "201G0275",
                NumeroCelular = 861615301
                
            };


            return View(vm); 
        }
    }
}
