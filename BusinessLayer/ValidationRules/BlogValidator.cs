using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blogun başlığını doldurun");
            RuleFor(x => x.CategoryID).NotEmpty().WithMessage("Kateqoriya mütləq doldurulmalıdır");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blogun içini doldurun");
            RuleFor(x => x.BlogContent).MinimumLength(50).WithMessage("Blogun içini doldurun");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blogun şəkilini doldurun");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Yazı limitini aşdınız");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Minimum 5 hərf olmalıdır");
        }
    }
}
