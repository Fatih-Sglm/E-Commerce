namespace EntityLayer.Concrete
{
    public class Adress : BaseEntity
    {
        public string Title { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Detail { get; set; }
        public string HouseNumber { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}