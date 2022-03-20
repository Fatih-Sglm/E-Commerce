using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.ViewComponents.Customer
{
    public class AdressList :ViewComponent
    {
        AdressManager ad = new AdressManager(new EfAdressRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = ad.ListAdress(id);
            return View(values);
        }
    }
}
