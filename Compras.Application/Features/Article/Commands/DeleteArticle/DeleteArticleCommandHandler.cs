

using Compras.Application.Contracts.Persistence;
using Compras.Application.Exceptions;
using MediatR;

namespace Compras.Application.Features.Article.Commands.DeleteArticle;

public class DeleteArticleCommandHandler : IRequestHandler<DeleteArticleCommand, Unit>
{
    private readonly IArticleRepository articleRepository;

    public DeleteArticleCommandHandler(IArticleRepository articleRepository)
    {
        this.articleRepository = articleRepository;
    }

    public async Task<Unit> Handle(DeleteArticleCommand request, CancellationToken cancellationToken)
    {
        var articleToDelete = await articleRepository.GetByIdAsync(request.Id); 

        if (articleToDelete is null)
        {
            throw new NotFoundException(nameof(Article), request.Id); 
        }
        await articleRepository.DeleteAsync(articleToDelete);
        return Unit.Value;
    }
}
