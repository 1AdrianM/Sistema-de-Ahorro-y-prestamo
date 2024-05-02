using Sistema_De_Ahorro_y_Prestamos_v2.Models;
namespace Sistema_De_Ahorro_y_Prestamos_v2.ViewModels
{
    public class EditViewModel
    {
        public int Id { get; set; }
        public string? TipoCliente { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public int? BancoCuenta { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
    }
}
