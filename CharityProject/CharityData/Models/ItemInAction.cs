using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class ItemInAction
    {
        public Guid Id { get; set; }

        [Required]
        public Guid itemId { get; set; }
        [Required]
        public Guid actionId { get; set; }

    }
}
