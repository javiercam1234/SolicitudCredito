using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

public class SolicitudCreditoService : ISolicitudCreditoService
{
    private readonly HttpClient _httpClient;

    public SolicitudCreditoService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<SolicitudCredito>> GetAllAsync() =>
        await _httpClient.GetFromJsonAsync<List<SolicitudCredito>>("api/solicitudes");

    public async Task<SolicitudCredito> GetByIdAsync(int id) =>
        await _httpClient.GetFromJsonAsync<SolicitudCredito>($"api/solicitudes/{id}");

    public async Task CreateAsync(SolicitudCredito solicitud) =>
        await _httpClient.PostAsJsonAsync("api/solicitudes", solicitud);

    public async Task UpdateAsync(SolicitudCredito solicitud) =>
        await _httpClient.PutAsJsonAsync($"api/solicitudes/{solicitud.Id}", solicitud);

    public async Task DeleteAsync(int id) =>
        await _httpClient.DeleteAsync($"api/solicitudes/{id}");
}
