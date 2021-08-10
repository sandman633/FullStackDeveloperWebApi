using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Repositories
{
    public interface ICreatable<TDto,TModel>
    {
        Task<TDto> CreateAsync(TDto dto);
    }
}