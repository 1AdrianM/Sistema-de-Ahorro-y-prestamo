using System;
using System.Collections.Generic;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Models
{
    public partial class Prestamo
    {
        public Prestamo()
        {
            Cuota = new HashSet<Cuotum>();
        }

        public int IdPrestamo { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaAppro { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaTermino { get; set; }
        public int? IdClienteFiador { get; set; }
        public int? IdClientPrestatario { get; set; }
        public int? IdGarantia { get; set; }
        public double? Monto { get; set; }
        public decimal? Interes { get; set; }

        public virtual Cliente? IdClientPrestatarioNavigation { get; set; }
        public virtual Cliente? IdClienteFiadorNavigation { get; set; }
        public virtual Garantium? IdGarantiaNavigation { get; set; }
        public virtual ICollection<Cuotum> Cuota { get; set; }
    }
}
