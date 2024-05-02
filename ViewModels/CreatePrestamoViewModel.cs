using Sistema_De_Ahorro_y_Prestamos_v2.Models;

namespace Sistema_De_Ahorro_y_Prestamos_v2.ViewModels
{
    public class CreatePrestamoViewModel
    {
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
        public string? TipoGarantia { get; set; }
        public string? Valor { get; set; }
        public string? Ubicacion { get; set; }


        public virtual Cliente? IdClienteFiadorNavigation { get; set; }
        public virtual Garantium? IdGarantiaNavigation { get; set; }

    }
}
