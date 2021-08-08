using FullStackDeveloperWebApi.Models;

namespace FullStackDeveloperWebApi.Repositories
{
    internal interface IUserActivityRepository<TModel> : ICrudRepository<TModel>, ISave
    {
    }
}