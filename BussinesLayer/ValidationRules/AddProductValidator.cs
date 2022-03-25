using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
   public class AddProductValidator : AbstractValidator<Product>
    {
        public AddProductValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Bu kısım Boş bırakılamaz");
            RuleFor(x => x.Images).NotEmpty().WithMessage("Bu kısım Boş bırakılamaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.Images).NotEmpty().WithMessage("Resim alanı boş bırakılamaz");
            RuleFor(x => x.BrandId).NotEmpty().WithMessage("Bu alan Boş Geçilemez");
        }
    }
}
