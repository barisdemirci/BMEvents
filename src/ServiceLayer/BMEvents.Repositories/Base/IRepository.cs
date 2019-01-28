using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BMEvents.Repositories.Base
{
    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity>
        where TEntity : class
    {
        Task AddAsync(TEntity row);

        void Update(TEntity row);

        void Delete(TEntity row);
    }
}
