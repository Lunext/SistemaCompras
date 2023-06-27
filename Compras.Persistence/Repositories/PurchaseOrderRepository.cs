using Compras.Application.Contracts.Persistence;
using Compras.Domain.Domains;
using Compras.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Compras.Persistence.Repositories;

public class PurchaseOrderRepository : GenericRepository<PurchaseOrder>, IPurchaseOrderRepository
{
    public PurchaseOrderRepository(ComprasDatabaseContext context) : base(context)
    {
        
    }

    public async Task CreateAsync(PurchaseOrder entity)
    {
        entity.Total = entity.UnitCost * entity.Amount;
        await context.AddAsync(entity);
        
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PurchaseOrder entity)
    {
        entity.Total=entity.UnitCost * entity.Amount;
        context.Entry(entity).State = EntityState.Modified;
        await context.SaveChangesAsync();
    }

    public async Task<List<PurchaseOrder>> GetPurchaseOrdersByItsAvailability(bool isAvailable)
    {
        var purchaseOrders = await context.PurchaseOrders
            .Include(q => q.MeasureUnit)
            .Include(q => q.Article)
            .Where(able => able.IsAvailable==isAvailable)
            .ToListAsync(); 

        return purchaseOrders;
    }

    public async Task<List<PurchaseOrder>> GetPurchaseOrdersByUnitCost(decimal firstCost, decimal lastCost)
    {
       var purchaseOrdersFilteredByCost = await context.PurchaseOrders
            .Include(q => q.MeasureUnit)
            .Include(q => q.Article)
            .Where(x=> x.UnitCost>= firstCost && x.UnitCost<= lastCost)
            .ToListAsync();

        return purchaseOrdersFilteredByCost;
    }

    public async Task<List<PurchaseOrder>> GetPurchaseOrdersFilteredByDate(DateTime firstDate, DateTime lasDate)
    {
        var purchaseOrdesFilteredByDate = await context.PurchaseOrders
             .Include(q => q.MeasureUnit)
             .Include(q => q.Article)
             .Where(x => x.OrderDate.Date >= firstDate
             && x.OrderDate.Date <= lasDate)
             .ToListAsync();

        return purchaseOrdesFilteredByDate;
    }

    public async Task<List<PurchaseOrder>> GetPurchaseOrdersWithDetails()
    {
        var purchaseOrders = await context.PurchaseOrders
            .Include(q => q.MeasureUnit)
            .Include(q => q.Article)
            .ToListAsync(); 

        return purchaseOrders;
    }

    public async Task<PurchaseOrder> GetPurchaseOrderWithDetails(int id)
    {
        var purchaseOrder = await context.PurchaseOrders
            .Include(q => q.MeasureUnit)
            .Include(q => q.Article)
            .FirstOrDefaultAsync(q => q.Id==id);

        return purchaseOrder!; 
    }

   


}