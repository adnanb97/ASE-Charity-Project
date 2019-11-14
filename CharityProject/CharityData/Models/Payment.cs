using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Required]
        public User userSenderId { get; set; }
        [Required]
        public Organization organizationReceiverId { get; set; }
        
        [Required]
        [Range(0,Double.MaxValue)]
        public double amount { get; set; }
    }
}
