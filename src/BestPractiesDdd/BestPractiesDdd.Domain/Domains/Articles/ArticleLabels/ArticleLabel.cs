using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestPractiesDdd.Domain.Domains.Articles.Labels
{
    public class ArticleLabel
    {
        [NotNull]
        public Guid ArticleId { get; private set; }

        [NotNull]
        public Guid LabelId { get; private set; }
    }
}
