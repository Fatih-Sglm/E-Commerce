using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.IO;
using System.Linq;

namespace E_Commerce.Controllers
{
    [AllowAnonymous]
    public class BaseController  : Controller
    {
        public string SavePic(IFormFile item, bool check)
        {
            var extension = Path.GetExtension(item.FileName);
            if (!new[] { "jpg", "png", "jpeg", "ico" }.Contains(extension.Trim('.').ToLower()))
            {
                return null;
            }
            else
            {
                if (check)
                {
                    using var image = Image.Load(item.OpenReadStream());
                    image.Mutate(x => x.Resize(244, 244));
                    var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Site/img", item.FileName);
                    var allName = Path.Combine(filepath, item.FileName);
                    image.Save(filepath);
                    return allName;
                }
                else
                {
                    var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Site/img");
                    var allName = Path.Combine(filepath, item.FileName);
                    var stream = new FileStream(allName, FileMode.Create);
                    item.CopyTo(stream);
                    return allName;
                }

            }

        }



    }
}
