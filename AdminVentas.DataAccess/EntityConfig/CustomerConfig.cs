using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminVentas.DataAccess.EntityConfig
{
    public class CustomerConfig
    {
        /// <summary>
        /// Método que crea una tabla y asigna sus propiedades
        /// </summary>
        /// <param name="entityBuilder">Entidad para configurar</param>
        public static void SetEntityBuilder(EntityTypeBuilder<CustomerEntity> entityBuilder)
        {
            //Tabla a crear
            entityBuilder.ToTable("Customer");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //Establece sus propiedades/relaciones
            entityBuilder.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.ComertialName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.Cp).HasColumnName("CP");

            entityBuilder.Property(e => e.CreateDate).HasColumnType("datetime");

            entityBuilder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(13)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.StatusId).HasColumnName("StatusID");

            entityBuilder.Property(e => e.TaxResidence)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.UserId).HasColumnName("UserID");

            entityBuilder.HasOne(d => d.Status)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_CatStatus");

            entityBuilder.HasOne(d => d.User)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_User");
        }
    }
}
