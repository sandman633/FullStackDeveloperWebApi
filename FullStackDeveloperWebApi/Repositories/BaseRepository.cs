using FullStackDeveloperWebApi.Models;
using FullStackDeveloperWebApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace FullStackDeveloperWebApi.Repositories
{
    public class BaseRepository<TDto, TModel> : ICrudRepository<TDto, TModel>
    where TModel : BaseEntity
    where TDto : BaseDto
    {
        protected readonly Context _context;
        protected readonly IMapper _mapper;
        protected DbSet<TModel> _dbSet => _context.Set<TModel>();
        public BaseRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task DeleteAsync(params int[] ids)
        {
            var entities = await _dbSet.Where(x => ids.Contains(x.Id))
                                       .ToListAsync();
            _context.Remove(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<TDto> UpdateAsync(TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            _context.Update(entity);
            await _context.SaveChangesAsync();
            var newEntity = await GetByIdAsync(entity.Id);

            return _mapper.Map<TDto>(newEntity);
        }

        public async Task<IEnumerable<TDto>> GetAsync()
        {
            var entities = await _dbSet.AsNoTracking().ToListAsync();

            var dtos = _mapper.Map<IEnumerable<TDto>>(entities);

            return dtos;
        }

        public async Task<TDto> GetByIdAsync(int id)
        {
            var entity = await _dbSet
                  .AsNoTracking()
                  .FirstOrDefaultAsync(x => x.Id == id);

            var dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await GetByIdAsync(entity.Id);
        }

        public virtual IQueryable<TModel> DefaultInclude(DbSet<TModel> dbSet) => dbSet;
    }
}
