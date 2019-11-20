using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class Payment
    {
        public Guid Id { get; set; }

        [Required]
        public Guid userSenderId { get; set; }
        [Required]
        public Guid organizationReceiverId { get; set; }
        
        [Required]
        [Range(0,Double.MaxValue)]
        public double amount { get; set; }
    }
}
