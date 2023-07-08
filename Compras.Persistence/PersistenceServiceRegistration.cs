
using Compras.Application.Contracts.Persistence;
using Compras.Persistence.DatabaseContext;
using Compras.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Compras.Persistence;

public static class PersistenceServiceRegistration
{
    public static  IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ComprasDatabaseContext>(options =>
        {
            
            options.UseSqlServer(configuration.GetConnectionString("ComprasDatabaseConnectionString"));
        });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<IMeasureUnitRepository, MeasureUnitRepository>();
        services.AddScoped<ISupplierRepository, SupplierRepository>(); 
        services.AddScoped<IArticleRepository, ArticleRepository>();
        services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
        services.AddScoped<IAccountingEntryRepository, AccountingEntryRepository>();    
        return services;
    }

}
