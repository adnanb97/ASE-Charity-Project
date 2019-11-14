using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class ItemInAction
    {
        public int Id { get; set; }

        [Required]
        public Item itemId { get; set; }
        [Required]
        public Action actionId { get; set; }

    }
}
