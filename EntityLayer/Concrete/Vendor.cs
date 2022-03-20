using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Vendor
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string ContactNumber { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public string Status { get; set; }
        public virtual ICollection<VendorProduct> VendorProducts { get; set; }
    }
}