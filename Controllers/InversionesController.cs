using Microsoft.AspNetCore.Mvc;
using Sistema_De_Ahorro_y_Prestamos_v2.Repositorio;
using Sistema_De_Ahorro_y_Prestamos_v2.ViewModels;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Controllers
{
    public class InversionesController : Controller
    {
        private readonly InversionistaRepository _inversion;
        public InversionesController(InversionistaRepository inversion){
            _inversion = inversion;

        }
        public IActionResult Index()
        {
            return View();
        }
       [HttpGet]
        public IActionResult Create(){
              
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateInversionesViewModel inversionesViewModel){
            
            return View();
        }
    }
}
