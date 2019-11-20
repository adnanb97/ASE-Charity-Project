using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class Organization
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string name { get; set; }

        public Guid UserAccount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateOfFounding { get; set; }

        [StringLength(200, ErrorMessage = "Description cannot be longer than 200 characters.")]
        public string description { get; set; }

        [Required]
        public Guid creditCardNumber { get; set; }
    }
}
