using Microsoft.EntityFrameworkCore;
using Sistema_De_Ahorro_y_Prestamos_v2.Interface;
using Sistema_De_Ahorro_y_Prestamos_v2.Models;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Repositorio
{
    public class GarantiaRepository : IGarantia
    {
        private readonly ahorro_prestamoDbContext _context;

        public GarantiaRepository(ahorro_prestamoDbContext context)
        {
            _context = context;
        }
        public bool Add(Garantium garantia)
        {
            _context.Add(garantia);
            return Save();
        }

        public bool Delete(Garantium garantia)
        {
            _context.Remove(garantia);
            return Save();
        }

        public async Task<Garantium?> GetGarantiaById(int id)
        {
         return await _context.Garantia.FirstOrDefaultAsync(i => i.IdGarantia == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Garantium garantia)
        {
            _context.Update(garantia);
            return Save();
        }
    }
}
