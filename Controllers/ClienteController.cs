using Microsoft.AspNetCore.Mvc;
using Sistema_De_Ahorro_y_Prestamos_v2.Data.Enum;
using Sistema_De_Ahorro_y_Prestamos_v2.Interface;
using Sistema_De_Ahorro_y_Prestamos_v2.Models;
using Sistema_De_Ahorro_y_Prestamos_v2.Repositorio;
using Sistema_De_Ahorro_y_Prestamos_v2.ViewModels;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Controllers
{
    
    public class ClienteController : Controller
    {
        private readonly ICliente _cliente;
       
        public ClienteController(ICliente cliente)
    {
        _cliente = cliente;

    }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateClienteViewModel ClienteVM)
        {
            if (!ModelState.IsValid)
            {
                return View(ClienteVM);
            }
            var club = new Cliente()
            {
                Id = ClienteVM.Id,
                TipoCliente = ClienteVM.TipoCliente,
                Cedula = ClienteVM.Cedula,
                Nombre = ClienteVM.Nombre,
                BancoCuenta = ClienteVM.BancoCuenta,
                Direccion = ClienteVM.Direccion,
                Telefono = ClienteVM.Telefono
            };

     _cliente.Add(club);
            if (club.TipoCliente == "Prestamo")
            {
                return RedirectToAction("RegiterPrestamo", "Prestamo");
            }
            else if (club.TipoCliente == "Inversionista")
            {
                return RedirectToAction("RegisterInversion", "Inversiones");
            }
            else
            {
                return RedirectToAction("Dash", "Home");
            }
            }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var cliente = await _cliente.GetClientById(id);

            var ClienteVM = new EditViewModel()
            {
                Id = id,
                TipoCliente = cliente?.TipoCliente,
                Cedula = cliente?.Cedula,
                Nombre = cliente?.Nombre,
                BancoCuenta = cliente?.BancoCuenta,
                Direccion = cliente?.Direccion,
                Telefono = cliente?.Telefono
            };


            return View(ClienteVM);
        }
        [HttpPost]

        public async Task<IActionResult> Update(int id, EditViewModel editViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to load ");
                return View(editViewModel);
            }

           var cliente =  await _cliente.GetClientByIdByTracking(id);
            if(cliente == null)
            {

                return View("Error");
            }
            var Cliente = new Cliente()
            {
                Id = editViewModel.Id,
                TipoCliente =  editViewModel.TipoCliente,
                Cedula = editViewModel.Cedula,
                Nombre = editViewModel.Nombre,
                BancoCuenta = editViewModel.BancoCuenta,
                Direccion = editViewModel.Direccion,
                Telefono = editViewModel.Telefono
            };

            _cliente.Update(Cliente);

            return RedirectToAction("Dash", "Home");
        }


    }

}
