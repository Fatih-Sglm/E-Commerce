using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}