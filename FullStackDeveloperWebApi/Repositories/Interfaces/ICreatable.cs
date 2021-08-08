using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Repositories
{
    public interface ICreatable<TModel>
    {
        Task<TModel> CreateAsync(TModel dto);
    }
}