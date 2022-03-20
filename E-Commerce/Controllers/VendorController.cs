using BussinesLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    [AllowAnonymous]
    public class VendorController : Controller
    {
        private Context db = new Context();
        VendorProductManager vm = new VendorProductManager(new EfVendorProductRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SellProduct()
        {

            ViewBag.ProductID = new SelectList(db.Products, "Id", "Title");
            return View();
        }


        [HttpPost]
        public IActionResult SellProduct(VendorProduct vp)
        {
            return View();
        }

        public IActionResult ListProduct(VendorProduct vp)
        {
            return View();
        }
    }
}


