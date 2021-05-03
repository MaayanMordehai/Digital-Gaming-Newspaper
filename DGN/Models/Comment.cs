﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGN.Models
{
    public class Comment
    {
        // Primery key
        public int Id { get; set; }

        [StringLength(200), MinimumLength = 5]
        public string Body { get; set; }

        // Shouldnt display in the GET form
        [Required]
        [ForeignKey("User")]
        public int AuthorId { get; set; }

        [Required]
        public User Author { get; set; }

        // Shouldnt display in the GET form
        [Required]
        [ForeignKey("Article")]
        public int RelatedArticleId { get; set; }

        [Required]
        public Article RelatedArticle { get; set; }
    }
}