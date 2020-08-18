using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminVentas.DataAccess.EntityConfig
{
    public class InvoiceConfig
    {
        /// <summary>
        /// Método que crea una tabla y asigna sus propiedades
        /// </summary>
        /// <param name="entityBuilder">Entidad para configurar</param>
        public static void SetEntityBuilder(EntityTypeBuilder<InvoiceEntity> entityBuilder)
        {
            //Tabla a crear
            entityBuilder.ToTable("Invoice");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //Establece sus propiedades/relaciones
            entityBuilder.Property(e => e.CreateDate).HasColumnType("datetime");

            entityBuilder.Property(e => e.Rcfreceiver)
                    .IsRequired()
                    .HasColumnName("RCFReceiver")
                    .HasMaxLength(50)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

            entityBuilder.Property(e => e.Total).HasColumnType("decimal(10, 3)");

            entityBuilder.Property(e => e.TypeId).HasColumnName("TypeID");

            entityBuilder.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("UUID")
                    .HasMaxLength(50);

            entityBuilder.HasOne(d => d.Status)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_CatStatusInvoice");

            entityBuilder.HasOne(d => d.Type)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_CatTypeInvoice");

            entityBuilder.HasOne(d => d.User)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_User");
        }
    }
}
