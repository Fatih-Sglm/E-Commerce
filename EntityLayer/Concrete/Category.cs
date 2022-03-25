using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
