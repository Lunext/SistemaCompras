

using Compras.Domain.Common;

namespace Compras.Domain.Domains;

public class Article:BaseEntity
{
    public string Description { get; set; } = string.Empty;
    public string Make { get; set; } = string.Empty; 
    public MeasureUnit? MeasureUnit { get; set; }   
    public int MeasureUnitId { get; set; }
    public int Existence { get; set; }

}
