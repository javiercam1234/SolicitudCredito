using System.Collections.Generic;
using System.Threading.Tasks;

public class SolicitudCreditoViewModel
{
    private readonly ISolicitudCreditoService _service;

    public List<SolicitudCredito> Solicitudes { get; private set; } = new List<SolicitudCredito>();

    public SolicitudCreditoViewModel(ISolicitudCreditoService service)
    {
        _service = service;
    }

    public async Task LoadSolicitudesAsync()
    {
        Solicitudes = await _service.GetAllAsync();
    }

     
}
