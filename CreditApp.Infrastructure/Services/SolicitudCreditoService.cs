using CreditApp.Application.Interfaces;
using CreditApp.Domain.Entities;
using CreditApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CreditApp.Infrastructure.Services;

public class SolicitudCreditoService : ISolicitudCreditoService
{
    private readonly AppDbContext _context;

    public SolicitudCreditoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<SolicitudCredito>> GetAllAsync()
    {
        return await _context.SolicitudesCredito.ToListAsync();
    }

    public async Task<SolicitudCredito?> GetByIdAsync(int id)
    {
        return await _context.SolicitudesCredito.FindAsync(id);
    }

    public async Task<SolicitudCredito> CreateAsync(SolicitudCredito solicitud)
    {
        _context.SolicitudesCredito.Add(solicitud);
        await _context.SaveChangesAsync();
        return solicitud;
    }

    public async Task<bool> UpdateAsync(SolicitudCredito solicitud)
    {
        var exists = await _context.SolicitudesCredito.AnyAsync(x => x.Id == solicitud.Id);
        if (!exists) return false;

        _context.SolicitudesCredito.Update(solicitud);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var solicitud = await _context.SolicitudesCredito.FindAsync(id);
        if (solicitud is null) return false;

        _context.SolicitudesCredito.Remove(solicitud);
        await _context.SaveChangesAsync();
        return true;
    }
}
