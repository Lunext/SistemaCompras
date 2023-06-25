using Azure.Core;
using Compras.Application.Contracts.Persistence;
using Compras.Domain.Domains;
using Compras.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Compras.Persistence.Repositories;

public class ArticleRepository : GenericRepository<Article>, IArticleRepository
{
    public ArticleRepository(ComprasDatabaseContext context) : base(context)
    {
       
    }

    public async Task<List<Article>> GetArticlesWithDetails()
    {
        var articles = await context.Articles
           .Include(q => q.MeasureUnit)
           .ToListAsync();

        return articles;
    }

    public async Task<Article> GetArticleWithDetails(int id)
    {
        var article = await context.Articles
            .Include(q => q.MeasureUnit)
            .FirstOrDefaultAsync(q => q.Id == id);

        return article!; 
    }
}
