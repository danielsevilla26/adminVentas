﻿using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminVentas.DataAccess.EntityConfig
{
    public class CustomerEntityConfig
    {
        /// <summary>
        /// Método que crea una tabla de acuerdo al nombre de la entidad
        /// </summary>
        /// <param name="entityBuilder"></param>
        public static void SetEntityBuilder(EntityTypeBuilder<CustomerEntity> entityBuilder)
        {
            //Tabla a crear
            entityBuilder.ToTable("Customer");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
            //Establece sus relaciones
            entityBuilder.HasOne(x => x.User).WithOne(x => x.Customer);
            entityBuilder.HasOne(x => x.Status).WithOne(x => x.Customer);
        }
    }
}