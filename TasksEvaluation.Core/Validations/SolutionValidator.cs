using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksEvaluation.Core.Entities;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Core.Validations
{
    public class SolutionValidator : AbstractValidator<Solution>
    {
        public SolutionValidator()
        {
            RuleFor(s => s.SolutionFile).NotNull().NotEmpty()
                .Must(file => 
                file.EndsWith(".pdf") || file.EndsWith(".zip") || file.EndsWith(".jpeg") || file.EndsWith(".jpg") || file.EndsWith(".png"))
               .WithMessage("Solution file must end with '.pdf' , '.zip' , '.jpeg' , '.jpg' or '.png'");
        }
    }
}
