using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ua.UdemyTodoAppNTier.Dtos.WorkDtos;

namespace Ua.UdemyTodoAppNTier.Business.ValidationRules
{
    public class WorkCreateDtoValidator:AbstractValidator<WorkCreateDto>
    {
        public WorkCreateDtoValidator()
        {
            RuleFor(x => x.Definition).MaximumLength(200).WithMessage("En fazla 200 karakter olabilir").NotEmpty().WithMessage("Boş geçilemez");

        }
    }
}
