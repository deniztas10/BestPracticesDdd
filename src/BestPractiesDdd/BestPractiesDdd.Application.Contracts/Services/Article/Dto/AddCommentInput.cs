using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BestPractiesDdd.Application.Contracts.Services.Article.Dto
{
    public class AddCommentInput
    {
        [Required]
        public Guid ArticleId { get; set; }

        [Required]
        [MaxLength(65536)]
        public string Message { get; protected set; }

        [Required]
        public int Star { get; protected set; }

    }
}
