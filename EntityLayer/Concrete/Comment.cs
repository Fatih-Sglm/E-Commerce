using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public float Rate { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

        public virtual int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual int ProductId { get; set; }
        public virtual VendorProduct VendorProduct { get; set; }
    }
}
