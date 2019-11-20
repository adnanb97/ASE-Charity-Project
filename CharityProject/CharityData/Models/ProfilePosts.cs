using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class ProfilePosts
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Message cannot be longer than 500 characters.")]
        public string message { get; set; }

        [Required]
        public Guid userId { get; set; }
        [Required]
        public Guid actionId { get; set; }
    }
}
