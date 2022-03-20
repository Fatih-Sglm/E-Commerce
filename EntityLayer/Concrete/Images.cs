using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Images
    {
        [Key]
        public int Id { get; set; }
        public string ImageName { get; set; }

        public string Locaiton { get; set; }

        public bool  status { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set;  }
    }
}
