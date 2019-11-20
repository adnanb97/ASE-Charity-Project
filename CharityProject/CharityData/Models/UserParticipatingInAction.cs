using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class UserParticipatingInAction
    {
        public Guid Id { get; set; }
        
        public Guid userId { get; set; }
        public Guid actionId { get; set; }
    }
}
