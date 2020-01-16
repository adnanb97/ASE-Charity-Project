﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class Card
    {
        public Guid Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateOfExpiry { get; set; }
        

        [Required]
        [StringLength(50, ErrorMessage = "Bank name cannot be longer than 50 characters.")]
        public string bankName { get; set; }

        public double amount { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Account number must have 16 digits.")]
        public string creditCardNumber { get; set; }
    }
}
