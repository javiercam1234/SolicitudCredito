using CreditApp.Domain.Enums;

public class SolicitudCredito
{
    public int Id { get; set; }
    public string NombreCliente { get; set; }
    public decimal Monto { get; set; }
    public string Estado { get; set; }
}
