using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Services
{
    /// <summary>
    /// Interface for creating new entity.
    /// </summary>
    public interface ICreatable<TDto>
    {
        /// <summary>
        /// Interface method for creating new entity.
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<TDto> CreateAsync(TDto dto);
    }
}