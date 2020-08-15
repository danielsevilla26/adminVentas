using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminVentas.DataAccess.EntityConfig
{
    public class Product2TaxEntityConfig
    {
        /// <summary>
        /// Método que crea una tabla de acuerdo al nombre de la entidad
        /// </summary>
        /// <param name="entityBuilder"></param>
        public static void SetEntityBuilder(EntityTypeBuilder<Product2TaxEntity> entityBuilder)
        {
            //Tabla a crear
            entityBuilder.ToTable("Product2Tax");
            //Establece sus relaciones
            entityBuilder.HasOne(x => x.Product).WithMany(x => x.Product2Tax).HasForeignKey(x => x.IdProduct);
            entityBuilder.HasOne(x => x.Tax).WithMany(x => x.Product2Tax).HasForeignKey(x => x.IdTax);
            //Se establecen claves primarias para evitar duplicidad de claves
            entityBuilder.HasKey(x => new { x.IdProduct, x.IdTax });
            entityBuilder.Property(x => x.IdProduct).IsRequired();
            entityBuilder.Property(x => x.IdTax).IsRequired();
        }
    }
}
