﻿using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.ColorName).MinimumLength(2);
            RuleFor(c => c.ColorName).NotNull();
            RuleFor(c => c.ColorName).Must(StartWithA).WithMessage("Yeni renk girisi A harfi ile baslamali.");
        }//Core islenecek daha.

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
