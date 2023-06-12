using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.Article.Commands.UpdateArticle;

public class UpdateArticleCommandHandler : IRequestHandler<UpdateArticleCommand, Unit>
{
    private readonly IMapper mapper;
    private readonly IArticleRepository articleRepository;

    public UpdateArticleCommandHandler(IMapper mapper, IArticleRepository articleRepository)
    {
        this.mapper = mapper;
        this.articleRepository = articleRepository;
    }

    public async Task<Unit> Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
    {
        var articleToUpdate = await articleRepository.GetByIdAsync(request.Id);

        await articleRepository.UpdateAsync(articleToUpdate);

        return Unit.Value;
    }
}
