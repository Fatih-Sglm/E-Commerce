using Microsoft.AspNetCore.Http;

namespace Dtos.ViewModels
{
    public class CategoryViewModel
    {
        public string Name { get; set; }
        public IFormFile ImageFİle { get; set; }
        public IFormFile IconFile { get; set; }

        public string Description { get; set; }
        public bool Isresize { get; set; }
    }
}