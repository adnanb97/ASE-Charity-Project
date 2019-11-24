using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Mvc;
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
        public string username { get; set; }

        [Required, DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "Password cannot be longer than 50 characters.")]
        public string password { get; set; }

        public Guid imageId { get; set; } 

        public bool isUser { get; set; }

       
    }
}
