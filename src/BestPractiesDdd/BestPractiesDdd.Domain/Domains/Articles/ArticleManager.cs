using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPractiesDdd.Domain.Domains.Articles
{
    public class ArticleManager
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleManager(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public Task Edit(Article article) => _articleRepository.Update(article);
    }
}
