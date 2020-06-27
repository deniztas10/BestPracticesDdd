using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPractiesDdd.Domain.Domains.Articles
{
    public interface IArticleRepository
    {
        Task<Article> Get(Guid id);

        Task Update(Article article);

        Task<List<Article>> GetArticles();

    }
}
