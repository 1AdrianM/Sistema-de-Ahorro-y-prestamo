using Sistema_De_Ahorro_y_Prestamos_v2.Models;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Interface
{
    public interface IGarantia
    {
        Task<Garantium?> GetGarantiaById(int id);
        bool Add(Garantium garantia);
        bool Delete(Garantium garantia);
        bool Update(Garantium garantia);
        bool Save();
    }
}
