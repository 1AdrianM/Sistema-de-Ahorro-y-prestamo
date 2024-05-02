using Sistema_De_Ahorro_y_Prestamos_v2.Models;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Interface
{
    public interface IUser
    {
       Task <IEnumerable<User>> GetAll();
       Task <User?> GetUserById(int id);
        bool Add(User user);
        bool Update(User user);
        bool Delete(User user);
        bool Save();
    }
}
