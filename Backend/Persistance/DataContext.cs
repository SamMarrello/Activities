using Microsoft.EntityFrameworkCore;
using Backend.Domain;

namespace Backend.Persistance;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Activity> Activities { get; set; }
}