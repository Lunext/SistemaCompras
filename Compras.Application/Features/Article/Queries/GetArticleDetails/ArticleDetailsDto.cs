

using Compras.Application.Features.Article.Shared;

namespace Compras.Application.Features.Article.Queries.GetArticleDetails;

public class ArticleDetailsDto: BaseArticle
{
    public int Id { get; set;}
    public DateTime? DateCreated { get; set;}
    public DateTime? DateModified { get; set;}

}
