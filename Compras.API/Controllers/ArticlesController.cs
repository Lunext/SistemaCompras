using Compras.Application.Features.Article.Commands.CreateArticle;
using Compras.Application.Features.Article.Commands.DeleteArticle;
using Compras.Application.Features.Article.Commands.UpdateArticle;
using Compras.Application.Features.Article.Queries.GetAllArticles;
using Compras.Application.Features.Article.Queries.GetArticleDetails;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Compras.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IMediator mediator;

        public ArticlesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<ArticleDto>> Get()
        {
            var articles = await mediator.Send(new GetArticlesQuery());
            return articles;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ArticleDetailsDto>> Get (int id)
        {
            var article = await mediator.Send(new GetArticleDetailsQuery(id));
            return Ok(article);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Post(CreateArticleCommand article)
        {
            var response = await mediator.Send(article);
            return CreatedAtAction(nameof(Get), new { id = response }); 
        }

        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Put(UpdateArticleCommand article)
        {
            await mediator.Send(article);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteArticleCommand { Id = id }; 
            await mediator.Send(command);
            return NoContent();
        }

    }
}



