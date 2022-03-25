using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.ViewComponents.Product
{
    public class Last5Prdct : ViewComponent
    {
        VendorProductManager vm = new VendorProductManager(new EfVendorProductRepository());
        public IViewComponentResult Invoke ()
        {
            var values =  vm.GetLast5Product();
            return View(values);
        }
    }
}
