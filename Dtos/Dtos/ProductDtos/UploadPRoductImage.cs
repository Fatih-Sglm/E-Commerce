using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.Dtos.ProductDtos
{
   public  class UploadPRoductImage
    {
        public string Location { get; set; }
        public int ProductId { get; set; }
        public bool Status { get; set; }
    }
}
