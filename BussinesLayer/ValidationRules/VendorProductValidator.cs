using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
   public  class VendorProductValidator : AbstractValidator<VendorProduct>
    {
        public VendorProductValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("BU kısım Boş bırakılamaz");
            RuleFor(x => x.Shipping).NotEmpty().WithMessage("Lütfen Geçerli bir email giriniz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Şifre boş geçilemez");
        }

    }
}