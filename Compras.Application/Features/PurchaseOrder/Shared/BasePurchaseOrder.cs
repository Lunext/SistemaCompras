namespace Compras.Application.Features.PurchaseOrder.Shared
{
    public abstract class BasePurchaseOrder
    {
        public string OrderNumber { get; set; } = string.Empty; 

        public DateTime OrderDate { get; set;}

        public bool IsAvailable { get; set; }

        public int ArticleId { get; set;}

        public  int MeasureUnitId { get; set;}

        public decimal UnitCost { get; set; }

        public int Amount { get; set; }
        public decimal Total { get; set; }
    }
}
