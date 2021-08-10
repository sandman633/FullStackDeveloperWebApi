using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Dto.Request
{
    public class NewUserActivity
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        [Required]
        public DateTime LastActivityDate { get; set; }
    }
}
