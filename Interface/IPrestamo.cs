using Sistema_De_Ahorro_y_Prestamos_v2.Models;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Interface
{
    public interface IPrestamo
    {
        
        Task<Prestamo?> GetPrestamoById(int id);
         bool SolicitudPrestamo(Prestamo prestamo, DateTime ?FechaSolicitud);
         decimal CalcularCuotaPrestamo(decimal Monto, decimal interes, int number_years, int paymentPerYear);
        decimal CalcularInteres_Simple(decimal Monto, decimal interes);


        bool Add(Prestamo prestamo);
        bool Delete(Prestamo prestamo);
        bool Update(Prestamo prestamo);
        bool Save();
    }
}
  