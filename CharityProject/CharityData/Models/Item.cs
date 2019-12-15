using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Display(Name = "Name of Item")]
        public string name { get; set; }

        [StringLength(200, ErrorMessage = "Description cannot be longer than 200 characters.")]
        [Display(Name = "Item description")]
        public string description { get; set; }

        [Required]
        [Display(Name = "Value of an item")]
        public int value { get; set; }

        public Guid userDonatedId { get; set; }
    }
}
