using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Article.Queries.GetAllArticles;

public class GetArticlesQueryHandler : IRequestHandler<GetArticlesQuery, List<ArticleDto>>
{
    private readonly IMapper mapper;
    private readonly IArticleRepository articleRepository;

    public GetArticlesQueryHandler(IMapper mapper, IArticleRepository articleRepository)
    {
        this.mapper = mapper;
        this.articleRepository = articleRepository;
    }
   

     async Task<List<ArticleDto>> IRequestHandler<GetArticlesQuery, List<ArticleDto>>.Handle(GetArticlesQuery request, CancellationToken cancellationToken)
    {
        var articles = await articleRepository.GetArticlesWithDetails();

        var articlesMappedtoDto = mapper.Map<List<ArticleDto>>(articles); 

        return articlesMappedtoDto; 
    }
}
