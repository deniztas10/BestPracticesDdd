using BestPractiesDdd.Domain.Domains.Articles;
using BestPractiesDdd.Domain.Domains.Articles.Labels;
using BestPractiesDdd.Domain.Domains.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestPractiesDdd.Infrastructure.EntityFrameworkCore
{
    public class EfCoreDbContext : DbContext
    {

        public EfCoreDbContext(DbContextOptions<EfCoreDbContext> options) :base(options)
        { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleLabel> Labels { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
