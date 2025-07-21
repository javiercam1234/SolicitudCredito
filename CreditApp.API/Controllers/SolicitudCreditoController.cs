using Microsoft.AspNetCore.Mvc;
using CreditApp.Application.Interfaces;
using CreditApp.Domain.Entities;

namespace CreditApp.API.Controllers;

[ApiController]
[Route("api/solicitudes")]
public class SolicitudCreditoController : ControllerBase
{
    private readonly ISolicitudCreditoService _service;

    public SolicitudCreditoController(ISolicitudCreditoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _service.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var item = await _service.GetByIdAsync(id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public async Task<IActionResult> Create(SolicitudCredito solicitud)
    {
        var created = await _service.CreateAsync(solicitud);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, SolicitudCredito solicitud)
    {
        if (id != solicitud.Id) return BadRequest();

        var updated = await _service.UpdateAsync(solicitud);
        return updated ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}
