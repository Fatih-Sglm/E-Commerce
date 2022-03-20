using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    [AllowAnonymous]
    public class ProductController : Controller
    {
        VendorProductManager vm = new VendorProductManager (new EfVendorProductRepository());
        public IActionResult Index()
        {
            var value = vm.TGetAll();
            return View(value);
        }

        public IActionResult ProductDetail(int id)
        {
            var value = vm.GetProductAll(id);
            return View(value);
        }
    }
}
