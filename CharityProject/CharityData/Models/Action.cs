using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class Action
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string name { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "Description cannot be longer than 200 characters.")]
        public string description { get; set; }
        [Required]
        public bool actionType { get; set; } // 0 - participation ; 1 - donation
        [Required]
        public Guid organizationId { get; set; }
        public DateTime creationDateTime { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }
    }
}
