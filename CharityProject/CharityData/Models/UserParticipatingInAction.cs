using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharityData.Models
{
    public class UserParticipatingInAction
    {
        public int Id { get; set; }
        
        public User userId { get; set; }
        public Action actionId { get; set; }
    }
}
