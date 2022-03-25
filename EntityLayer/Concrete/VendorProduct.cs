using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class VendorProduct : BaseEntity
    {
        public int ProductId { get; set; }
        public int VendorId { get; set; }

        public string PriceString
        {
            get { return Price.ToString("N"); }
        }

        public decimal Price { get; set; }

        public string ShippingString
        {
            get { return Shipping.ToString("N"); }
        }

        public decimal Shipping { get; set; }
        public Product Product { get; set; }
        public Vendor Vendor { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}