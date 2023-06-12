
using Compras.Domain.Common;
using Compras.Domain.Domains;
using Microsoft.EntityFrameworkCore;

namespace Compras.Persistence.DatabaseContext;

public class ComprasDatabaseContext : DbContext
{

    public ComprasDatabaseContext(DbContextOptions<ComprasDatabaseContext> options)
        : base(options)
    {

    }

    public DbSet<Department> Departments {get; set ;}
    public DbSet<MeasureUnit> MeasureUnits { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Article> Articles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ComprasDatabaseContext).Assembly); 
        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach(var entry in base.ChangeTracker.Entries<BaseEntity>().
            Where(q=> q.State == EntityState.Added || q.State == EntityState.Modified))
        {
            entry.Entity.DateModified = DateTime.Now;
            var isEntityStateAdded = entry.State == EntityState.Added;

            if (isEntityStateAdded)
            {
                entry.Entity.DateCreated = DateTime.Now; 
            }

        }
        return base.SaveChangesAsync(cancellationToken);
    }

}


