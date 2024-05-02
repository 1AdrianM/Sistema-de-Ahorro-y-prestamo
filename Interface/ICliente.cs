using Sistema_De_Ahorro_y_Prestamos_v2.Models;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Interface
{
    public interface ICliente
    {
        Task<Cliente?> GetClientById(int id);
        Task<Cliente?> GetClientByIdByTracking(int id);
        Task<IEnumerable<Cliente>> GetAllClients();
        Task<Prestamo?> GetPrestamoById(int id);
        bool Add(Cliente cliente);
        bool Delete (Cliente cliente);
        bool Update(Cliente cliente);
        bool Save ();

    }
}
