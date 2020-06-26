using BestPractiesDdd.Domain.Domains.Articles;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BestPractiesDdd.Domain.Domains.Users
{
    public class User // TODO:: Aggregate Root
    {
        [NotNull]
        public Guid Id { get; private set; }

        [NotNull]
        public string UserName { get; private set; }

        [NotNull]
        public string Password { get; private set; }

        [NotNull]
        public string Email { get; private set; }

        [CanBeNull]
        public string Name { get; private set; }

        [CanBeNull]
        public string SurName { get; private set; }

        public Collection<Article> Articles { get; private set; }

        private User() { }

        public User(
            [NotNull] Guid id,
            [NotNull] string email,
            [NotNull] string userName,
            [NotNull] string password)
        {
            Id = id;
            Email = email;
            UserName = userName;
            Password = password;
            Articles = new Collection<Article>(); //Initialize sub-collections
        }

        public void SetName([NotNull]string name)
        {
            Name = name;
        }

        public void SetSurName([NotNull] string surName)
        {
            SurName = surName;
        }

        public void SetPassword([NotNull] string password)
        {
            if(Password != password) //TODO:: Changes this method body.
            {
                Password = password;
            }
        }

    }
}
