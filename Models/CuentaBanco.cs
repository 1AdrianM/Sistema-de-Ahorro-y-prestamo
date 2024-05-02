using System;
using System.Collections.Generic;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Models
{
    public partial class CuentaBanco
    {
        public CuentaBanco()
        {
            Clientes = new HashSet<Cliente>();
            Inversiones = new HashSet<Inversione>();
        }

        public int NumeroCuenta { get; set; }
        public int? IdCliente { get; set; }
        public string? Banco { get; set; }
        public string? TipoCuenta { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Inversione> Inversiones { get; set; }
    }
}
