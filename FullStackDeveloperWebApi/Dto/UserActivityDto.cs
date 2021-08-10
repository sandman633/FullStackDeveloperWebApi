using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Dto
{
    public class UserActivityDto : BaseDto
    {

        public int UserId { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime LastActivityDate { get; set; }
    }
}
