namespace UnitOfWorkAndGenericRepository.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string? UrunAdi { get; set; }
        public int CategoryId { get; set; }
        public Category? Kategori { get; set; }
    }
}
