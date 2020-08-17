using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdminVentas.DataAccess.Contracts.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> AddAsync(T element);

        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);

        Task Delete(int id);

        Task<T> Update(T element);
    }
}
