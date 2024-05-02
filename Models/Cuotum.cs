using System;
using System.Collections.Generic;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Models
{
    public partial class Cuotum
    {
        public int IdCuotas { get; set; }
        public int? IdPrestamo { get; set; }
        public int? IdInversiones { get; set; }
        public DateTime? FechaPlanificada { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaPago { get; set; }
        public string? TipoPago { get; set; }
        public string? CodigoComprobante { get; set; }

        public virtual Inversione? IdInversionesNavigation { get; set; }
        public virtual Prestamo? IdPrestamoNavigation { get; set; }
    }
}
