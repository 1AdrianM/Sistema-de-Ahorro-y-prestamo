using Sistema_De_Ahorro_y_Prestamos_v2.Models;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Interface
{
    public interface ICuota
    {
        Task<Cuotum?> GetPrestamoById(int id);
        Task<Cuotum?> GetInversionesById(int id);
     
        bool Add(Cuotum cuota);
        bool Update(Cuotum cuota);
        bool Delete(Cuotum cuota);
        bool Save();

        
    }
}
