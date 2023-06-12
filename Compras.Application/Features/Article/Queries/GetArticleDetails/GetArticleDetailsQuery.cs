
using MediatR;

namespace Compras.Application.Features.Article.Queries.GetArticleDetails;

public record GetArticleDetailsQuery(int Id): IRequest<ArticleDetailsDto>;

