using Microsoft.EntityFrameworkCore;
using Sistema_De_Ahorro_y_Prestamos_v2.Interface;
using Sistema_De_Ahorro_y_Prestamos_v2.Models;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Repositorio
{
    public class UserRepository : IUser
    {
        private readonly ahorro_prestamoDbContext _context;
       public UserRepository (ahorro_prestamoDbContext context)
        {
            _context = context;
        }
        public bool Add(User user)
        {
             _context.Add(user);
            return Save();
        }

        public bool Delete(User user)
        {
            _context.Remove(user);
            return Save();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
           return await _context.Users.ToListAsync();  
        }

        public async Task<User?> GetUserById(string id)
        {
            return await _context.Users.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(User user)
        {
            _context.Update(user);
            return Save();
        }
    }
}
