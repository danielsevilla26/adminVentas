using AdminVentas.DataAccess.Contracts;
using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using AdminVentas.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminVentas.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IBDGestorVentasContext _bdGestorVentasContext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bdGestorVentasContext"></param>
        public UserRepository(IBDGestorVentasContext bdGestorVentasContext)
        {
            _bdGestorVentasContext = bdGestorVentasContext;
        }

        public async Task<UserEntity> AddAsync(UserEntity entity)
        {
            await _bdGestorVentasContext.User.AddAsync(entity);

            await _bdGestorVentasContext.SaveChangesAsync();

            return entity;

        }

        public async Task<UserEntity> Update(UserEntity entity)
        {
            var updateEntity = _bdGestorVentasContext.User.Update(entity);

            await _bdGestorVentasContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<UserEntity> Update(int idEntity, int isActive)
        {
            var entity = await Get(idEntity);
            entity.StatusId = isActive;

            _bdGestorVentasContext.User.Update(entity);

            await _bdGestorVentasContext.SaveChangesAsync();

            return entity;
        }

        public async Task<UserEntity> Get(int idEntity)
        {
            var result = await _bdGestorVentasContext.User.FirstOrDefaultAsync(x => x.Id == idEntity);

            return result;
        }

        public async Task Delete(int idEntity)
        {
            var entity = await _bdGestorVentasContext.User.SingleAsync(x => x.Id == idEntity);

            _bdGestorVentasContext.User.Remove(entity);

            await _bdGestorVentasContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return  _bdGestorVentasContext.User.Select(x => x);
        }
    }
}
