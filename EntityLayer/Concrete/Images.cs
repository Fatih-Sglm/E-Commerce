namespace EntityLayer.Concrete
{
    public class Images : BaseEntity
    {
        public string Location { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}