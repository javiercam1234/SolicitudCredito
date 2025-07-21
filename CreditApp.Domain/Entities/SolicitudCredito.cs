using System.ComponentModel.DataAnnotations;
using CreditApp.Domain.Enums;

namespace CreditApp.Domain.Entities
{
    public class SolicitudCredito
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio")]
        public string NombreCliente { get; set; }

        [Required(ErrorMessage = "El monto es obligatorio")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un estado")]
        public string? Estado { get; set; }  
    }
}