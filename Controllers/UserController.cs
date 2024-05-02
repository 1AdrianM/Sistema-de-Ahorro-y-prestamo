using Microsoft.AspNetCore.Mvc;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetUser()
        {
            return View();
        }
        public IActionResult CreateUser()
        {
            return View();
        }  
        public IActionResult UpdateUser()
        {
            return View();
        }   
        public IActionResult DeleteUser()
        {
            return View();
        }
    }
}
