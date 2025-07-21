using System.Collections.Generic;
using System.Threading.Tasks;

public interface ISolicitudCreditoService
{
    Task<List<SolicitudCredito>> GetAllAsync();
    Task<SolicitudCredito> GetByIdAsync(int id);
    Task CreateAsync(SolicitudCredito solicitud);
    Task UpdateAsync(SolicitudCredito solicitud);
    Task DeleteAsync(int id);
}
