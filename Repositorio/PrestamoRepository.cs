using Microsoft.EntityFrameworkCore;
using Sistema_De_Ahorro_y_Prestamos_v2.Interface;
using Sistema_De_Ahorro_y_Prestamos_v2.Models;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Repositorio
{
    public class PrestamoRepository : IPrestamo
    {
        bool prestamoAproved = false;

        private readonly ahorro_prestamoDbContext _context;

        public PrestamoRepository(ahorro_prestamoDbContext context) {
            _context = context;
        }
        public bool Add(Prestamo prestamo)
        {
            _context.Add(prestamo);
            return Save();
        }

    

        public decimal CalcularCuotaPrestamo(decimal Monto, decimal interes, int number_years, int paymentPerYear)
        {
            //Datos del prestamo
            
         
            interes = 0.010m;
            number_years = 3;
            paymentPerYear = 12;
            //Calcular prestamo Mensual
            decimal interes_mensual = interes / paymentPerYear;
            decimal totalAmmountofPays = number_years * paymentPerYear;
            decimal MonthlyPayment = (Monto * interes_mensual) / (1 - (decimal)Math.Pow(1 + (double)interes_mensual, -(double)totalAmmountofPays));
           
            return MonthlyPayment;
        }

        public decimal CalcularInteres_Simple(decimal Monto, decimal interes)
        {
           decimal S_interes = Monto * interes/ 100;
            return S_interes;
        }

        public bool CalcularPrestamo()
        {
            return Save();
        }

        public bool Delete(Prestamo prestamo)
        {
            _context.Remove(prestamo);
            return Save();
        }

        public async Task<Prestamo?> GetPrestamoById(int id)
        {
            return await _context.Prestamos.FirstOrDefaultAsync(i => i.IdPrestamo == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;

                }
        //Agregar Asyncronia 
        public bool SolicitudPrestamo(Prestamo prestamo, DateTime? FechaSolicitud)
        {
            FechaSolicitud = prestamo.FechaSolicitud;

            FechaSolicitud = DateTime.Now;
     
            Timer timer = new Timer(AprobarPrestamo, prestamo, (int)TimeSpan.FromSeconds(5).TotalMilliseconds, Timeout.Infinite) ;

            if(timer != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void AprobarPrestamo(object? state)
        {
            Prestamo prestamo = new Prestamo();
            if (prestamo.IdClienteFiador != null) {
               prestamoAproved = true;
            }
        }

        public bool Update(Prestamo prestamo)
        {
            _context.Update(prestamo);
            return Save();
        }

   //Por Agregar mas funcionalidades
    }
}
