using Compras.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Domain.Domains;

public class PurchaseOrder:BaseEntity
{
    public string OrderNumber { get; set; } = string.Empty;

    public DateTime OrderDate { get; set; }

    public int Amount { get; set; } 

    public Article? Article { get; set; }
    public int? ArticleId { get; set; }

    public MeasureUnit? MeasureUnit { get; set; }
    public int? MeasureUnitId { get; set; }

    public decimal UnitCost { get; set; }

    public decimal Total { get; set; }
}
