using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class LoginValidator : AbstractValidator<Customer>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail kısım Boş bırakılamaz");
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Lütfen Geçerli bir E-mail giriniz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
        }
    }
}
