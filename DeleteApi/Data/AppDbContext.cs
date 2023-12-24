using DeleteApi.Models;
using Microsoft.EntityFrameworkCore;
// using DeleteApi.Models;
namespace DeleteApi.Data
{



public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Usermodel> Usermodels  { get; set; } = null!;
}
}