using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Models
{
    public class UserActivity
    {
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastActivityDate { get; set; }

    }
}
