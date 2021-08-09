using System.Collections.Generic;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Repositories
{
    public interface IGettable<TModel>
    {
        Task<IEnumerable<TModel>> GetAsync();
    }
}