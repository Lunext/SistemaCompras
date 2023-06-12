

namespace Compras.Application.Features.Article.Shared;

public abstract class BaseArticle
{
    public string Description { get; set; } = string.Empty;
    public string Make { get; set; } = string.Empty; 
    public int MeasureUnitId { get; set; }
    public int Existence { get; set;}
    public bool IsAvailable { get; set;}
}
