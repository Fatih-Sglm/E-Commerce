namespace EntityLayer.Concrete
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public float Rate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public VendorProduct VendorProduct { get; set; }
    }
}