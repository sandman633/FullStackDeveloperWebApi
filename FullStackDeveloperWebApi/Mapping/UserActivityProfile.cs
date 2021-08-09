using AutoMapper;
using FullStackDeveloperWebApi.Dto;
using FullStackDeveloperWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Mapping
{
    public class UserActivityProfile : Profile
    {
        public UserActivityProfile()
        {
            CreateMap<UserActivity, UserActivityDto>().ReverseMap();
        }
    }
}
