using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Repositories
{
    public interface ICrudRepository<TDto,TModel> :
        ICreatable<TDto,TModel>,
        IDeletable,
        IUpdatable<TDto>,
        IGettable<TDto>,
        IGettableById<TDto>
    {

    }
}
