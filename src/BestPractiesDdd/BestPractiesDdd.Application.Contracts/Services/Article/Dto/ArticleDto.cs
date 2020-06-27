using System;
using System.Collections.Generic;
using System.Text;

namespace BestPractiesDdd.Application.Contracts.Services.Article.Dto
{
    public class ArticleDto
    {
        public Guid Id { get; private set; }

        public Guid UserId { get; private set; }

        public string Title { get; private set; }

        public string Text { get; private set; }

        public int ClapCount { get; private set; }

        public bool IsPublihed { get; private set; }
        public bool IsEditing { get; private set; }

        //public Collection<ArticleLabel> Labels { get; set; }
    }
}
