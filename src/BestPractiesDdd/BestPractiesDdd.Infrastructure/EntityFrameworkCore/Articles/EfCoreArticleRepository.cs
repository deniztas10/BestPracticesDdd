using BestPractiesDdd.Domain.Domains.Articles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPractiesDdd.Infrastructure.EntityFrameworkCore.Articles
{
    public class EfCoreArticleRepository : IArticleRepository
    {

        private readonly EfCoreDbContext _dbContext;
        public EfCoreArticleRepository(EfCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public async Task<Article> Get(Guid id)
        {
            return await _dbContext.Articles.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task Update(Article article)
        {
            _dbContext.Articles.Update(article);
           await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Article>> GetArticles()
        {
            return await _dbContext.Articles.ToListAsync();
        }


    }
}
