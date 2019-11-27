using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace CharityData.Models
{
    public class Account
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters.")]
        [Display(Name = "Username")]
        public string username { get; set; }

        [Required, DataType(DataType.Password)]
        [StringLength(80, ErrorMessage = "Password cannot be longer than 80 characters.")]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Display(Name = "Email Address")]
        public string email { get; set; }

        public Guid imageId { get; set; } 

        public bool isUser { get; set; }

       
    }
}
