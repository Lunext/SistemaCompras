using Compras.Domain.Domains;

namespace Compras.Application.Contracts.Persistence;

public interface IPurchaseOrderRepository: IGenericRepository<PurchaseOrder>
{
    Task<List<PurchaseOrder>> GetPurchaseOrdersWithDetails();

    Task<PurchaseOrder> GetPurchaseOrderWithDetails(int id);

    Task<List<PurchaseOrder>> GetPurchaseOrdersByItsAvailability(bool isAvailable);

    Task<List<PurchaseOrder>> GetPurchaseOrdersFilteredByDate(DateTime firstDate, DateTime lasDate); 

}