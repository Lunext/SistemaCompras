using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Article.Queries.GetArticleDetails;

public class GetArticleDetailsQueryHandler : IRequestHandler<GetArticleDetailsQuery, ArticleDetailsDto>
{
    private readonly IMapper mapper;
    private readonly IArticleRepository articleRepository;

    public GetArticleDetailsQueryHandler(IMapper mapper, IArticleRepository articleRepository)
    {
        this.mapper = mapper;
        this.articleRepository = articleRepository;
    }
    public async Task<ArticleDetailsDto> Handle(GetArticleDetailsQuery request, CancellationToken cancellationToken)
    {
        var article = await articleRepository.GetArticleWithDetails(request.Id);

        var articleMappedToDto = mapper.Map<ArticleDetailsDto>(article);

        return articleMappedToDto; 
    }
}
