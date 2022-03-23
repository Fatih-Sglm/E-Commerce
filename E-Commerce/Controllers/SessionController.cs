using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using EntityLayer.ViewModels;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace E_Commerce.Controllers
{
    [AllowAnonymous]
    public class SessionController : Controller
    {
        CustomerManager cm = new CustomerManager(new EfCustomerRepository());

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Customer c)
        {
            Context cd = new Context();
            if (ModelState.IsValid)
            {
                var dv = cd.Customers.FirstOrDefault(x => x.Mail == c.Mail && x.Password == c.Password);
                if (dv != null)
                {
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, c.Mail)
                };

                    var useridentity = new ClaimsIdentity(claims, "user");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Customer", new { id = dv.Id });

                }
            }
            else
            {
                var message = ModelState.ToList();
            }
            return View(c);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewmodel rv)
        {
            Context c = new Context();
            Customer cs = new Customer();
            if (!ModelState.IsValid)
            {
                return View("Register", rv);
            }
            else
            {
                if (rv.Password == rv.ConfirmPassword)
                {
                    var isEmailAlreadyExists = c.Customers.Any(x => x.Mail.ToLower() == rv.Mail.ToLower());

                    string noResult = "Bu Mail Daha Önce Kayıt Olunmuş.";
                    if (isEmailAlreadyExists)
                    {
                        ViewBag.Message = noResult;
                        return View("Register", rv);
                    }


                    else
                    {
                        cs.Name = rv.Name;
                        cs.SurName = rv.SurName;
                        cs.Mail = rv.Mail;
                        cs.PhoneNumber = rv.PhoneNumber;
                        cs.Password = rv.Password;
                        c.Customers.Add(cs);
                    }
                    c.SaveChanges();

                    return RedirectToAction("Login", "Session");
                }
                else
                {
                    return View("Register", rv);
                }

            }
        }
    }
}
