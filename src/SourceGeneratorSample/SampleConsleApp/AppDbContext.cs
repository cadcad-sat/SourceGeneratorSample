using Microsoft.EntityFrameworkCore;

namespace SampleConsleApp;

public class AppDbContext : DbContext
{
    public DbSet<SampleEntity> SampleEntity { get; set; }
}
