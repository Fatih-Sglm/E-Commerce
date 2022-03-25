using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Dtos.ProductDtos
{
    public class AddProductDto : IDto
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public bool Popular { get; set; }

        [NotMapped]
        public List<IFormFile> Files { get; set; }
    }
}