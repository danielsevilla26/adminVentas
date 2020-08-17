using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdminVentas.Application.Contracts.Services
{
    public interface IUserService
    {
        Task<string> GetUserEmail(int id);
    }
}
