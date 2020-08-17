using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminVentas.DataAccess.EntityConfig
{
    public class CatInvoiceTypeConfig
    {
        /// <summary>
        /// Método que crea una tabla y asigna sus propiedades
        /// </summary>
        /// <param name="entityBuilder">Entidad para configurar</param>
        public static void SetEntityBuilder(EntityTypeBuilder<CatInvoiceType> entityBuilder)
        {
            //Tabla a crear
            entityBuilder.ToTable("CatInvoiceType");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //Establece sus propiedades/relaciones
            entityBuilder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
        }
    }
}
