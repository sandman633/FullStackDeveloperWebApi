using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Services
{
    /// <summary>
    /// Interface for deleting entity.
    /// </summary>
    public interface IDeletable
    {
        /// <summary>
        /// Interface method for deleting entity.
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task DeleteAsync(params int[] ids);
    }
}