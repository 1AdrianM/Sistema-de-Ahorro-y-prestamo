namespace Sistema_De_Ahorro_y_Prestamos_v2.ViewModels
{
    public class CreateClienteViewModel
    {
        public int Id { get; set; }
        public string? TipoCliente { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        
        public string? Genre { get; set; }
        public int? BancoCuenta { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
    }
}
