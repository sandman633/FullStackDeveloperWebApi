using AutoMapper;
using FullStackDeveloperWebApi.Dto;
using FullStackDeveloperWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Repositories
{
    public class UserActivityRepository : BaseRepository<UserActivityDto,UserActivity>, IUserActivityRepository
    {

        public UserActivityRepository(Context context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task CreateRange(params UserActivityDto[] userActivityDtos)
        {
            var users = _mapper.Map<IEnumerable<UserActivity>>(userActivityDtos);
            _dbSet.AddRange(users);
            await _context.SaveChangesAsync();
        }
    }
}
