using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.ViewComponents.Product
{
    public class ImagesList: ViewComponent
    {
        ImagesManager im = new ImagesManager(new EfImagesRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = im.TGetAll(id);
            return View(values);
        }

    }
}
