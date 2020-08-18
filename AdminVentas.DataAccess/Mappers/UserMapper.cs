using AdminVentas.Business.Models;
using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminVentas.DataAccess.Mappers
{
    public class UserMapper
    {
        /// <summary>
        /// Mapea un modelo proveniente de Business a una entidad de DataAcces
        /// </summary>
        /// <param name="dto">Modelo a mapear</param>
        /// <returns>Devuelve una entidad</returns>
        public static UserEntity Map(User dto)
        {
            return new UserEntity()
            {
                Id = dto.Id,
                Email = dto.Email,
                Password = dto.Password,
                StatusId = dto.StatusId,
                CreateDate = dto.CreateDate
            };
        }

        /// <summary>
        /// Mapea una entidad proveniente de DataAccess a un modelo de Business
        /// </summary>
        /// <param name="dto">Entidad a mapear</param>
        /// <returns>Devuelve un model</returns>
        public static User Map(UserEntity entity)
        {
            return new User()
            {
                Id = entity.Id,
                Email = entity.Email,
                Password = entity.Password,
                StatusId = entity.StatusId,
                CreateDate = entity.CreateDate
            };
        }
    }
}
