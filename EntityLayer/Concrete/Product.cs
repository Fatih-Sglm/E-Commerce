using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Product : BaseEntity
    {
        
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; } 
        public int BrandId { get; set; }
        public bool Popular { get; set; }

        public Brand Brands { get; set; }

        [NotMapped]
        public  List<IFormFile> Files { get; set; }

        public Category Category { get; set; }
        public ICollection<VendorProduct> VendorProducts { get; set; }

        public ICollection<Images> imageS { get; set; }

    }
}