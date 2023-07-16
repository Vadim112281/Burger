using Microsoft.EntityFrameworkCore;
using Restoran.Models;

namespace Restoran.Data.Context;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {}

    public DbSet<Order> Orders { get; set; }
}