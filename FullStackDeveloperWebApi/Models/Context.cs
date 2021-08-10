﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Models
{
    public class Context : DbContext
    {
        DbSet<UserActivity> UsersActivity { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
