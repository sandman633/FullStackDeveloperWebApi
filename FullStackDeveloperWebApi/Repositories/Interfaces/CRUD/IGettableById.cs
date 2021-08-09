using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Repositories
{
    public interface IGettableById<TModel>
    {
        /// <summary>
        /// Interface method for getting entities by id.
        /// </summary>
        /// <param name="id">Identifier.</param>
        Task<TModel> GetByIdAsync(int id);
    }
}