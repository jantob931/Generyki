namespace Generyki1.Data; 
using Microsoft.EntityFrameworkCore;
using Entities;
using Generyki1.Data.Entities;
public class AplikacjaDbContext : DbContext 
{
    public DbSet<Emplayee> Employees => Set<Emplayee>();
    public DbSet<BusinessPartner> BusinessPartners => Set<BusinessPartner>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("StorageAppDb");
    } 
}

