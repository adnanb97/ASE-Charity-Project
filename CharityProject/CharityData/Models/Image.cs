using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class Image
    {
        [Key]
        public Guid Id { get; set; }
        public  string Path{ get; set; }

    }
}
