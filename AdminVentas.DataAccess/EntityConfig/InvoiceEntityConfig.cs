using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminVentas.DataAccess.EntityConfig
{
    public class InvoiceEntityConfig
    {
        /// <summary>
        /// Método que crea una tabla de acuerdo al nombre de la entidad
        /// </summary>
        /// <param name="entityBuilder"></param>
        public static void SetEntityBuilder(EntityTypeBuilder<InvoiceEntity> entityBuilder)
        {
            //Tabla a crear
            entityBuilder.ToTable("Invoice");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
            //Establece sus relaciones
            entityBuilder.HasOne(x => x.Status).WithOne(x => x.Invoice);
            entityBuilder.HasOne(x => x.Type).WithOne(x => x.Invoice);
            entityBuilder.HasOne(x => x.User).WithOne(x => x.Invoice);
        }
    }
}
