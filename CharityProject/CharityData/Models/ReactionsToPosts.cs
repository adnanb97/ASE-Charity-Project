using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class ReactionsToPosts
    {
        public int Id { get; set; }
        public bool liked { get; set; }
        public bool commented { get; set; }
        [Required]
        public ProfilePosts postId { get; set; }
    }
}
