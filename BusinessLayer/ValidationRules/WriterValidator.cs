using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazmaq məcburiyyətindəsiniz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresini yazın");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifrəni yazın");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Ən az 2 hərf girin");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Max 50 hərf girilə bilər");
        }
    }
}
