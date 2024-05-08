using Sistema_De_Ahorro_y_Prestamos_v2.Models;

namespace Sistema_De_Ahorro_y_Prestamos_v2.ViewModels
{
    public class CreateInversionesViewModel
    {
        public int IdInversiones { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaAppro { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaTermino { get; set; }
        public string? TipoGarantia { get; set; }
        public string? Valor { get; set; }
        public string? Ubicacion { get; set; }

    }
}
