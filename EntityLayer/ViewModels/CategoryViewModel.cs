using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.ViewModels
{
    public class CategoryViewModel : Category
    {
        public IFormFile ImageFİle { get; set; }
        public IFormFile IconFile { get; set; }
    }
}
