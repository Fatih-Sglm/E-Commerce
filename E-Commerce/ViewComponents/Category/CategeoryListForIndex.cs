//using BussinesLayer.Concrete;
//using DataAccesLayer.EntityFramework;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace E_Commerce.ViewComponents.Category
//{
//    public class CategeoryListForIndex : ViewComponent
//    {
//        public class CategoryList : ViewComponent
//        {
//            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
//            public IViewComponentResult Invoke()
//            {
//                var values = cm.TGetAll();
//                return View(values);
//            }
//        }
//    }
//}
