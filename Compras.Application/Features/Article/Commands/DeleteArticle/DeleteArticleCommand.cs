using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Article.Commands.DeleteArticle;

public class DeleteArticleCommand:IRequest<Unit>
{
    public int Id { get; set; }
}
