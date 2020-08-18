using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminVentas.DataAccess.EntityConfig
{
    public class ProductConfig
    {
        /// <summary>
        /// Método que crea una tabla y asigna sus propiedades
        /// </summary>
        /// <param name="entityBuilder">Entidad para configurar</param>
        public static void SetEntityBuilder(EntityTypeBuilder<ProductEntity> entityBuilder)
        {
            //Tabla a crear
            entityBuilder.ToTable("Product");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //Establece sus propiedades/relaciones
            entityBuilder.Property(e => e.CreateDate).HasColumnType("datetime");

            entityBuilder.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.Idnumber)
                    .IsRequired()
                    .HasColumnName("IDNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.Price).HasColumnType("decimal(10, 2)");

            entityBuilder.Property(e => e.ProdServKey)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.UnitKey)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

        }
    }
}
