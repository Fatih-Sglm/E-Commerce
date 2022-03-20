using BussinesLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using E_Commerce.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    [AllowAnonymous]

    public class PersonelController : Controller
    {
        private readonly IWebHostEnvironment env;

        public PersonelController(IWebHostEnvironment webHostEnvironment)
        {
            env = webHostEnvironment;
        }

        ProductManager pm = new ProductManager(new EfProductRepository());
        private Context db = new Context();
        public IActionResult Index()
        {
            return View();
        }

         [HttpGet]
        public IActionResult AddProduct()
        {
            ViewBag.Brand = new SelectList(db.Brands, "Id", "Name");
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            if (p.Images != null)
            {
                var filepath = Path.Combine(env.WebRootPath, "img");
                foreach (var item in p.Images)
                {
                    var allName = Path.Combine(filepath, item.FileName);
                    using (var uploadImage = new FileStream(allName, FileMode.Create))
                    {
                        item.CopyTo(uploadImage);
                    }

                    p.imageS.Add(new Images { ImageName = item.FileName, Locaiton = "~/img/"+ item.FileName, status= true  });

                }

                p.CreateDate = DateTime.Today;
                pm.TInsert(p);
            }
            else
            {
                return RedirectToAction("Index","Home");
            }
            
            return RedirectToAction("Index", "Personel", new { id = 1 });
        }
    }
}
