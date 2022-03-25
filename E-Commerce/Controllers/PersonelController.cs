using AutoMapper;
using BussinesLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Dtos.Dtos.ProductDtos;
using Dtos.ViewModels;
using E_Commerce.Mapping.AutoMapperProfile;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Commerce.Models;
using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System.IO;

namespace E_Commerce.Controllers
{
    [AllowAnonymous]
    public class PersonelController : BaseController
    {
        private readonly IMapper _mapper;
        public PersonelController(IMapper mapper)
        {
            _mapper = mapper;
        }

        private ProductManager pm = new ProductManager(new EfProductRepository());
        private ImagesManager im = new ImagesManager(new EfImagesRepository());
        private CategoryManager cm = new CategoryManager(new EfCategoryRepository());
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
        public IActionResult AddProduct(AddProductDto addProductDto)
        {
            
            if (ModelState.IsValid)
            {
                addProductDto.CreatedAt = DateTime.Today;
                pm.TInsert(_mapper.Map<Product>(addProductDto));
                foreach (var item in addProductDto.Files)
                {
                    if (SavePic(item,true) != null)
                    {
                        UploadPRoductImage pd = new UploadPRoductImage();
                        pd.Location = "~/Site/img/" + item.FileName;
                        pd.ProductId = addProductDto.Id;
                        pd.Status = true;
                        im.TInsert(_mapper.Map<Images>(pd));
                    }
                }
                
                return RedirectToAction("ListProduct", "Personel");
            }
            else
            {
                ViewBag.BrandId = new SelectList(db.Brands, "Id", "Name");
                ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
                var message = ModelState.ToList();
                return View(addProductDto);
            }
        }

        public IActionResult DetailProduct(int id)
        {
            ViewBag.BrandId = new SelectList(db.Brands, "Id", "Name");
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            var vl = pm.TGetById(id);
            return View(vl);
        }

        #endregion "Product"

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
        public IActionResult AddCategory(CategoryViewModel cvm)
        {
            Category ct = new Category();

            if (ModelState.IsValid)
            {
                ct.Icon = SavePic(cvm.IconFile, false);
                ct.Image = SavePic(cvm.ImageFİle, cvm.Isresize);
                ct.CreatedAt = DateTime.Today;
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


       
    }
}