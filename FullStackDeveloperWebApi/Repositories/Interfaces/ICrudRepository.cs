using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Repositories
{
    public interface ICrudRepository<TModel> :
        ICreatable<TModel>,
        IDeletable,
        IUpdatable<TModel>,
        IGettable<TModel>,
        IGettableById<TModel>
    {

    }
}
