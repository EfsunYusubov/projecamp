using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Adınızı yazın");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Doldurun");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Maximum 50 karakter");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Minimum 2 karakter");

        }
    }
}
