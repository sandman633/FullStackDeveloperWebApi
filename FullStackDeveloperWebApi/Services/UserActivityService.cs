using FullStackDeveloperWebApi.Dto;
using FullStackDeveloperWebApi.Models;
using FullStackDeveloperWebApi.Repositories;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Services
{
    public  class UserActivityService : BaseService<UserActivityDto,UserActivity>, IUserActivityService
    {
        public IUserActivityRepository _repo;
        public UserActivityService(IUserActivityRepository repo): base(repo)
        {
            _repo = repo;
        }

        public Task CreateRange(params UserActivityDto[] userActivityDtos)
        {
            return _repo.CreateRange(userActivityDtos);
        }
    }
}
