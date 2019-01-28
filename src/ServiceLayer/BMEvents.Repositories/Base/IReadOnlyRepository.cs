using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BMEvents.Repositories.Base
{
    public interface IReadOnlyRepository<TEntity>
        where TEntity : class
    {
        Task<TEntity> GetAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}