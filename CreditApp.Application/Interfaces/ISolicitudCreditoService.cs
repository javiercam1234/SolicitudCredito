using CreditApp.Domain.Entities;

namespace CreditApp.Application.Interfaces;

public interface ISolicitudCreditoService
{
    Task<IEnumerable<SolicitudCredito>> GetAllAsync();
    Task<SolicitudCredito?> GetByIdAsync(int id);
    Task<SolicitudCredito> CreateAsync(SolicitudCredito solicitud);
    Task<bool> UpdateAsync(SolicitudCredito solicitud);
    Task<bool> DeleteAsync(int id);
}
