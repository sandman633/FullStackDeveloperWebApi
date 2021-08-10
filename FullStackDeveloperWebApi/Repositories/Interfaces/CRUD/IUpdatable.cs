using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Repositories
{
    public interface IUpdatable<TModel>
    {
        /// <summary>
        /// Interface method for updating entity.
        /// </summary>
        /// <param name="dto">DTO.</param>
        Task<TModel> UpdateAsync(TModel dto);
    }
}