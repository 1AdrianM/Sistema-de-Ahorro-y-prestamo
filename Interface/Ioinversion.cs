using Sistema_De_Ahorro_y_Prestamos_v2.Models;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Interface
{
    public interface Ioinversion
    {

        Task<IEnumerable<Inversione>> GetInversioneById(int id);

        bool Add(Inversione inversione);
        bool Delete(Inversione inversione);
        bool Update(Inversione inversione);
        bool Save();
    }
}
