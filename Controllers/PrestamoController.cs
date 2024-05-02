using Microsoft.AspNetCore.Mvc;
using Sistema_De_Ahorro_y_Prestamos_v2.Interface;
using Sistema_De_Ahorro_y_Prestamos_v2.Models;
using Sistema_De_Ahorro_y_Prestamos_v2.Repositorio;
using Sistema_De_Ahorro_y_Prestamos_v2.ViewModels;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Controllers
{
    public class PrestamoController : Controller
    {
        private readonly PrestamoRepository _prestamo;
        private readonly ahorro_prestamoDbContext _context;
        private readonly GarantiaRepository _garantia;

        public PrestamoController(ahorro_prestamoDbContext context, PrestamoRepository prestamo, GarantiaRepository garantia)
        {
            _prestamo = prestamo;
            _context  = context;
            _garantia = garantia;
        }
      
        public IActionResult Index()
        {
            return View();
     
        }

        [HttpGet]
        public IActionResult CreatePrestamo(int id){


           var garantia = _garantia.GetGarantiaById(id);

            var prestamo = _prestamo.GetPrestamoById(id);
        
        /*    var PrestmoVM = CreatePrestamoViewModel{


          IdPrestamo
        FechaSolicitud
        DateTime? FechaAppro 
        DateTime? FechaInicio 
         DateTime? FechaTermino 
         IdClienteFiador 
        IdClientPrestatario 
         IdGarantia 
         Monto 
         Interes 
         TipoGarantia 
         Valor 
         Ubicacion 


    };

            var garantiaVM = GarantiaViewModel{


            };*/

            return View();  
        }

        [HttpPost]
        public IActionResult CreatePrestamo(CreatePrestamoViewModel prestamoViewModel,  DateTime? FechaSolicitud)
        {
            if (!ModelState.IsValid) return View("Error");

            var prestamo = new Prestamo
            { 
            
            };
            var new_garantia = new Garantium()
            { 
            };
            _prestamo.Add(prestamo);
            _garantia.Add(new_garantia);

            var Solicitud_Aprobada = _prestamo.SolicitudPrestamo(prestamo, FechaSolicitud);
          

            return View();
        }

     [HttpGet]    
    public async Task<IActionResult> Garantia(int id)
        {
            var Garantia =  await _garantia.GetGarantiaById(id);

            var new_garantia = new GarantiaViewModel()
            {
        //IdGarantia = id, 
        //TipoGarantia = Garantia?.TipoGarantia, 
        //Valor =     Garantia?.Valor,
        //Ubicacion = Garantia?.Ubicacion
       };

          return View(new_garantia);
        }
           
        
     [HttpPost]    
    public IActionResult Garantia(GarantiaViewModel garantiaViewModel)
        {

            

            return View(); 
        }
    
    }

}
