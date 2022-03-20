using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string detail { get; set; }
        public string HouseNumber { get; set; }
        public bool Status { get; set; }

        public virtual int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        
    }
}
