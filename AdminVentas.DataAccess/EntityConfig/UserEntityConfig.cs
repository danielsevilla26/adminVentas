using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminVentas.DataAccess.EntityConfig
{
    public class UserEntityConfig
    {
        /// <summary>
        /// Método que crea una tabla de acuerdo al nombre de la entidad
        /// </summary>
        /// <param name="entityBuilder"></param>
        public static void SetEntityBuilder(EntityTypeBuilder<UserEntity> entityBuilder)
        {
            //Tabla a crear
            entityBuilder.ToTable("User");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
            //Establece sus relaciones
            entityBuilder.HasOne(x => x.Status).WithOne(x => x.User);
            entityBuilder.HasOne(x => x.Invoice).WithOne(x => x.User);
            entityBuilder.HasOne(x => x.Product).WithOne(x => x.User);
            entityBuilder.HasOne(x => x.Tax).WithOne(x => x.User);
        }
    }
}
