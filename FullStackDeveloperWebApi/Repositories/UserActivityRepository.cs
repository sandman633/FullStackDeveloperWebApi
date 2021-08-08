using FullStackDeveloperWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Repositories
{
    public class UserActivityRepository : IUserActivityRepository<UserActivity>
    {
        private readonly Context _context;
        protected DbSet<UserActivity> DbSet => _context.Set<UserActivity>();
        public UserActivityRepository(Context context)
        {
            _context = context;
        }
        public async Task<UserActivity> CreateAsync(UserActivity model)
        {
            await DbSet.AddAsync(model);
            Save(); 
            return await GetByIdAsync(model.Id);

        }

        public async Task DeleteAsync(params int[] ids)
        {
            var entities = await DbSet.Where(x => ids.Contains(x.Id)).ToListAsync();
            DbSet.RemoveRange(entities);
            Save();
        }

        public async Task<IEnumerable<UserActivity>> GetAsync()
        {
            var entity = await DbSet.AsNoTracking().ToListAsync();
            return entity;
        }

        public async Task<UserActivity> GetByIdAsync(int id)
        {
            var entity = DbSet.Where(x => x.Id == id).FirstOrDefault();
            return entity;
        }

        public async Task<UserActivity> UpdateAsync(UserActivity model)
        {
            DbSet.Update(model);
            var newEntity = await GetByIdAsync(model.Id);
            Save();
            return newEntity;
        }
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
