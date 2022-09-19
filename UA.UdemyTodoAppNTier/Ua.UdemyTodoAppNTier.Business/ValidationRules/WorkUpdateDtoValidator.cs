using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ua.UdemyTodoAppNTier.Dtos.WorkDtos;

namespace Ua.UdemyTodoAppNTier.Business.ValidationRules
{
    public class WorkUpdateDtoValidator:AbstractValidator<WorkUpdateDto>
    {
        public WorkUpdateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.Definition).MaximumLength(250).WithMessage("250 karakterden fazla olamaz");
            RuleFor(x => x.Definition).MinimumLength(10).WithMessage("10 karakterden az olamaz");
        }
    }
}
