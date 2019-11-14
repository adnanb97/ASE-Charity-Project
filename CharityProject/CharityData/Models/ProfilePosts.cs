using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class ProfilePosts
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Message cannot be longer than 500 characters.")]
        public string message { get; set; }

        [Required]
        public User userId { get; set; }
        [Required]
        public Action actionId { get; set; }
    }
}
