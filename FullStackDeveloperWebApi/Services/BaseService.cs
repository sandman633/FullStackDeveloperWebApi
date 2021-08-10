using FullStackDeveloperWebApi.Dto;
using FullStackDeveloperWebApi.Models;
using FullStackDeveloperWebApi.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Services
{
    public class BaseService<TDto, TModel> : ICrudService<TDto>
           where TDto : BaseDto
           where TModel : BaseEntity
    {
        private readonly ICrudRepository<TDto, TModel> _repository;

        public BaseService(ICrudRepository<TDto, TModel> repository)
        {
            _repository = repository;
        }
        public async Task<TDto> CreateAsync(TDto dto)
        {
            return await _repository.CreateAsync(dto);
        }

        public async Task DeleteAsync(params int?[] ids)
        {
            await _repository.DeleteAsync(ids);
        }

        public async Task<IEnumerable<TDto>> GetAsync()
        {
            return await _repository.GetAsync();
        }

        public async Task<TDto> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<TDto> UpdateAsync(TDto dto)
        {
            return await _repository.UpdateAsync(dto);
        }
    }
}
