﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class Messages
    {
        public Guid Id { get; set; }

        public Guid userSenderId { get; set; }
        public Guid userReceiverId { get; set; }
        public Guid organizationSenderId { get; set; }
        public Guid organizationReceiverId { get; set; } 

        [Required]
        [StringLength(500, ErrorMessage = "Message cannot be longer than 500 characters.")]
        public string message { get; set; }
        
        public DateTime sendingTime { get; set; }
    }
}
