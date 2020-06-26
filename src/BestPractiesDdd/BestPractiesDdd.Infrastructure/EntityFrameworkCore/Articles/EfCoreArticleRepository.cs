using BestPractiesDdd.Domain.Domains.Articles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPractiesDdd.Infrastructure.EntityFrameworkCore.Articles
{
    public class EfCoreArticleRepository : IArticleRepository
    {
        public Task<Article> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
