using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Article.Commands.CreateArticle;

public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, int>
{
    private readonly IMapper mapper;
    private readonly IArticleRepository articleRepository;

    public CreateArticleCommandHandler(IMapper mapper, IArticleRepository articleRepository)
    {
        this.mapper = mapper;
        this.articleRepository = articleRepository;
    }

    public async Task<int> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
    {
        var articleToCreate = mapper.Map<Domain.Domains.Article>(request);
        await articleRepository.CreateAsync(articleToCreate);
        return articleToCreate.Id;
    }

}
