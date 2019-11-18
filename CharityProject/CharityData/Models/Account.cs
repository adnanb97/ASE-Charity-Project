using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters.")]
        public string username { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Password cannot be longer than 50 characters.")]
        public string password { get; set; }

        public Image imageId { get; set; } 

        public bool isUser { get; set; }
    }
}
