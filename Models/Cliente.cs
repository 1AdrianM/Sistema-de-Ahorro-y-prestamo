using System;
using System.Collections.Generic;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            CuentaBancos = new HashSet<CuentaBanco>();
            Inversiones = new HashSet<Inversione>();
            PrestamoIdClientPrestatarioNavigations = new HashSet<Prestamo>();
            PrestamoIdClienteFiadorNavigations = new HashSet<Prestamo>();
        }

        public int Id { get; set; }
        public string? TipoCliente { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public int? BancoCuenta { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? IdsCodprestamo { get; set; }
        public string? IdsInversiones { get; set; }
        public string? Address { get; set; }
        public string? Genre { get; set; }

        public virtual CuentaBanco? BancoCuentaNavigation { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<CuentaBanco> CuentaBancos { get; set; }
        public virtual ICollection<Inversione> Inversiones { get; set; }
        public virtual ICollection<Prestamo> PrestamoIdClientPrestatarioNavigations { get; set; }
        public virtual ICollection<Prestamo> PrestamoIdClienteFiadorNavigations { get; set; }
    }
}
