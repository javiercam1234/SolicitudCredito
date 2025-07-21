using System.Text.Json.Serialization;

namespace CreditApp.Domain.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EstadoSolicitud
{
    EnAnalisis,
    Aprobada,
    Rechazada
}