using Compras.Application.Features.Article.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Article.Commands.CreateArticle;

public class CreateArticleCommand:BaseArticle, IRequest<int>
{
}
