using AdminVentas.DataAccess.Contracts;
using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminVentas.DataAccess.EntityConfig
{
    public class UserConfig
    {
        /// <summary>
        /// Método que crea una tabla y asigna sus propiedades
        /// </summary>
        /// <param name="entityBuilder">Entidad para configurar</param>
        public static void SetEntityBuilder(EntityTypeBuilder<User> entityBuilder)
        {
            //Tabla a crear
            entityBuilder.ToTable("User");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
            entityBuilder.Property(e => e.CreateDate).HasColumnType("datetime");

            //Establece sus propiedades/relaciones
            entityBuilder.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

            entityBuilder.HasOne(d => d.Status)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_CatStatus");
        }
    }
}
