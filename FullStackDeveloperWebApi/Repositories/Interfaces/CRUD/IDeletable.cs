using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Repositories
{
    public interface IDeletable
    {
        Task DeleteAsync(params int?[] ids);
    }
}