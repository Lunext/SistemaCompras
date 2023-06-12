

using AutoMapper;
using Compras.Application.Features.Article.Commands.CreateArticle;
using Compras.Application.Features.Article.Commands.UpdateArticle;
using Compras.Application.Features.Article.Queries.GetAllArticles;
using Compras.Application.Features.Article.Queries.GetArticleDetails;
using Compras.Domain.Domains;

namespace Compras.Application.MappingProfiles;

public class ArticleProfile:Profile
{
    public ArticleProfile()
    {
        CreateMap<ArticleDto, Article>().ReverseMap();
        CreateMap<Article, ArticleDetailsDto>();
        CreateMap<CreateArticleCommand, Article>();
        CreateMap<UpdateArticleCommand, Article>(); 
        
    }
}
