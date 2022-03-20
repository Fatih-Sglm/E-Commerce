using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Concrete
{
    public  class Product
    {
        public Product()
        {
            imageS = new List<Images>();
        }
        
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public string description { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual  int BrandId { get; set; }
        public bool Popular { get; set; }

        public virtual Brand Brands { get; set; }

        [NotMapped]
        public IEnumerable<IFormFile> Images { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<VendorProduct> VendorProducts { get; set; }
        
        public virtual List<Images> imageS { get; set; }
    }
}
