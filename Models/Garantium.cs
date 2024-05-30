using System;
using System.Collections.Generic;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Models
{
    public partial class Garantium
    {
        public Garantium()
        {
            Prestamos = new HashSet<Prestamo>();
       }

        public int?IdGarantia { get; set; }
        public string? TipoGarantia { get; set; }
        public string? Valor { get; set; }
        public string? Ubicacion { get; set; }

        public virtual ICollection<Prestamo> Prestamos { get; set; }
    }
}
