using Microsoft.EntityFrameworkCore;
using Sistema_De_Ahorro_y_Prestamos_v2.Interface;
using Sistema_De_Ahorro_y_Prestamos_v2.Models;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Repositorio
{
    public class ClienteRepository : ICliente
    {
        private readonly ahorro_prestamoDbContext _context;

        public ClienteRepository (ahorro_prestamoDbContext context)
        {
            _context = context;
        }
        public bool Add(Cliente cliente)
        {
            _context.Add(cliente);
            return Save();
        }

        public bool Delete(Cliente cliente)
        {
            _context.Remove(cliente);
            return Save();
        }

        public async Task<IEnumerable<Cliente>> GetAllClients()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente?> GetClientById(int id)
        {
           return await _context.Clientes.FirstOrDefaultAsync(i => i.Id == id);
             
        }

        public async Task<Cliente?> GetClientByIdByTracking(int id)
        {
            return await _context.Clientes.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
                }

        public async Task<Prestamo?> GetClientePrestamoById(int id)
        {
          return await _context.Prestamos.FirstOrDefaultAsync(i => i.IdPrestamo == id);

        }

        public async Task<Cliente?> GetFiadorClientById(int id)
        {
          return await  _context.Clientes.Include(fd=> fd.PrestamoIdClienteFiadorNavigations).FirstOrDefaultAsync(i => i.Id==id );
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Cliente cliente)
        {
 _context.Update(cliente);
            return Save();
        }
    }
}
