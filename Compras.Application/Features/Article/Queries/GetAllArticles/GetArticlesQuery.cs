

using MediatR;

namespace Compras.Application.Features.Article.Queries.GetAllArticles;

public record class GetArticlesQuery:IRequest<List<ArticleDto>>;

