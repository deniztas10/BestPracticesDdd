using BestPractiesDdd.Domain.Domains.Articles.Labels;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BestPractiesDdd.Domain.Domains.Articles
{
    public class Article // TODO::Aggregate Root
    {
        [NotNull]
        public Guid Id { get; private set; }

        [NotNull]
        public Guid UserId { get; private set; } // No navigation property to another aggregate root!

        [NotNull]
        public string Title { get; private set; }

        public string Text { get; private set; }

        public int ClapCount { get; private set; }

        public bool IsPublihed { get; private set; }
        public bool IsEditing { get; private set; }

        public Collection<ArticleLabel> Labels { get; set; }


        public Article(
            [NotNull] Guid id,
            [NotNull] Guid userId,
            [NotNull] string title,
            string text)
        {
            Id = id;
            UserId = userId;
            Title = title;
            Text = text; //CHECK
            ClapCount = 0;
            IsEditing = true;
            Labels = new Collection<ArticleLabel>();
        }

        private Article() { }


        public void SetText(string text)
        {
            //TODO:: Write CHECK.
            //Text = String.NotNullOrWhiteSpace(value: text, nameof(text));
        }
        public void Publish()
        {
            if (IsEditing == true)
            {
                IsEditing = false;
                IsPublihed = true;
            }
        }

        public void Edit()
        {
            if (IsPublihed == true)
            {
                IsPublihed = false;
                IsEditing = true;
            }
        }

        public void AddClap()
        {
            ClapCount++;
        }
    }
}
