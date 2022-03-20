using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager cm = new CustomerManager(new EfCustomerRepository());
        public IActionResult Index(int id)
        {
            var values = cm.GetCustomerById(id);
            return View(values);
        }

        [HttpGet]
        public IActionResult Login()
        { 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Customer cs)
        {
            LoginValidator lv = new LoginValidator();
            ValidationResult rst = lv.Validate(cs);
            if (rst.IsValid)
            {
                Context c = new Context();
                var customer = c.Customers.FirstOrDefault(x => x.Mail == cs.Mail && x.Password == cs.Password);
                if (customer != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,cs.Mail)
                    };
                    var useridentity = new ClaimsIdentity(claims, "c");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    return RedirectToAction("Customer", "Index");
                }
            }
            return View();
}
        }
}
//Bu yöntem çalışmadı yarın videoları tekrar ile session ile brebaer register ile login kısmını ayır