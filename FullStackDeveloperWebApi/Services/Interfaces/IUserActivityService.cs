using FullStackDeveloperWebApi.Dto;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Services
{
    public interface IUserActivityService : ICrudService<UserActivityDto>
    {
        public Task CreateRange(params UserActivityDto[] userActivityDtos);
    }
}