using Microsoft.EntityFrameworkCore;
using CreditApp.Domain.Entities;

namespace CreditApp.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<SolicitudCredito> SolicitudesCredito { get; set; } = null!;
}
