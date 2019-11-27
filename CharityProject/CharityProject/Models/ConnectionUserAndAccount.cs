using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityProject.Models
{
    public class ConnectionUserAndAccount
    {
        public CharityData.Models.User userInstance { get; set; }
        public CharityData.Models.Account accountInstance { get; set; }
    }
}
