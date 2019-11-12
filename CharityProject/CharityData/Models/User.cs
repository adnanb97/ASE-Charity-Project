using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityData.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string creditCardNumber { get; set; }
    }
}
