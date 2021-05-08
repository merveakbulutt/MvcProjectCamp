using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(p => p.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz");
            RuleFor(p => p.CategoryName).MinimumLength(3).WithMessage("En az 3 karekter girişi yapın");
            RuleFor(p => p.CategoryName).MaximumLength(20).WithMessage("lütfen 20 karakterden fazla değer girişi yapmayın");

        }
    }
}
