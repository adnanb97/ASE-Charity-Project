using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class Messages
    {
        public int Id { get; set; }

        public User userSenderId { get; set; }
        public User userReceiverId { get; set; }
        public Organization organizationSenderId { get; set; }
        public Organization organizationReceiverId { get; set; } 

        [Required]
        [StringLength(500, ErrorMessage = "Message cannot be longer than 500 characters.")]
        public string message { get; set; }
    }
}
