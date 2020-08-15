namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public class CatStatusEntity
    {
        public int Id { get; set; }
        //Activo, eliminado
        public string Name { get; set; }

        public virtual UserEntity User { get; set; }

        public virtual ProductEntity Product { get; set; }

        public virtual CustomerEntity Customer { get; set; }
    }
}
