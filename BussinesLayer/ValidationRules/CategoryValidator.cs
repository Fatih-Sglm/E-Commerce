using EntityLayer.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
   public  class CategoryValidator : AbstractValidator<CategoryViewModel>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.IconFile).NotEmpty().WithMessage("İkon Kısmı Boş bırakılmaz");
            RuleFor(x => x.ImageFİle).NotEmpty().WithMessage("Resim Kısmı Boş bırakılmaz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori İsim  Alanı Boş bırakılmaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Kategori Açıklama Alanı Boş bırakılmaz");
        }
    }
}
