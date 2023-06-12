using Compras.Domain.Domains;

namespace Compras.Application.Contracts.Persistence;

public interface IArticleRepository: IGenericRepository<Article>
{
    Task<List<Article>> GetArticlesWithDetails();
    Task<Article> GetArticleWithDetails(int id); 
}
