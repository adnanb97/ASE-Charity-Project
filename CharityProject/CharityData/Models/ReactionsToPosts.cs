using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class ReactionsToPosts
    {
        public Guid Id { get; set; }
        public bool liked { get; set; }
        public bool commented { get; set; }
        [Required]
        public Guid postId { get; set; }
    }
}
