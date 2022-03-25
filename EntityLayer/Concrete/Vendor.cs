using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Vendor : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string ContactNumber { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public ICollection<VendorProduct> VendorProducts { get; set; }
    }
}