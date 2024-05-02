using System.ComponentModel.DataAnnotations;

namespace Sistema_De_Ahorro_y_Prestamos_v2.ViewModels
{
    public class LoginViewModel
    {
        
        [Required]
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}  
