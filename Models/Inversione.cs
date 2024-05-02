using System;
using System.Collections.Generic;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Models
{
    public partial class Inversione
    {
        public Inversione()
        {
            Cuota = new HashSet<Cuotum>();
        }

        public int IdInversiones { get; set; }
        public decimal? MontoInversion { get; set; }
        public decimal? Interes { get; set; }
        public DateTime? FechaInversion { get; set; }
        public DateTime? FechaTermino { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public int? IdCliente { get; set; }
        public int? IdCuentaBanco { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual CuentaBanco? IdCuentaBancoNavigation { get; set; }
        public virtual ICollection<Cuotum> Cuota { get; set; }
    }
}
