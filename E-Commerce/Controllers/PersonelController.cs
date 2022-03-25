using BussinesLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using EntityLayer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.IO;
using System.Linq;

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
        ImagesManager im = new ImagesManager(new EfImagesRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        private Context db = new Context();
        public IActionResult Index()
        {
            return View();
        }

        #region "Product"

        public IActionResult ListProduct()
        {
            var values = pm.GetAllIncludeAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            ViewBag.BrandId = new SelectList(db.Brands, "Id", "Name");
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p, IFormCollection fc)
        {
            var check = fc["check"].ToString();
            if (ModelState.IsValid)
            {
                foreach (var item in p.Images)
                {
                    if(SavePic(item , check) != null)
                    {
                        p.imageS.Add(new Images { ImageName = item.FileName, Locaiton = "~/Site/img/" + item.FileName, status = true });
                    }
                }
                p.CreateDate = DateTime.Today;
                pm.TInsert(p);
                return RedirectToAction("ListProduct", "Personel");
            }
            else
            {
                ViewBag.BrandId = new SelectList(db.Brands, "Id", "Name");
                ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
                var message = ModelState.ToList();
                return View(p);
            }

        }

        public IActionResult DetailProduct(int id)
        {
            ViewBag.BrandId = new SelectList(db.Brands, "Id", "Name");
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            var vl = pm.TGetById(id);
            return View(vl);
        }
        #endregion

        public IActionResult DeleteImage(int id)
        {
            var img = im.TGetById(id);
            im.TDelete(img);
            return RedirectToAction("DetailProduct", "Personel", new { id = img.ProductId });
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(CategoryViewModel cvm , IFormCollection fc)
        {
            Category ct = new Category();
            var checkImg = fc["checkImg"].ToString();
            var checkIco = fc["checkIco"].ToString();

            if (ModelState.IsValid)
            {
                ct.Icon = SavePic(cvm.IconFile,checkIco);
                ct.Image = SavePic(cvm.ImageFİle,checkImg);
                ct.CreateDate = DateTime.Today;
                if (ct.Icon == null || ct.Image == null)
                {
                    if (ct.Icon == null && ct.Image != null)
                    {
                        ViewBag.ico = "Ikon dosyasının uzantısı hatalı!!";
                    }
                    else if (ct.Image == null && ct.Icon != null)
                    {
                        ViewBag.img = "Resim dosyasının uzantısı hatalı!!";
                    }
                    else
                    {
                        ViewBag.ico = "Ikon dosyasının uzantısı hatalı!!";
                        ViewBag.img = "Resim dosyasının uzantısı hatalı!!";

                    }
                    return View(cvm);
                }
                else
                {
                    cm.TInsert(ct);
                    return RedirectToAction("Index", "Personel");
                }
            }
            else
            {
                return View(cvm);
            }
        }
        public string SavePic(IFormFile item, string check)
        {
            var extension = Path.GetExtension(item.FileName);
            if (!new[] { "jpg", "png", "jpeg", "ico" }.Contains(extension.Trim('.').ToLower()))
            {
                return null;
            }
            else
            {
                if (check == "1")
                {
                    using var image = Image.Load(item.OpenReadStream());
                    image.Mutate(x => x.Resize(244, 244));
                    var filepath = Path.Combine(env.WebRootPath, "Site\\img", item.FileName);
                    var allName = Path.Combine(filepath, item.FileName);
                    image.Save(filepath);
                    return allName;
                }
                else
                {
                    var filepath = Path.Combine(env.WebRootPath, "Site\\img");
                    var allName = Path.Combine(filepath, item.FileName);
                    var stream = new FileStream(allName, FileMode.Create);
                    item.CopyTo(stream);
                    return allName;
                }
               
            }

        }
    }
}
//public bool upload(IFormFile file, string filepath)
//{
//    var extension = Path.GetExtension(file.FileName).Trim('.').ToLower();
//    if (!new[] { "jpg", "png", "jpeg" }.Contains(extension))
//    {
//        ViewBag.result = "dosya uzantı hatası";
//        return false;
//    }
//    else
//    {

//        var img = Image.Load(file.OpenReadStream());
//        img.Mutate(x => x.Resize(300, 300));
//        img.Save(filepath + file.FileName);
//        return true;
//    }
//}
