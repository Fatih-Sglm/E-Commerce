using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class VendorProduct
    {
        [Key]
        public int Id { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int VendorId { get; set; }
        public bool IsAppoIsApproved { get; set; }
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
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
