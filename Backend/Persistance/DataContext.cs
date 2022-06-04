using Microsoft.EntityFrameworkCore;

namespace Backend.Persistance;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
}