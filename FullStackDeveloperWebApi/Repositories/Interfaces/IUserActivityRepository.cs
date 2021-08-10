using FullStackDeveloperWebApi.Dto;
using FullStackDeveloperWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Repositories
{
    public interface IUserActivityRepository : ICrudRepository<UserActivityDto,UserActivity>
    {
        public Task CreateRange(params UserActivityDto[] userActivityDtos);
    }
}