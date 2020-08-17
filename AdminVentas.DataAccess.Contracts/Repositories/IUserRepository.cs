using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdminVentas.DataAccess.Contracts.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> Update(int idEntity, int isActive);
    }
}
