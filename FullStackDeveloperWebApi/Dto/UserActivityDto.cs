﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Dto
{
    public class UserActivityDto : BaseDto
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        [Required]
        public DateTime LastActivityDate { get; set; }
    }
}
