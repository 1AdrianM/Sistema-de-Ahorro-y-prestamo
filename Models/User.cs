using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;


namespace Sistema_De_Ahorro_y_Prestamos_v2.Models
{
    public partial class User: IdentityUser
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public virtual Cliente IdNavigation { get; set; } = null!;
    }
}
