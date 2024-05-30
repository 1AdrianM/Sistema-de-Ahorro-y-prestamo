using Microsoft.AspNetCore.Mvc;
using Sistema_De_Ahorro_y_Prestamos_v2.Interface;
using Sistema_De_Ahorro_y_Prestamos_v2.Models;
using Sistema_De_Ahorro_y_Prestamos_v2.ViewModels;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Controllers
{
    public class PrestamoController : Controller
    {
        private readonly IPrestamo _prestamo;
        private readonly ahorro_prestamoDbContext _context;
        private readonly IGarantia _garantia;

        public PrestamoController(ahorro_prestamoDbContext context, IPrestamo prestamo, IGarantia garantia)
        {
            _prestamo = prestamo;
            _context = context;
            _garantia = garantia;
        }

        public IActionResult Index()
        {
            return View();

        }

        [HttpGet]
        public IActionResult Create()
        {


            var response = new CreatePrestamoViewModel();

            return View(response);
        }

        [HttpPost]
        public IActionResult Create(CreatePrestamoViewModel prestamoViewModel //DateTime? FechaSolicitud
            )
        {
            if (!ModelState.IsValid) return View("Error");

            var prestamo = new Prestamo()
            {
                IdPrestamo = prestamoViewModel.IdPrestamo,
                FechaSolicitud = prestamoViewModel.FechaSolicitud,
                FechaInicio = prestamoViewModel.FechaInicio,
                IdClienteFiador = prestamoViewModel.IdClienteFiador,
                IdClientPrestatario = prestamoViewModel.IdClientPrestatario,
                IdGarantia = prestamoViewModel.IdGarantia,
                Monto = prestamoViewModel.Monto,
                Interes = prestamoViewModel.Interes
            };
            var new_garantia = new Garantium()
            {

                IdGarantia = prestamoViewModel.IdGarantia,
                TipoGarantia = prestamoViewModel.TipoGarantia,
                Valor = prestamoViewModel.Valor,
                Ubicacion = prestamoViewModel.Ubicacion,

            };
            _prestamo.Add(prestamo);
            _garantia.Add(new_garantia);

            // var Solicitud_Aprobada = _prestamo.SolicitudPrestamo(prestamo, FechaSolicitud);


            return RedirectToAction("Dash");


        } 




    }
}
