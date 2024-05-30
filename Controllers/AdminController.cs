using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Sistema_De_Ahorro_y_Prestamos_v2.Repositorio;
using Sistema_De_Ahorro_y_Prestamos_v2.ViewModels;


namespace Sistema_De_Ahorro_y_Prestamos_v2.Controllers
{
    public class AdminController : Controller
    {
        private readonly PrestamoRepository _prestamo;
        public AdminController(PrestamoRepository prestamo)

        {
            _prestamo = prestamo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Panel()
        {
            return View();
       
        }
        [HttpPost]

        public IActionResult Panel(AdminViewModel adminVM)
        {
            if (!ModelState.IsValid) return View("Error");

            return View();
        }


    }
}