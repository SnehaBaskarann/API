using Microsoft.EntityFrameworkCore;
namespace UpdateApi.Data 
{

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Usermodel> Usermodels { get; set; } = null!;
}
}