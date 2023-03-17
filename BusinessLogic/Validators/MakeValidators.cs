using Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validators
{
    public class MakeValidators : AbstractValidator<MakeDto>
    {
        public MakeValidators()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .MinimumLength(2);
        }
    }
}
