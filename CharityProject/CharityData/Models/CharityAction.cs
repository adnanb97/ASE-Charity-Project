using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class CharityAction
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Display(Name = "Action name")]
        public string name { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "Description cannot be longer than 200 characters.")]
        [Display(Name = "Description")]
        public string description { get; set; }
        [Required]
        [Display(Name = "Type of action")]
        public bool actionType { get; set; } // 0 - participation ; 1 - donation
        [Required]
        public Guid organizationId { get; set; }
        public DateTime creationDateTime { get; set; }

        [Display(Name = "Start date")]
        public DateTime startDateTime { get; set; }

        [Display(Name = "End date")]
        public DateTime endDateTime { get; set; }
    }
}
