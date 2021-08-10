using AutoMapper;
using FullStackDeveloperWebApi.Dto;
using FullStackDeveloperWebApi.Dto.Request;
using FullStackDeveloperWebApi.Dto.Response;
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
            CreateMap<UserActivity, UserActivityDto>();
            CreateMap<UserActivityDto, UserActivity>().ForMember(x => x.Id, y => y.Ignore());
            CreateMap<NewUserActivity, UserActivityDto>().ReverseMap();
            CreateMap<ResponseUserActivity, UserActivityDto>().ReverseMap();
        }
    }
}
