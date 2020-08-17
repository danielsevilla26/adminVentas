using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminVentas.DataAccess.EntityConfig
{
    public class TaxConfig
    {
        /// <summary>
        /// Método que crea una tabla y asigna sus propiedades
        /// </summary>
        /// <param name="entityBuilder">Entidad para configurar</param>
        public static void SetEntityBuilder(EntityTypeBuilder<Tax> entityBuilder)
        {
            //Tabla a crear
            entityBuilder.ToTable("Tax");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //Establece sus propiedades/relaciones
            entityBuilder.Property(e => e.CreateDate).HasColumnType("datetime");

            entityBuilder.Property(e => e.FactorType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.FeeRate)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.Rate).HasColumnType("decimal(10, 6)");

            entityBuilder.Property(e => e.TaxKey)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

            entityBuilder.HasOne(d => d.Status)
                    .WithMany(p => p.Tax)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tax_CatStatus");

            entityBuilder.HasOne(d => d.TypeAmbit)
                    .WithMany(p => p.Tax)
                    .HasForeignKey(d => d.TypeAmbitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tax_CatAmbitType");

            entityBuilder.HasOne(d => d.Type)
                    .WithMany(p => p.Tax)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tax_CatTaxType");

            entityBuilder.HasOne(d => d.User)
                    .WithMany(p => p.Tax)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tax_User");
        }
    }
}
