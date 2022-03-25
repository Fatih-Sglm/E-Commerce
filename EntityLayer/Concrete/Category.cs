using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category : BaseEntity
    {
        
        public string Name { get; set; }
        public string Image { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}