using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Dto.Response
{
    public class ResponseUserActivity
    {

        public int UserId { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime LastActivityDate { get; set; }
        
    }
}
