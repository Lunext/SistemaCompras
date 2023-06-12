
using Compras.Application.Features.Article.Shared;
using MediatR;

namespace Compras.Application.Features.Article.Commands.UpdateArticle;

public class UpdateArticleCommand:BaseArticle, IRequest<Unit>
{
    public int Id { get; set; } 
}
